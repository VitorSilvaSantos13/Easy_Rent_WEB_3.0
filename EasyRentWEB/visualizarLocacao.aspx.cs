using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class visualizarLocacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Classe.Locacao locacao = new Classe.Locacao();

            GridView1.DataSource = locacao.Visualizar();
            GridView1.DataBind();
        }

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaFuncionario.aspx");
        }
    }
}