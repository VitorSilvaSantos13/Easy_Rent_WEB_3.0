<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EasyRentWEB.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="easyrent.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Istok+Web" rel="stylesheet"/>
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div id="bodyIndex">
            <%--<div class="index">--%>
                <br />
            <br />
                <p id="texto1">
                Seja bem vindo a página de Reservas da Easy Rent
            </p>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
            
    
            <asp:TextBox ID="txtLogin" runat="server" CssClass="textbox3" placeholder="Login"></asp:TextBox>

            
            <br />
            <br />
            

            <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
    
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="textbox3" placeholder="Senha"></asp:TextBox>
            <br />
            <br />
                  <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" AutoPostBack="false"/>
            <br />
                
                <br />
            <p id="Label3">
                Ainda não tem cadastro? <asp:LinkButton id="cadastro" runat="server" OnClick="cadastro_Click">Cadastre-se</asp:LinkButton>
            </p>
                <br />
            <p id="Label4">
                <asp:LinkButton id="inicio" runat="server" OnClick="inicio_Click">Voltar</asp:LinkButton>  para a página inicial.
            </p>
            <%--</div>--%>
        </div>
            
                



    </form>
        </div>
</body>
</html>
