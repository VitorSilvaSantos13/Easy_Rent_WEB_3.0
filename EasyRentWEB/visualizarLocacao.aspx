<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizarLocacao.aspx.cs" Inherits="EasyRentWEB.visualizarLocacao" %>

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
        <div id="grid">
            
                <br />
                <br />
             <asp:GridView ID="GridView1" runat="server" CssClass="gridviewFuncionario"></asp:GridView>
                <br />
                <br />
            <asp:LinkButton ID="lnkVoltar" runat="server" OnClick="lnkVoltar_Click">Voltar</asp:LinkButton>
       </div>
    </form>
        </div>
</body>
</html>
