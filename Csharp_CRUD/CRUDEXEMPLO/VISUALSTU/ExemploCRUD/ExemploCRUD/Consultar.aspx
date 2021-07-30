<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="ExemploCRUD.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblBusca" runat="server" Text="Buscar"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFabricante" runat="server" Text="Fabricante:"></asp:Label>
        <asp:TextBox ID="txtBusca" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="[lblStatus]"></asp:Label>
        <br />
        <br />
    <div>
    
        <asp:GridView ID="gvResultado" runat="server" Height="176px" Width="358px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
