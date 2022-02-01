using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class visualizarReservaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idcliente = Int32.Parse(Request.Cookies["idcliente"].Value);

            Classe.Reserva reserva = new Classe.Reserva();

            GridView1.DataSource = reserva.Buscar_Reserva(idcliente);
            GridView1.DataBind();
                       
        }

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("paginaCliente.aspx");
        }
    }
}