using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EasyRentWEB.Classe
{
    public class Conexoes
    {
        
        public SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conexao"].ToString());
        public SqlCommand cmd = new SqlCommand();

        public Conexoes()
        {
            this.cmd.Connection = con;
        }

        public Conexoes(string conexao)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conexao"].ToString();
        }
       
    }
}