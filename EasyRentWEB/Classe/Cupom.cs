using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EasyRentWEB.Classe
{
    public class Cupom
    {
        public string CodigoCupom { get; set; }
        public DateTime Validade { get; set; }
        public decimal percentual { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public decimal ValorMinimo { get; set; }

        public Cupom()
        {

        }

        public Cupom(string _codigoCupom, DateTime _validade, decimal _percentual, int _quantidade, string _categoria, decimal _valorMinimo)
        {
            this.CodigoCupom = _codigoCupom;
            this.Validade = _validade;
            this.percentual = _percentual;
            this.Quantidade = _quantidade;
            this.Categoria = _categoria;
            this.ValorMinimo = _valorMinimo;
        }

        public void Adicionar()
        {
            Conexoes conexoes = new Conexoes("conexao");

            conexoes.cmd.CommandText = "pi_Cupom";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexoes.cmd.Connection = conexoes.con;

            conexoes.cmd.Parameters.AddWithValue("CodigoCupom", this.CodigoCupom);
            conexoes.cmd.Parameters.AddWithValue("Validade", this.Validade);
            conexoes.cmd.Parameters.AddWithValue("percentual", this.percentual);
            conexoes.cmd.Parameters.AddWithValue("Quantidade", this.Quantidade);
            conexoes.cmd.Parameters.AddWithValue("Categoria", this.Categoria);
            conexoes.cmd.Parameters.AddWithValue("ValorMinimo", this.ValorMinimo);

            conexoes.con.Open();
            conexoes.cmd.ExecuteNonQuery();
            conexoes.con.Close();
        }

        public void Verificar()
        {
            Conexoes conexoes = new Conexoes("conexao");

            conexoes.cmd.CommandText = "ps_cupom";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexoes.cmd.Connection = conexoes.con;

            conexoes.cmd.Parameters.AddWithValue("CodigoCupom", this.CodigoCupom);

            SqlDataReader dr;

            conexoes.con.Open();

            dr = conexoes.cmd.ExecuteReader();

            dr.Read();

            this.percentual = dr.GetDecimal(3);
            this.Validade = dr.GetDateTime(2);
            this.Quantidade = dr.GetInt32(4);
            this.Categoria = dr.GetString(5);
            this.ValorMinimo = dr.GetDecimal(6);
        }

        public void cupom_usado()
        {
            Conexoes conexoes = new Conexoes("conexao");

            conexoes.cmd.CommandText = "cupom_usado";
            conexoes.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexoes.cmd.Connection = conexoes.con;

            conexoes.cmd.Parameters.AddWithValue("Quantidade", this.Quantidade);
            conexoes.cmd.Parameters.AddWithValue("CodigoCupom", this.CodigoCupom);

            conexoes.con.Open();
            conexoes.cmd.ExecuteNonQuery();
            conexoes.con.Close();
        }
    }
}