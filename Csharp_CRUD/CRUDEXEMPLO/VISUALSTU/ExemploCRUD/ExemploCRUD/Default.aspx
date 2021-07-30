<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploCRUD.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


    
        <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar Fabricante" Width="200px" />
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar Fabricante" Width="200px" />
        <asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar Fabricante" Width="200px" />
        <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir Fabricante" Width="200px" />
        <asp:Button ID="btnGoogle" runat="server" OnClick="btnGoogle_Click" Text="Google" Width="100px" />


    
    </div>
    </form>
</body>
</html>
