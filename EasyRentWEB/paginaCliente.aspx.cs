using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["idcliente"] != null)
            {
                string idcliente = Request.Cookies["idcliente"].Value.ToString();
            }
                       
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginCliente.aspx");
        }

        protected void lnkAtualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("atualizacaoCliente.aspx");
        }

        protected void lnkBusca_Reserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("visualizarReservaCliente.aspx");
        }

        protected void lnkReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reserva.aspx");
        }

        protected void lnkCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastroCliente.aspx");
        }

        protected void lnkSair_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["idcliente"] != null)
            {
                HttpCookie idcliente = new HttpCookie("idcliente");
                idcliente.Expires = DateTime.Now;
                Response.Cookies.Add(idcliente);
            }
            Response.Redirect("index.aspx");
        }
    }
}