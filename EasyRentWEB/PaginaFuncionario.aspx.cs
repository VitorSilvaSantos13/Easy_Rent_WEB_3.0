using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class PaginaFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void lnkSair_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void lnkAddCupom_Click(object sender, EventArgs e)
        {
            Response.Redirect("adicionarCupom.aspx");
        }

        protected void lnkVisualizarReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("visualizarReserva.aspx");
        }

        protected void lnkVisualizarLocacao_Click(object sender, EventArgs e)
        {
            Response.Redirect("visualizarLocacao.aspx");
        }
    }
}