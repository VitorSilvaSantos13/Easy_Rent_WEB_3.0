using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class adicionarCupom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Classe.Cupom cupom = new Classe.Cupom();

            cupom.CodigoCupom = txtCodigoCupom.Text;
            cupom.Validade = DateTime.Parse(txtValidade.Text);
            cupom.percentual = decimal.Parse(txtPercentual.Text);
            cupom.Quantidade = Int32.Parse(txtQuantidade.Text);
            cupom.Categoria = txtCategoria.Text;
            cupom.ValorMinimo = decimal.Parse(txtValor.Text);

            cupom.Adicionar();

            txtCategoria.Text = "";
            txtCodigoCupom.Text = "";
            txtPercentual.Text = "";
            txtQuantidade.Text = "";
            txtValidade.Text = "";
            txtValor.Text = "";

        }

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaFuncionario.aspx");
        }
    }
}