using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRentWEB
{
    public partial class atualizacaoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Session["Pagina"] = Request.UrlReferrer.ToString();
            }
            else
            {
                if (HttpContext.Current.Request.Cookies["idcliente"] != null)
                {
                    idcliente = Int32.Parse(Request.Cookies["idcliente"].Value);
                }
                
                Classe.Cliente cliente = new Classe.Cliente();

                Session["Categoria"] = cliente.Buscar_Cliente(idcliente);
                Session["CPF"] = cliente.cpf;
                Session["CNPJ"] = cliente.cnpj;

                txtBairro.Text = cliente.bairro;
                txtCelular.Text = cliente.celular;
                txtCep.Text = cliente.cep;
                txtCidade.Text = cliente.cidade;
                txtComplemento.Text = cliente.complemento;
                txtEmail.Text = cliente.email;
                txtLogradouro.Text = cliente.endereco;
                txtNome.Text = cliente.nome;
                txtNumero.Text = cliente.numero;
                txtRazaoSocial.Text = cliente.razao;
                txtTelefone.Text = cliente.telefone;
                txtUf.Text = cliente.uf;
                txtLogin2.Text = cliente.login;
                txtSenha2.Text = cliente.senha;
                txtDataNascimento.Text = cliente.dtaNasc.ToString();
                txtCpf.Text = cliente.cpf;
                txtRg.Text = cliente.rg;
                txtCnh.Text = cliente.cnh;
                txtCnpj.Text = cliente.cnpj;
                txtRazaoSocial.Text = cliente.razao;

                if (Session["Categoria"].ToString() == "PF")
                {
                    txtRazaoSocial.Enabled = false;
                    txtDataNascimento.Enabled = false;
                    txtCnh.Enabled = false;
                    txtCnpj.Enabled = false;
                    txtCpf.Enabled = false;
                    txtRg.Enabled = false;
                }

                else
                {
                    rdbF.Enabled = false;
                    rdbM.Enabled = false;
                    txtRazaoSocial.Enabled = false;
                    txtDataNascimento.Enabled = false;
                    txtCnh.Enabled = false;
                    txtCnpj.Enabled = false;
                    txtCpf.Enabled = false;
                    txtRg.Enabled = false;
                }

                if (cliente.genero == "F")
                {
                    rdbF.Checked = true;
                }

                else if (cliente.genero == "M")
                {
                    rdbM.Checked = true;
                }

                
            }

        }

        public int idcliente;

        protected void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text);

                ds.ReadXml(xml);

                txtLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtUf.Text = ds.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception ex)
            {
                
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {

         
            int idcliente = Int32.Parse(Request.Cookies["idcliente"].Value);

            Classe.Cliente cliente = new Classe.Cliente();
            cliente.categoria = Session["Categoria"].ToString();
            if(cliente.categoria == "PF")
            {
                cliente.cpf = Session["CPF"].ToString();
            }
            else if (cliente.categoria == "PJ")
            {
                cliente.cnpj = Session["CNPJ"].ToString();
            }
            
            cliente.bairro = txtBairro.Text;
            cliente.celular = txtCelular.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = txtCidade.Text;
            cliente.complemento = txtComplemento.Text;
            cliente.email = txtEmail.Text;
            cliente.endereco = txtLogradouro.Text;
            cliente.nome = txtNome.Text;
            cliente.numero = txtNumero.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.uf = txtUf.Text;
            cliente.senha = txtSenha2.Text;
            
            if (rdbF.Checked)
            {
                cliente.genero = "F";
            }

            else if (rdbM.Checked)
            {
                cliente.genero = "M";
            }

            cliente.Atualizar_Cliente(idcliente);
        }

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("paginaCliente.aspx");
        }
        
    }
}