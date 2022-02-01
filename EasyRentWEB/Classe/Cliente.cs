using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EasyRentWEB.Classe
{
    public class Cliente
    {
        public string login { get; set; }
        public string senha { get; set; }
        public  string nome { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string razao { get; set; }
        public string email { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string categoria { get; set; }
        public string genero { get; set; }
        public string cnh { get; set; }
        public DateTime dtaNasc { get; set; }
        public string rg { get; set; }
        
        public Cliente()
        {

        }

        public Cliente (string _login, string _senha, string _nome, string _telefone, string _celular, string _cep, string _endereco, string _numero,
             string _complemento, string _cidade, string _bairro, string _uf, string _razao, string _email, string _cpf, string _cnpj, string _categoria,
             string _genero, string _cnh, DateTime _dtaNasc, string _rg)
        {
            this.login = _login;
            this.senha = _senha;
            this.nome = _nome;
            this.telefone = _telefone;
            this.celular = _celular;
            this.cep = _cep;
            this.endereco = _endereco;
            this.numero = _numero;
            this.complemento = _complemento;
            this.cidade = _cidade;
            this.bairro = _bairro;
            this.uf = _uf;
            this.razao = _razao;
            this.email = _email;
            this.cpf = _cpf;
            this.cnpj = _cnpj;
            this.categoria = _categoria;
            this.genero = _genero;
            this.cnh = _cnh;
            this.dtaNasc = _dtaNasc;
            this.rg = _rg;

        }

        public int Login()
        {
            Classe.Conexoes conexoes = new Conexoes("conexao");
            conexoes.cmd.CommandText = "ps_cliente_login";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conexoes.cmd.Parameters.AddWithValue("loginCliente", this.login);
            conexoes.cmd.Parameters.AddWithValue("senhaCliente", this.senha);

            conexoes.cmd.Connection = conexoes.con;

            SqlDataReader dr;

            conexoes.con.Open();

            dr = conexoes.cmd.ExecuteReader();
            dr.Read();
             int id = dr.GetInt32(0);
            conexoes.con.Close();
            return (id);

        }

        public string Buscar_Cliente(int _id)
        {
            Classe.Conexoes conexoes = new Conexoes("conexao");
            conexoes.cmd.CommandText = "ps_cliente_login";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conexoes.cmd.Parameters.AddWithValue("IDPessoa", _id);
            conexoes.cmd.Connection = conexoes.con;
            conexoes.con.Open();

            SqlDataReader dr;
            dr = conexoes.cmd.ExecuteReader();

            string categoria = "";

            if (dr.Read())
            {
                categoria = dr.GetString(1).ToString();
                this.categoria = dr.GetString(1).ToString();

                if (dr.GetString(1).ToString() == "PF")
                {

                    this.razao = ("");


                    this.nome = dr.GetString(2).ToString();
                    this.telefone = dr.GetString(18).ToString();
                    this.celular = dr.GetString(17).ToString();
                    this.email = dr.GetSqlString(19).ToString();
                    this.endereco = dr.GetString(10).ToString();
                    this.bairro = dr.GetString(14).ToString();
                    this.cidade = dr.GetString(13).ToString();
                    this.cep = dr.GetString(16).ToString();
                    this.uf = dr.GetString(15).ToString();
                    this.numero = dr.GetString(11).ToString();
                    this.complemento = dr.GetString(12).ToString();
                    this.cpf = dr.GetString(5).ToString();
                    this.genero = dr.GetString(3).ToString();
                    this.login = dr.GetString(20).ToString();
                    this.senha = dr.GetString(21).ToString();
                    this.cnh = dr.GetString(7).ToString();
                    this.dtaNasc = dr.GetDateTime(4);
                    this.cpf = dr.GetString(5).ToString();
                    this.rg = dr.GetString(6).ToString();
                    this.cnh = dr.GetString(7).ToString();                    
                    this.cnh = dr.GetString(7).ToString();                    
                }

                else if (dr.GetString(1).ToString() == "PJ")
                {

                    this.razao = dr.GetString(9).ToString();


                    this.nome = dr.GetString(2).ToString();
                    this.telefone = dr.GetString(18).ToString();
                    this.celular = dr.GetString(17).ToString();
                    this.email = dr.GetSqlString(19).ToString();
                    this.endereco = dr.GetString(10).ToString();
                    this.bairro = dr.GetString(14).ToString();
                    this.cidade = dr.GetString(13).ToString();
                    this.cep = dr.GetString(16).ToString();
                    this.uf = dr.GetString(15).ToString();
                    this.numero = dr.GetString(11).ToString();
                    this.complemento = dr.GetString(12).ToString();
                    this.cnpj = dr.GetString(8).ToString();
                    this.login = dr.GetString(20).ToString();
                    this.senha = dr.GetString(21).ToString();

                    categoria = (dr.GetString(1).ToString());

                }
                        

            }
            return (categoria);
        }

        public void Atualizar_Cliente(int _id)
        {
            Classe.Conexoes conexoes = new Conexoes("conexao");

            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexoes.cmd.Connection = conexoes.con;

            if (this.categoria == "PF")
            { 
                conexoes.cmd.CommandText = "pu_cliente_web";
                
                conexoes.cmd.Parameters.AddWithValue("IDPessoa", _id);
                conexoes.cmd.Parameters.AddWithValue("Nome", this.nome);                
                conexoes.cmd.Parameters.AddWithValue("Logradouro", this.endereco);
                conexoes.cmd.Parameters.AddWithValue("CEP", this.cep);
                conexoes.cmd.Parameters.AddWithValue("Bairro", this.bairro);
                conexoes.cmd.Parameters.AddWithValue("Cidade", this.cidade);
                conexoes.cmd.Parameters.AddWithValue("Telefone", this.telefone);
                conexoes.cmd.Parameters.AddWithValue("Celular", this.celular);
                conexoes.cmd.Parameters.AddWithValue("Numero", this.numero);
                conexoes.cmd.Parameters.AddWithValue("Complemento", this.complemento);
                conexoes.cmd.Parameters.AddWithValue("Email", this.email);
                conexoes.cmd.Parameters.AddWithValue("UF", this.uf);
                conexoes.cmd.Parameters.AddWithValue("Sexo", this.genero);
                conexoes.cmd.Parameters.AddWithValue("Categoria", this.categoria);
                conexoes.cmd.Parameters.AddWithValue("SenhaPessoa", this.senha);
            }

            else if (this.categoria == "PJ")
            {
                conexoes.cmd.CommandText = "pu_cliente_web";

                conexoes.cmd.Parameters.AddWithValue("IDPessoa", _id);
                conexoes.cmd.Parameters.AddWithValue("Nome", this.nome);
                conexoes.cmd.Parameters.AddWithValue("Logradouro", this.endereco);
                conexoes.cmd.Parameters.AddWithValue("CEP", this.cep);
                conexoes.cmd.Parameters.AddWithValue("Bairro", this.bairro);
                conexoes.cmd.Parameters.AddWithValue("Cidade", this.cidade);
                conexoes.cmd.Parameters.AddWithValue("Telefone", this.telefone);
                conexoes.cmd.Parameters.AddWithValue("Celular", this.celular);
                conexoes.cmd.Parameters.AddWithValue("Numero", this.numero);
                conexoes.cmd.Parameters.AddWithValue("Complemento", this.complemento);
                conexoes.cmd.Parameters.AddWithValue("Email", this.email);
                conexoes.cmd.Parameters.AddWithValue("UF", this.uf);
                conexoes.cmd.Parameters.AddWithValue("RazaoSocial", this.razao);
                conexoes.cmd.Parameters.AddWithValue("Categoria", this.categoria);
                conexoes.cmd.Parameters.AddWithValue("SenhaPessoa", this.senha);
            }
 
            conexoes.con.Open();
            conexoes.cmd.ExecuteNonQuery();
            conexoes.con.Close();
        }

        public void cadastroCliente()
        {
            Classe.Conexoes conexoes = new Conexoes("conexao");

            conexoes.cmd.CommandText = "pi_Cliente";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexoes.cmd.Connection = conexoes.con;


            conexoes.cmd.Parameters.AddWithValue("Nome", this.nome);
            conexoes.cmd.Parameters.AddWithValue("Telefone", this.telefone);
            conexoes.cmd.Parameters.AddWithValue("Celular", this.celular);
            conexoes.cmd.Parameters.AddWithValue("Email", this.email);
            conexoes.cmd.Parameters.AddWithValue("Logradouro", this.endereco);
            conexoes.cmd.Parameters.AddWithValue("Bairro", this.bairro);
            conexoes.cmd.Parameters.AddWithValue("Cidade", this.cidade);
            conexoes.cmd.Parameters.AddWithValue("UF", this.uf);
            conexoes.cmd.Parameters.AddWithValue("CEP", this.cep);
            conexoes.cmd.Parameters.AddWithValue("Numero", this.numero);
            conexoes.cmd.Parameters.AddWithValue("Complemento", this.complemento);
            conexoes.cmd.Parameters.AddWithValue("Categoria", this.categoria);
            conexoes.cmd.Parameters.AddWithValue("LoginPessoa", this.login);
            conexoes.cmd.Parameters.AddWithValue("SenhaPessoa", this.senha);
            conexoes.cmd.Parameters.AddWithValue("dataNascimento", this.dtaNasc);
            conexoes.cmd.Parameters.AddWithValue("Sexo", this.genero);
            conexoes.cmd.Parameters.AddWithValue("RG", this.rg);
            conexoes.cmd.Parameters.AddWithValue("CPF", this.cpf);
            conexoes.cmd.Parameters.AddWithValue("CNH", this.cnh);
            conexoes.cmd.Parameters.AddWithValue("CNPJ", this.cnpj);
            conexoes.cmd.Parameters.AddWithValue("RazaoSocial", this.razao);


            conexoes.con.Open();
            conexoes.cmd.ExecuteNonQuery();
            conexoes.con.Close();
        }
    }
}