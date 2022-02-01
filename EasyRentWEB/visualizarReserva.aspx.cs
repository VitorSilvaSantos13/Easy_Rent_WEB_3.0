using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class visualizarReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Classe.Reserva reserva = new Classe.Reserva();

            GridView1.DataSource = reserva.visualizar_reserva_funcionario();
            GridView1.DataBind();
        }

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaFuncionario.aspx");
        }
    }
}