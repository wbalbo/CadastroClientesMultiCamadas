<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Web.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Cadastro de Clientes</h3>
            <br /><br />
            <label>Nome:</label><br />
            <asp:TextBox ID="txtNome" runat="server" MaxLength="50" Width="200px" /><br />
            <label>Idade:</label><br />
            <asp:TextBox ID="txtIdade" runat="server" MaxLength="2" Width="30px" />
            <br /><br />
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
        </div>
    </form>
</body>
</html>
