<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reserva.aspx.cs" Inherits="EasyRentWEB.Reserva" %>

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
	</script>
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
            <div class="container">
                <br />
                <br />
            <h2 id="textCadastro">Bem vindo a sua área de reservas</h2>
            <br />
            <br />
              <asp:Label ID="Label8" runat="server" Text="Nome do Cliente:" CssClass="textoCadastro"></asp:Label>
              
              <asp:TextBox ID="txtNomeCliente" runat="server"></asp:TextBox>
           
             <asp:Label ID="Label9" runat="server" Text="CPF:" CssClass="textoCadastro"></asp:Label>
              
              <asp:TextBox ID="txtCpf" runat="server" CssClass ="textbox"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="CNPJ:" CssClass="textoCadastro"></asp:Label>
            
            <asp:TextBox ID="txtCNPJ" runat="server" CssClass ="textbox"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="CNH:" CssClass="textoCadastro"></asp:Label>
            
            <asp:TextBox ID="txtCNH" runat="server" CssClass ="textbox"></asp:TextBox>
            <asp:Label ID="Label12" runat="server" Text="Celular:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtCelular" runat="server" CssClass ="textbox"></asp:TextBox>
            <br />
                <br />
            <asp:Label ID="Label0002" runat="server" Text="Data e hora da retirada:" CssClass="textoCadastro"></asp:Label>
            
            <asp:TextBox ID="txtDataRetirada" runat="server" CssClass ="textbox" onkeyup="dtnasc(this, mdtnasc)" MaxLength="10" Placeholder="00/00/0000"></asp:TextBox>
             <asp:Label ID="Label5" runat="server" Text="Data e hora da devolução:" CssClass="textoCadastro"></asp:Label>
            
            <asp:TextBox ID="txtDataDevolucao" runat="server" CssClass ="textbox"></asp:TextBox>
            
            
            <asp:Button ID="btnDias" runat="server" Text="Calcular " OnClick="btnDias_Click" />
            <asp:Label ID="Label402" runat="server" Text="Total de dias:" CssClass="textoCadastro"></asp:Label>
            
            <asp:Label ID="lblTotalDias" runat="server" Text= "0" CssClass="textoCadastro"></asp:Label>

            <br />
            <br />

            <asp:Label ID="Label7" runat="server" Text="Categoria pretendida:" CssClass="textoCadastro"></asp:Label>

            <asp:RadioButton ID="rdbSUV" runat="server" Text=" SUV" OnCheckedChanged="rdbCategoria_CheckedChanged" CssClass="textoCadastro" GroupName="Categoria"/>
            <asp:RadioButton ID="rdbSedan" runat="server" Text=" Sedan" OnCheckedChanged="rdbSedan_CheckedChanged" CssClass="textoCadastro" GroupName="Categoria"/>
            <asp:RadioButton ID="rdbHatch" runat="server" Text=" Hatch" OnCheckedChanged="rdbHatch_CheckedChanged" CssClass="textoCadastro" GroupName="Categoria"/>
            <asp:RadioButton ID="rdbPremium" runat="server" Text=" Premium" OnCheckedChanged="rdbPremium_CheckedChanged" CssClass="textoCadastro" GroupName="Categoria"/>
            <asp:RadioButton ID="rdbVan" runat="server" Text=" Van" OnCheckedChanged="rdbVan_CheckedChanged" CssClass="textoCadastro" GroupName="Categoria"/>
            <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" OnClick="btnAdicionar_Click" />
            <asp:Label ID="Label102" runat="server" Text="Km Desejado:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtKmDesejado" runat="server" CssClass ="textbox"></asp:TextBox>
            <asp:Label ID="Label103" runat="server" Text="Km Extra:" CssClass="textoCadastro"></asp:Label>
            <asp:TextBox ID="txtKmExtra" runat="server" Width="108px" CssClass ="textbox"></asp:TextBox>
            
            
             <br />
              
            <br />
                
                    <asp:Label ID="Label16" runat="server" Text="Deixe seu Aluguel ainda mais completo,escolha aqui  os opcionais ideais para você." CssClass="textoCadastro"></asp:Label>
             
         
            <br />
            <br />
         <asp:Label ID="lblCadeira" runat="server" Text="Cadeira de bebê:" CssClass="textoCadastro"></asp:Label>

         
            

            <asp:Label ID="lblQCadeira" runat="server" Text="quantidade:" CssClass="textoCadastro"></asp:Label>
            
            
            <asp:TextBox ID="txtCadeira" runat="server" Width="48px" CssClass ="textbox"></asp:TextBox>

            

            <asp:Label ID="lblDCadeira" runat="server" Text="R$ 20,00 por dia" CssClass="textoCadastro"></asp:Label>

            

            <asp:Button ID="btnCadeira" runat="server" Text="Adicionar" OnClick="btnCadeira_Click" />
            
            <br />

             <br />
             <asp:Label ID="lblConforto" runat="server" Text="Bebê conforto:" CssClass="textoCadastro"></asp:Label>

             
           
            
           
            <asp:Label ID="lblQConforto" runat="server" Text="quantidade:" CssClass="textoCadastro"></asp:Label>

            

            <asp:TextBox ID="txtConforto" runat="server" Width="48px" OnTextChanged="txtConforto_TextChanged" CssClass ="textbox"></asp:TextBox>

            

            <asp:Label ID="lblDConforto" runat="server" Text="R$ 20,00 por dia" CssClass="textoCadastro"></asp:Label>
              

            <asp:Button ID="btnConforto" runat="server" Text="Adicionar" OnClick="btnConforto_Click" />
           
            <br />
             <br />
             <asp:Label ID="lblElevacao" runat="server" Text="Assento de elevação:" CssClass="textoCadastro"></asp:Label>
             

           
            
           
            <asp:Label ID="lblQElevacao" runat="server" Text="quantidade:" CssClass="textoCadastro"></asp:Label>
          
            
          
            <asp:TextBox ID="txtElevacao" runat="server" Width="48px" OnTextChanged="txtElevacao_TextChanged" CssClass ="textbox"></asp:TextBox>

              
            <asp:Label ID="lblDElevacao" runat="server" Text="R$ 20,00 por dia" CssClass="textoCadastro"></asp:Label>

               

            <asp:Button ID="btnElevacao" runat="server" Text="Adicionar" OnClick="btnElevacao_Click" />
            <br />
            <br />
                <asp:Label ID="Label00001" runat="server" Text="Possui um cupom de desconto?" CssClass="textoCadastro"></asp:Label>
                <asp:TextBox ID="txtCupom" runat="server" CssClass ="textbox"></asp:TextBox>
                <asp:Button ID="btnCupom" runat="server" Text="Aplicar cupom" OnClick="btnCupom_Click" />
            <br />
            <br />
            <asp:Label ID="lblValorTotal" runat="server" Text="Valor total previsto:" CssClass="textoCadastro"></asp:Label>
            
           <%-- &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
            
            <asp:Label ID="lblValorTotal2" runat="server" Text="0" CssClass="textoCadastro"></asp:Label>
         
                  <br />
                  <br />
                   
                   
                    
            <asp:Button ID="btnReservar" runat="server" Text="Reservar" OnClick="btnReservar_Click1" />
                <br />
                <br />
                <asp:LinkButton ID="lnkVoltar" runat="server" OnClick="lnkVoltar_Click" CssClass="lnk">Voltar</asp:LinkButton>
                <br />
                <br />
         </div> 
        </div>
    </form>
        </div>
</body>
</html>
