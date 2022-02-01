using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class login : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Session["Pagina"] = Request.UrlReferrer.ToString();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            Classe.Login cliente = new Classe.Login();
            cliente.login = txtLogin.Text;
            cliente.senha = txtSenha.Text;

            cliente.Login1();

            //idcliente.Expires = DateTime.Now;
            if (cliente.categoria != null)
            {
                HttpCookie idcliente = new HttpCookie("idcliente");
                idcliente.Value = cliente.Login1().ToString();
                idcliente.Name = "idcliente";
                Response.Cookies.Add(idcliente);
                if (cliente.categoria == "PF" || cliente.categoria == "PJ")
                {
                    Response.Redirect("paginaCliente.aspx");
                }
                else if (cliente.categoria == "FU")
                {
                    Response.Redirect("PaginaFuncionario.aspx");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usuário/senha inválido!'); ", true);
            }
        }

        protected void cadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastroCliente.aspx");
        }

        protected void inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("HTML 6/index.html");
        }
    }
}