using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace EasyRentWEB.Classe
{
    public class Locacao
    {
        public int IDLocacao;
        public int IDFuncionario;
        public int IDReserva;
        public DateTime dtRetirada;
        public DateTime dtDevol;
        public string NomeCliente;
        public string Cpf;
        public string Cnh;
        public string Cnpj;
        public string Razao;
        public string Celular;
        public string Categoria;
        public decimal Sinal;
        public int IDCarro;
        public string NomeCarro;
        public string Placa;
        public string Km;
        public string KmDesejado;
        public string KmExtra;
        public string BebeConforto;
        public string QuantidadeBebe;
        public string CadeiraBebe;
        public string QuantidadeCadeira;
        public string AssentoElevado;
        public string QuantidadeAssento;
        public decimal ValorTotal;
        public string Situacao;
        public string FormaPagamento;

        public Locacao()
        {

        }

        public Locacao(int _idlocacao, int _idfuncionario, int _idreserva, DateTime _dtretirada, DateTime _dtdevol, string _nomecliente,
            string _cpf, string _cnh, string _cnpj, string _razao, string _celular, string _categoria, decimal _sinal, int _idcarro,
            string _nomecarro, string _placa, string _km, string _kmdesejado, string _kmextra, string _bebeconforto, string _quantidadebebe, string _cadeirabebe,
            string _quantidadecadeira, string _assentoelevado, string _quantidadeassento, decimal _valortotal, string _situacao, string _formapagamento)
        {
            this.AssentoElevado = _assentoelevado;
            this.BebeConforto = _bebeconforto;
            this.CadeiraBebe = _cadeirabebe;
            this.Categoria = _categoria;
            this.Celular = _celular;
            this.Cnh = _cnh;
            this.Cnpj = _cnpj;
            this.Cpf = _cpf;
            this.dtDevol = _dtdevol;
            this.dtRetirada = _dtretirada;
            this.FormaPagamento = _formapagamento;
            this.IDCarro = _idcarro;
            this.IDFuncionario = _idfuncionario;
            this.IDLocacao = _idlocacao;
            this.IDReserva = _idreserva;
            this.Km = _km;
            this.KmDesejado = _kmdesejado;
            this.KmExtra = _kmextra;
            this.NomeCarro = _nomecarro;
            this.NomeCliente = _nomecliente;
            this.Placa = _placa;
            this.QuantidadeAssento = _quantidadeassento;
            this.QuantidadeBebe = _quantidadebebe;
            this.QuantidadeCadeira = _quantidadecadeira;
            this.Razao = _razao;
            this.Sinal = _sinal;
            this.Situacao = _situacao;
            this.ValorTotal = _valortotal;
        }

        public DataTable Visualizar()
        {
            DataTable dt = new DataTable();
            Classe.Conexoes conexoes = new Conexoes("conexao");
            conexoes.cmd.CommandText = "ps_locacao_andamento";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;


            conexoes.cmd.Connection = conexoes.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = conexoes.cmd;
            adapter.Fill(dt);

            return (dt);
        }
    }
}