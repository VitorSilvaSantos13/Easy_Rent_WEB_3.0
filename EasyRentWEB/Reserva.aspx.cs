using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;

namespace EasyRentWEB
{
    public partial class Reserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["valor"] = 0;
                int idcliente = Int32.Parse(Request.Cookies["idcliente"].Value);

                Classe.Cliente cliente = new Classe.Cliente();

                Session["Categoria"] = cliente.Buscar_Cliente(idcliente);
                Session["CPF"] = cliente.cpf;
                Session["CNPJ"] = cliente.cnpj;
                Session["Email"] = cliente.email;


                if (Session["Categoria"].ToString() == "PF")
                {
                    txtNomeCliente.Text = cliente.nome;
                    txtCpf.Text = cliente.cpf;
                    txtCNH.Text = cliente.cnh;
                }

                else if (Session["Categoria"].ToString() == "PJ")
                {
                    txtNomeCliente.Text = cliente.nome;
                    txtCNPJ.Text = cliente.cnpj;
                }
            }

            else
            {
                valor = Decimal.Parse(Session["valor"].ToString());
                Session["Pagina"] = Request.UrlReferrer.ToString();

            }

        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCadeira_Click(object sender, EventArgs e)
        {
            int quantidade = Int32.Parse(txtCadeira.Text);

            int preco = quantidade * 20 * Int32.Parse(lblTotalDias.Text);
            valor = valor + preco;
            Session["valor"] = valor;
            lblValorTotal2.Text = valor.ToString();

        }

        protected void txtConforto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtElevacao_TextChanged(object sender, EventArgs e)
        {

        }

        public decimal valor;
        public decimal TotaldeDias;
        public decimal TotaldeSemanas;

        protected void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        protected void rdbSedan_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        protected void rdbHatch_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        protected void rdbPremium_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        protected void rdbVan_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        protected void btnDias_Click(object sender, EventArgs e)
        {
            string DataInicial = txtDataRetirada.Text;
            string DataFinal = txtDataDevolucao.Text;


            TimeSpan date = Convert.ToDateTime(DataFinal) - Convert.ToDateTime(DataInicial);

            TotaldeDias = date.Days;

            TotaldeSemanas = decimal.Round((TotaldeDias / 7), 2);

            lblTotalDias.Text = TotaldeDias.ToString();

        }

        protected void txtDataDevolucao_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnConforto_Click(object sender, EventArgs e)
        {
            int quantidade = Int32.Parse(txtConforto.Text);

            int preco = quantidade * 20 * Int32.Parse(lblTotalDias.Text);
            valor = valor + preco;
            Session["valor"] = valor;
            lblValorTotal2.Text = valor.ToString();
        }

        protected void btnElevacao_Click(object sender, EventArgs e)
        {
            int quantidade = Int32.Parse(txtElevacao.Text);

            int preco = quantidade * 20 * Int32.Parse(lblTotalDias.Text);
            valor = valor + preco;
            Session["valor"] = valor;
            lblValorTotal2.Text = valor.ToString();
        }

        protected void btnContinuar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            decimal SUV = 100;
            if (rdbSUV.Checked == true)
            {
                valor = 0;
                decimal preco = SUV * Int32.Parse(lblTotalDias.Text);
                valor = valor + preco;
                Session["valor"] = valor;
                lblValorTotal2.Text = valor.ToString();
                categoria = "SUV";
            }

            decimal Sedan = 60;
            if (rdbSedan.Checked == true)
            {
                valor = 0;
                decimal preco = Sedan * Int32.Parse(lblTotalDias.Text);
                valor = valor + preco;
                Session["valor"] = valor;
                lblValorTotal2.Text = valor.ToString();

                categoria = "Sedan";
            }

            decimal Hatch = 40;
            if (rdbHatch.Checked == true)
            {
                valor = 0;
                decimal preco = Hatch * Int32.Parse(lblTotalDias.Text);
                valor = valor + preco;
                Session["valor"] = valor;
                lblValorTotal2.Text = valor.ToString();

                categoria = "Hatch";
            }

            decimal Premium = 150;
            if (rdbPremium.Checked == true)
            {
                valor = 0;
                decimal preco = Premium * Int32.Parse(lblTotalDias.Text);
                valor = valor + preco;
                Session["valor"] = valor;
                lblValorTotal2.Text = valor.ToString();

                categoria = "Premium";
            }

            decimal Van = 140;
            if (rdbVan.Checked == true)
            {
                valor = 0;
                decimal preco = Van * Int32.Parse(lblTotalDias.Text);
                valor = valor + preco;
                Session["valor"] = valor;
                lblValorTotal2.Text = valor.ToString();

                categoria = "Van";
            }
        }

        public string categoria;

        protected void btnReservar_Click1(object sender, EventArgs e)
        {
            int idcliente = Int32.Parse(Request.Cookies["idcliente"].Value);

            Classe.Reserva p = new Classe.Reserva();

            Classe.Cupom cupom = new Classe.Cupom();

            p.nome = txtNomeCliente.Text;
            p.cpf = txtCpf.Text;
            p.cnpj = txtCNPJ.Text;
            p.cnh = txtCNH.Text;
            p.celular = txtCelular.Text;
            p.kmDesejado = txtKmDesejado.Text;
            p.kmExtra = txtKmExtra.Text;
            p.valorTotal = lblValorTotal2.Text;
            p.dtHoraRetirada = DateTime.Parse(txtDataRetirada.Text);
            p.dtHoraDevol = DateTime.Parse(txtDataDevolucao.Text);
            p.quantidadeAssento = txtElevacao.Text;
            p.quantidadeBebe = txtConforto.Text;
            p.quantidadeCadeira = txtCadeira.Text;
            p.totalDias = lblTotalDias.Text;

            if (txtCadeira.Text.Length != 0)
            {
                p.cadeiraBebe = "Sim";
            }
            else
            {
                p.cadeiraBebe = "Não";
            }

            if (txtConforto.Text.Length != 0)
            {
                p.bebeConforto = "Sim";
            }
            else
            {
                p.bebeConforto = "Não";
            }

            if (txtElevacao.Text.Length != 0)
            {
                p.assentoElevado = "Sim";
            }
            else
            {
                p.assentoElevado = "Não";
            }

            if (rdbHatch.Checked == true)
            {
                p.categoria = "Hatch";
            }

            if (rdbPremium.Checked == true)
            {
                p.categoria = "Premimum";
            }

            if (rdbSedan.Checked == true)
            {
                p.categoria = "Sedan";
            }

            if (rdbSUV.Checked == true)
            {
                p.categoria = "SUV";
            }

            if (rdbVan.Checked == true)
            {
                p.categoria = "Van";
            }

            categoria = p.categoria;

            p.InserirReserva(idcliente);

            cupom.CodigoCupom = txtCupom.Text;

            cupom.Verificar();            

            cupom.Quantidade = cupom.Quantidade - 1;
            cupom.CodigoCupom = txtCupom.Text;

            cupom.cupom_usado();

            string remetente = Session["Email"].ToString();
            MailMessage mail = new MailMessage();
            MailAddress recepetor = new MailAddress("computerdigitalvision@gmail.com");
            mail.To.Add(Session["Email"].ToString());
            mail.From = recepetor;
            mail.Subject = "Reserva realizada com sucesso!";
            mail.Body = txtNomeCliente.Text + ", você acabou de efetuar uma reserva de locação. Agradecemos a sua confiança na Easy " +
                "Rent." + "<br/>" + "Abaixo segue um resumo da sua locação:" + "<br/>" + "<br/>" + "<br/>" + "Categoria: " + categoria 
                + "<br/>" + "Data e hora de retirada: " + txtDataRetirada.Text + "<br/>" + "Data e hora de retirada: " + txtDataDevolucao.Text + 
                "<br/>" + "Valor: R$" + lblValorTotal2.Text + "<br/>" + "<br/>" + "<br/>" + "Para mais informações acesse: www.easyrent.com.br" 
                + " entre com o seu login e senha e abra a opção 'Visualizar Reserva', ou entre em contato com a nossa empresa pelo telefone:"
                + "0800 751 1259";
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("computerdigitalvision@gmail.com", "");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(mail);

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Reserva realizada com sucesso!'); " +
                "window.location.href='paginaCliente.aspx';", true);
        }

        protected void lnkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("paginaCliente.aspx");            
        }

        protected void txtDataRetirada_TextChanged(object sender, EventArgs e)
        {

        }

        public int Quantidade;

        protected void btnCupom_Click(object sender, EventArgs e)
        {
            if (rdbHatch.Checked == true)
            {
                categoria = "Hatch";
            }

            if (rdbPremium.Checked == true)
            {
                categoria = "Premimum";
            }

            if (rdbSedan.Checked == true)
            {
                categoria = "Sedan";
            }

            if (rdbSUV.Checked == true)
            {
                categoria = "SUV";
            }

            if (rdbVan.Checked == true)
            {
                categoria = "Van";
            }

            Classe.Cupom cupom = new Classe.Cupom();

            cupom.CodigoCupom = txtCupom.Text;

            cupom.Verificar();

            Quantidade = cupom.Quantidade;

            if(cupom.Quantidade > 0 && cupom.Validade > DateTime.Now)
            {
                if (cupom.Categoria == "Todas" || cupom.Categoria == "Todos" || cupom.Categoria == "todas" || cupom.Categoria == "todos")
                {
                    if (decimal.Parse(lblValorTotal2.Text) >= cupom.ValorMinimo)
                    {
                        decimal desconto = valor * cupom.percentual;

                        lblValorTotal2.Text = (valor - desconto).ToString();
                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cupom inválido!'); ", true);
                    }
                }
                
                else if(cupom.Categoria == categoria)
                {
                    decimal desconto = valor * cupom.percentual;

                    lblValorTotal2.Text = (valor - desconto).ToString();
                }

                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cupom inválido!'); ", true);
                }
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cupom inválido/expirado!'); ", true);
            }
        }
    }
}