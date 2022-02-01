<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaCliente.aspx.cs" Inherits="EasyRentWEB.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="easyrent.css" rel="stylesheet" type="text/css"/>
</head>
<body id="iniciocliente" onload="myFunction()">
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
        <div>
            <nav class="menu">
                <ul>
            <li class="menu_li"><asp:LinkButton ID="lnkAtualizar" runat="server" OnClick="lnkAtualizar_Click">Atualizar Cadastro</asp:LinkButton></li>
            
            <li class="menu_li"><asp:LinkButton ID="lnkBusca_Reserva" runat="server" OnClick="lnkBusca_Reserva_Click">Visualizar Reserva</asp:LinkButton></li>
            
            <li class="menu_li"><asp:LinkButton ID="lnkReserva" runat="server" OnClick="lnkReserva_Click">Nova Reserva</asp:LinkButton></li>

            <li class="menu_li"><asp:LinkButton ID="lnkSair" runat="server" OnClick="lnkSair_Click">Sair</asp:LinkButton></li>
        </ul>
                    </nav>
            <img src="Easy Rent.png" id="imagemInicio"/>
                </div>
    </form>
        </div>
</body>
</html>
