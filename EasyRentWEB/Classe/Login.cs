using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EasyRentWEB.Classe
{
    public class Login
    {
        public string login { get; set; }
        public string senha { get; set; }
        public string categoria { get; set; }
        public Login()
        {

        }
        public Login(string _login, string _senha, string _categoria)
        {
            this.login = _login;
            this.senha = _senha;
            this.categoria = _categoria;
        }
        public int Login1()
        {
            Classe.Conexoes conexoes = new Conexoes("conexao");
            conexoes.cmd.CommandText = "ps_Login_Pessoa";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conexoes.cmd.Parameters.AddWithValue("LoginPessoa", this.login);
            conexoes.cmd.Parameters.AddWithValue("SenhaPessoa", this.senha);

            conexoes.cmd.Connection = conexoes.con;

            SqlDataReader dr;

            conexoes.con.Open();

            dr = conexoes.cmd.ExecuteReader();

            int id = 0;

            if (dr.HasRows)
            {
                dr.Read();

                id = dr.GetInt32(0);
                this.categoria = dr.GetString(1);
                conexoes.con.Close();
                
            }
            return (id);
        }
        
    }
}