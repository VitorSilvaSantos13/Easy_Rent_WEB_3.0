<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroCliente.aspx.cs" Inherits="EasyRentWEB.cadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script>
	function cpf(o,f){
    cpf_obj=o
    cpf_fun=f
    setTimeout("execcpf()",1)
}
function execcpf(){
    cpf_obj.value=cpf_fun(cpf_obj.value)
}
function mcpf(cpf){
    cpf=cpf.replace(/\D/g,"");             //Remove tudo o que não é dígito
    cpf=cpf.replace(/(\d{3})(\d)/,"$1.$2"); //Coloca parênteses em volta dos dois primeiros dígitos
    cpf=cpf.replace(/(\d{3})(\d)/,"$1.$2");    //Coloca hífen entre o quarto e o quinto dígitos
    cpf=cpf.replace(/(\d{3})(\d{1,2})$/,"$1-$2");    //Coloca hífen entre o quarto e o quinto dígitos
    return cpf;
}
	function cep(o,f){
    cep_obj=o
    cep_fun=f
    setTimeout("execcep()",1)
}
function execcep(){
    cep_obj.value=cep_fun(cep_obj.value)
}
function mcep(cep){
    cep=cep.replace(/\D/g,"");
	cep=cep.replace(/^(\d{5})(\d)/,"$1-$2");   //Coloca hífen entre o quarto e o quinto dígitos
    return cep;
}

function rg(o,f){
    rg_obj=o
    rg_fun=f
    setTimeout("execrg()",1)
}
function execrg(){
    rg_obj.value=rg_fun(rg_obj.value)
}
        
          function mrg(rg){
        rg=rg.replace(/\D/g,"");                                     
        rg=rg.replace(/(\d{2})(\d{3})(\d{3})(\d{1})$/,"$1.$2.$3-$4");;
              return rg
        }

                            function dtnasc(o,f){
    dtnasc_obj=o
    dtnasc_fun=f
    setTimeout("execdtnasc()",1)
}
function execdtnasc(){
    dtnasc_obj.value=dtnasc_fun(dtnasc_obj.value)
}
        
          function mdtnasc(dtnasc){
        dtnasc=dtnasc.replace(/\D/g,"");                                     
        dtnasc=dtnasc.replace(/(\d{2})(\d{2})(\d{4})$/,"$1/$2/$3");;
              return dtnasc
        }

        function tel(o,f){
    tel_obj=o
    tel_fun=f
    setTimeout("exectel()",1)
}
function exectel(){
    tel_obj.value=tel_fun(tel_obj.value)
}
        
          function mtel(tel){
        tel=tel.replace(/\D/g,"");                                     
              tel = tel.replace(/(\d{2})(\d{4})(\d{4})$/, "($1)$2-$3");;
              return tel
        }

        function cel(o,f){
    cel_obj=o
    cel_fun=f
    setTimeout("execcel()",1)
}
function execcel(){
    cel_obj.value=cel_fun(cel_obj.value)
}
        
          function mcel(cel){
        cel=cel.replace(/\D/g,"");                                     
              cel = cel.replace(/(\d{2})(\d{5})(\d{4})$/, "($1)$2-$3");;
              return cel
        }

	</script>

    <%--<script type="text/javascript">
        function redirecionar()
        {
            alert("Cadastro Realizado com sucesso!"); window.location = "index.aspx";
        }
            </script>--%>
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
                <h2 id="textCadastro">
            Cadastro
                    </h2>
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
                <asp:Button ID="btnCep" runat="server" Text="Buscar CEP" OnClick="btnCep_Click" />
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
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnReservar_Click"/>
                    <br />
                    <br />
                    <asp:LinkButton ID="lnkVoltar" runat="server" OnClick="lnkVoltar_Click">Voltar</asp:LinkButton>
                    <br />
                    <br />
                </div>
                </div>
        </div>
    </form>
        </div>
</body>    
</html>
