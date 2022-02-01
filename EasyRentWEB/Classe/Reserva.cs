using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace EasyRentWEB.Classe
{
    public class Reserva
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public string cnh { get; set; }
        public string celular { get; set; }
        public string categoria { get; set; }
        public DateTime dtHoraRetirada { get; set; }
        public DateTime dtHoraDevol { get; set; }
        public string kmDesejado { get; set; }
        public string kmExtra { get; set; }
        public string bebeConforto { get; set; }
        public string cadeiraBebe { set; get; }
        public string assentoElevado { get; set; }
        public string valorTotal { get; set; }
        public string totalDias { get; set; }
        public string quantidadeBebe { get; set; }
        public string quantidadeCadeira { get; set; }
        public string quantidadeAssento { get; set; }

        public Reserva()
        {

        }

        public Reserva (string _nome, string _cpf, string _cnpj, string _cnh, string _celular, string _categoria, DateTime _dtHoraRetirada, 
            DateTime _dtHoraDevol, string _kmDesejado, string _kmExtra, string _bebeConforto, string _cadeiraBebe, string _assentoElevado,
            string _valorTotal, string _totalDias, string _quantidadeBebe, string _quantidadeCadeira, string _quantidadeAssento)
        {
            this.assentoElevado = _assentoElevado;
            this.bebeConforto = _bebeConforto;
            this.cadeiraBebe = _cadeiraBebe;
            this.categoria = _categoria;
            this.celular = _celular;
            this.cnh = _cnh;
            this.cnpj = _cnpj;
            this.cpf = _cpf;
            this.dtHoraDevol = _dtHoraDevol;
            this.dtHoraRetirada = _dtHoraRetirada;
            this.kmDesejado = _kmDesejado;
            this.kmExtra = _kmExtra;
            this.nome = _nome;
            this.totalDias = _totalDias;
            this.valorTotal = _valorTotal;
            this.quantidadeAssento = _assentoElevado;
            this.quantidadeBebe = _bebeConforto;
            this.quantidadeCadeira = _cadeiraBebe;
        }

        public DataTable Buscar_Reserva( int _id)
        {
            DataTable dt = new DataTable();
            Classe.Conexoes conexoes = new Conexoes("conexao");
            conexoes.cmd.CommandText = "ps_Reserva_Cliente";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conexoes.cmd.Parameters.AddWithValue("IDPessoa", _id);
            conexoes.cmd.Connection = conexoes.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = conexoes.cmd;
            adapter.Fill(dt);

            //SqlDataReader dr;
            //dr = conexoes.cmd.ExecuteReader();

            //string categoria = "";

            //if (dr.Read())
            //{
            //    this.assentoElevado = dr.GetString(14).ToString();
            //    this.bebeConforto = dr.GetString(12).ToString();
            //    this.cadeiraBebe = dr.GetString(13).ToString();
            //    this.categoria = dr.GetString(7).ToString();
            //    this.celular = dr.GetString(6).ToString();
            //    this.cnh = dr.GetString(5).ToString();
            //    this.cnpj = dr.GetString(4).ToString();
            //    this.cpf = dr.GetString(3).ToString();
            //    this.dtHoraDevol = dr.GetString(9).ToString();
            //    this.dtHoraRetirada = dr.GetString(8).ToString();
            //    this.kmDesejado = dr.GetString(10).ToString();
            //    this.kmExtra = dr.GetString(11).ToString();
            //    this.nome = dr.GetString(2).ToString();
            //    this.totalDias = dr.GetString(16).ToString();
            //    this.valorTotal = dr.GetString(15).ToString();
            //}

            return (dt);
        }

        public void InserirReserva(int _id)
        {
            Classe.Conexoes conexoes = new Classe.Conexoes();

            conexoes.cmd.CommandText = "pi_nova_reserva";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexoes.cmd.Connection = conexoes.con;

            conexoes.cmd.Parameters.AddWithValue("IDPessoa", _id);
            conexoes.cmd.Parameters.AddWithValue("NomeCliente", this.nome);
            conexoes.cmd.Parameters.AddWithValue("CPFCliente", this.cpf);
            conexoes.cmd.Parameters.AddWithValue("CNPJ", this.cnpj);
            conexoes.cmd.Parameters.AddWithValue("CNH", this.cnh);
            conexoes.cmd.Parameters.AddWithValue("Celular", this.celular);
            conexoes.cmd.Parameters.AddWithValue("Categoria", this.categoria);
            conexoes.cmd.Parameters.AddWithValue("DtHoraRetirada", this.dtHoraRetirada);
            conexoes.cmd.Parameters.AddWithValue("DtHoraDevol", this.dtHoraDevol);
            conexoes.cmd.Parameters.AddWithValue("KmDesejado", this.kmDesejado);
            conexoes.cmd.Parameters.AddWithValue("KmExtra", this.kmExtra);
            conexoes.cmd.Parameters.AddWithValue("BebeConforto", this.bebeConforto);
            conexoes.cmd.Parameters.AddWithValue("QuantidadeBebe", this.quantidadeBebe);
            conexoes.cmd.Parameters.AddWithValue("CadeiraBebe", this.cadeiraBebe);
            conexoes.cmd.Parameters.AddWithValue("QuantidadeCadeira", this.quantidadeCadeira);
            conexoes.cmd.Parameters.AddWithValue("AssentoElevado", this.assentoElevado);
            conexoes.cmd.Parameters.AddWithValue("QuantidadeAssento", this.quantidadeAssento);
            conexoes.cmd.Parameters.AddWithValue("ValorTotal", this.valorTotal);
            conexoes.cmd.Parameters.AddWithValue("TotalDias", this.totalDias);
            conexoes.cmd.Parameters.AddWithValue("Situacao", "Reserva");

            conexoes.con.Open();
            conexoes.cmd.ExecuteNonQuery();
            conexoes.con.Close();
        }

        public DataTable visualizar_reserva_funcionario()
        {
            DataTable dt = new DataTable();
            Classe.Conexoes conexoes = new Conexoes("conexao");
            conexoes.cmd.CommandText = "ps_Reserva_Funcionario";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;


            conexoes.cmd.Connection = conexoes.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = conexoes.cmd;
            adapter.Fill(dt);

            return (dt);
        }        
    }
}