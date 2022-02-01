<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adicionarCupom.aspx.cs" Inherits="EasyRentWEB.adicionarCupom" %>

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
                <h2 id="textCadastro">
            Adicionar Cupom
                    </h2>
            <div class="container">
                <br />
                <br />
                <asp:Label ID="Label001" runat="server" Text="Código do cupom:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtCodigoCupom" runat="server" CssClass ="textbox"></asp:TextBox>
                
                <asp:Label ID="Label002" runat="server" Text="Validade:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtValidade" runat="server" CssClass ="textbox"></asp:TextBox>
                
                <asp:Label ID="Label03" runat="server" Text="Percentual:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtPercentual" runat="server" CssClass ="textbox"></asp:TextBox>
                
                <asp:Label ID="Label04" runat="server" Text="Quantidade:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtQuantidade" runat="server" CssClass ="textbox"></asp:TextBox>

                <asp:Label ID="Label5" runat="server" Text="Categoria:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtCategoria" runat="server" CssClass ="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Valor Mínimo:" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtValor" runat="server" CssClass ="textbox"></asp:TextBox>
                
                <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" OnClick="btnAdicionar_Click" />
                <br />
                <br />
                <asp:LinkButton ID="lnkVoltar" runat="server" OnClick="lnkVoltar_Click">Voltar</asp:LinkButton>
                <br />
                <br />
            </div>
             
            
        </div>
    </form>
        </div>
</body>
</html>
