<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="ExemploCRUD.Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Cadastrar"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFabricante" runat="server" Text="Fabricante"></asp:Label>
        <asp:TextBox ID="txtFabricante" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="[lblStatus]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
    
    </div>
    </form>
</body>
</html>
