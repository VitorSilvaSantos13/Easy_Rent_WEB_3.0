using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;

namespace EasyRentWEB
{
    public partial class cadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            

            Classe.Cliente cliente = new Classe.Cliente();

            cliente.bairro = txtBairro.Text;
            cliente.celular = txtCelular.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = txtCidade.Text;
            cliente.cnh = txtCnh.Text;
            cliente.cnpj = txtCnpj.Text;
            cliente.complemento = txtComplemento.Text;
            cliente.cpf = txtCpf.Text;
            cliente.dtaNasc = DateTime.Parse(txtDataNascimento.Text);
            cliente.email = txtEmail.Text;
            cliente.endereco = txtLogradouro.Text;
            cliente.nome = txtNome.Text;
            cliente.numero = txtNumero.Text;
            cliente.razao = txtRazaoSocial.Text;
            cliente.rg = txtRg.Text;            
            cliente.telefone = txtTelefone.Text;
            cliente.uf = txtUf.Text;
            cliente.login = txtLogin2.Text;
            cliente.senha = txtSenha2.Text;


            if (rdbFisica.Checked)
            {
                cliente.categoria = "PF";
            }
            else if (rdbJuridica.Checked)
            {
                cliente.categoria = "PJ";
            }

            if (rdbF.Checked)
            {
                cliente.genero = "F";
            }

            else if (rdbM.Checked)
            {
                cliente.genero = "M";
            }
            cliente.cadastroCliente();

            string remetente = txtEmail.Text;
            MailMessage mail = new MailMessage();
            MailAddress recepetor = new MailAddress("computerdigitalvision@gmail.com");
            mail.To.Add(txtEmail.Text);
            mail.From = recepetor;
            mail.Subject = "Seja Bem Vindo a Easy Rent!";
            mail.Body = "Olá " + txtNome.Text + ", Bem vindo a Easy Rent!" + "<br/>" + "Comece agora mesmo a fazer locações de carros!";
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("computerdigitalvision@gmail.com", "");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(mail);

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cadastro realizado com sucesso!'); " +
                "window.location.href='index.aspx';", true);
            
        }

        protected void btnCep_Click(object sender, EventArgs e)
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

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}