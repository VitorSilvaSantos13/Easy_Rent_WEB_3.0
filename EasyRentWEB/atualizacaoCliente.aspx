<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="atualizacaoCliente.aspx.cs" Inherits="EasyRentWEB.atualizacaoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="easyrent.css" rel="stylesheet" type="text/css"/>
</head>
<body onload="myFunction()">
    <div class="sk-cube-grid" id="loader">
        <div class="sk-cube sk-cube1"></div>
        <div class="sk-cube sk-cube2"></div>
        <div class="sk-cube sk-cube3"></div>
        <div class="sk-cube sk-cube4"></div>
        <div class="sk-cube sk-cube5"></div>
        <div class="sk-cube sk-cube6"></div>
        <div class="sk-cube sk-cube7"></div>
        <div class="sk-cube sk-cube8"></div>
        <div class="sk-cube sk-cube9"></div>
    </div>
    <script>
        var myVar;
        function myFunction() {
            myVar = setTimeout(showPage, 1500);
        }
        function showPage() {
            document.getElementById("loader").style.display = "none";
            document.getElementById("myDiv").style.display = "block";
        }
    </script>
    <div style="display:none;" id="myDiv">
    <header>
        <img src="Easy Rent.png" id="header"/>
    </header>
    <form id="form1" runat="server">
        <div id="body">
            <br />
                <br />
                <asp:ScriptManager ID="src" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="upd" runat="server">
                <Triggers> <asp:AsyncPostBackTrigger ControlID="btnAtualizar" EventName="click" /></Triggers>
                <ContentTemplate>

                              
                                <h2 id="textCadastro">Atualização de Dados Pessoais</h2>
            <div class="container">
                
            <br />
                <br />
                <div class="col">
                        <p>
                            <asp:Label ID="Label56" runat="server" Text="Pessoa:" CssClass="textoCadastro"></asp:Label>
                            
                
                            <asp:RadioButton ID="rdbFisica" Text="Física" runat="server" GroupName="Pessoa" CssClass="textoCadastro"/>
                       
                <asp:RadioButton ID="rdbJuridica" Text="Jurídica" runat="server" GroupName="Pessoa" CssClass="textoCadastro"/>
            </p>
                <br />
            <p>
            <asp:Label ID="Label01" runat="server" Text="Nome:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo"></asp:TextBox>            
            <asp:Label ID="Label02" runat="server" Text="Data de Nascimento:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtDataNascimento" runat="server" CssClass ="textbox" onkeyup="dtnasc(this, mdtnasc)" MaxLength="10" placeholder="00/00/0000"></asp:TextBox>            
            <asp:Label ID="Label38" runat="server" Text="Sexo:" CssClass="textoCadastro"></asp:Label>
                <asp:RadioButton ID="rdbF" runat="server" text="Feminino" GroupName="sexo" CssClass="textoCadastro"/>
                <asp:RadioButton ID="rdbM" runat="server" text="Masculino" GroupName="sexo" CssClass="textoCadastro" />
            </p>
                <br />
            <p>
            <asp:Label ID="Label04" runat="server" Text="RG:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtRg" runat="server" CssClass ="textbox" onkeyup="rg(this, mrg)" MaxLength="12" placeholder="RG"></asp:TextBox>            
            <asp:Label ID="Label5" runat="server" Text="CPF:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCpf" runat="server" CssClass ="textbox" onkeyup="cpf(this, mcpf)" MaxLength="14" placeholder="CPF"></asp:TextBox>            
            <asp:Label ID="Label6" runat="server" Text="CNH:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCnh" runat="server" CssClass ="textbox" placeholder="CNH"></asp:TextBox>
            <asp:Label ID="Label18" runat="server" Text="CNPJ:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCnpj" runat="server" CssClass ="textbox" placeholder="CNPJ"></asp:TextBox>                
            <asp:Label ID="Label19" runat="server" Text="Razão Social:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtRazaoSocial" runat="server" CssClass ="textbox" placeholder="Razão Social"></asp:TextBox>
            </p>
            <br />
            <br />
            <h3 class="textInformacao">
                Infomações de contato:
            </h3>
                <br />
            <p>
            <asp:Label ID="Label7" runat="server" Text="Telefone:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" CssClass ="textbox" onkeyup="tel(this, mtel)" MaxLength="13" placeholder="(00)0000-0000"></asp:TextBox>            
            <asp:Label ID="Label8" runat="server" Text="Celular:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCelular" runat="server" CssClass ="textbox" onkeyup="cel(this, mcel)" MaxLength="14" placeholder="(00)00000-0000"></asp:TextBox>                
            <asp:Label ID="Label9" runat="server" Text="Email:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
                </p>
                <br />
                <br />
            <h3 class="textInformacao">
                Informações de endereço:
            </h3>
                <br />
            <p>
                <asp:Label ID="Label14" runat="server" Text="CEP:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCep" runat="server" MaxLength="9"  CssClass ="textbox" onkeyup="cep(this, mcep)" placeholder="00000-000"></asp:TextBox>
                <asp:Button ID="btnCep" runat="server" Text="Buscar CEP" OnClick="btnBuscarCEP_Click" />
            <asp:Label ID="Label10" runat="server" Text="Logradouro:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtLogradouro" runat="server" placeholder="Logradouro"></asp:TextBox>                             
                </p>
                <br />
            <p>
                <asp:Label ID="Label11" runat="server" Text="Bairro:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtBairro" runat="server" CssClass ="textbox" placeholder="Bairro"></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Text="Cidade:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCidade" runat="server" CssClass ="textbox" placeholder="Cidade"></asp:TextBox>
            <asp:Label ID="Label13" runat="server" Text="UF:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtUf" runat="server" CssClass ="textbox" placeholder="UF"></asp:TextBox>                                   
            <asp:Label ID="Label15" runat="server" Text="Número:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtNumero" runat="server" CssClass ="textbox" placeholder="Número"></asp:TextBox>                
            <asp:Label ID="Label16" runat="server" Text="Complemento:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtComplemento" runat="server" CssClass ="textbox" placeholder="Complemento"></asp:TextBox>
                </p>
           <br />
                    <p>
            
                </p>
                <br/>
                
                    <asp:Label ID="Label20" runat="server" Text="Login: " CssClass="textoCadastro"></asp:Label>
                    <asp:TextBox ID="txtLogin2" runat="server" CssClass="textbox2" placeholder="Login"></asp:TextBox>                
                <asp:Label ID="Label21" runat="server" Text="Senha: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtSenha2" runat="server" TextMode="Password" CssClass="textbox2" placeholder="Senha"></asp:TextBox>
                  
                <br />
                <br />
            <asp:Button ID="btnAtualizar" runat="server" Text="Cadastrar" OnClick="btnAtualizar_Click"/>
                    </ContentTemplate>

            </asp:UpdatePanel>
                <br />
                <asp:LinkButton ID="lnkVoltar" runat="server" OnClick="lnkVoltar_Click" CssClass="lnk">Voltar</asp:LinkButton>
            <br />
            </div>

                
    </form>
    <%--<%--<%--<%--<form id="form1" runat="server">
        <div id="body">
            <div class="container">
                <br />
                <br />

            <asp:ScriptManager ID="src" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="upd" runat="server">
                <Triggers> <asp:AsyncPostBackTrigger ControlID="btnAtualizar" EventName="click" /></Triggers>
                <ContentTemplate>

                              
                                <h2 id="textCadastro">Atualização de Dados Pessoais</h2>
            <p>
               <h3 class="textInformacao">Atualize suas infomações para que você possa continuar efetuando reservas sem problemas.</h3>
            </p>
                    <br />
            <p>
                <asp:Label ID="Label001" runat="server" Text="Nome:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label002" runat="server" Text="Telefone:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label39" runat="server" Text="Celular:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtCelular" runat="server" CssClass ="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:RadioButton ID="rdbM" runat="server" text="Masculino" CssClass="textoCadastro"/>
                <asp:RadioButton ID="rdbF" runat="server" text="Feminio" CssClass="textoCadastro"/>
            </p>
                    <br />
            <p>
                <asp:Label ID="Label004" runat="server" Text="CEP: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtCEP" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Button ID="btnBuscarCEP" runat="server" Text="Buscar CEP" OnClick="btnBuscarCEP_Click" />
                <asp:Label ID="Label5" runat="server" Text="Endereço :" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtEndereco" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="Número: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtNumero" runat="server" CssClass ="textbox"></asp:TextBox>
            
                <asp:Label ID="Label9" runat="server" Text="Complemento: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtComplemento" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label10" runat="server" Text="Cidade: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtCidade" runat="server" CssClass ="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Bairro" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtBairro" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Text="UF: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtUF" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Text="Razão Social: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtRazaoSocial" runat="server" CssClass ="textbox"></asp:TextBox>
                
            </p>
                    <br />
            <p>
                <asp:Label ID="Label13" runat="server" Text="Email: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Login: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtLogin2" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Label ID="Label14" runat="server" Text="Senha: " CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtSenha2" runat="server" CssClass ="textbox" TextMode="Password"></asp:TextBox>
            </p>
           <%-- <p>
                <asp:Button ID="btnSms" runat="server" Text="Desejo receber a confirmação também por SMS" />
            </p>--%>
                  <%--  <br />
            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click"  />

                </ContentTemplate>

            </asp:UpdatePanel>
                <br />
                <asp:LinkButton ID="lnkVoltar" runat="server" OnClick="lnkVoltar_Click" CssClass="lnk">Voltar</asp:LinkButton>
            <br />
                <br />
            </div>
        </div>
    </form>--%>
        </div>
</body>
</html>
