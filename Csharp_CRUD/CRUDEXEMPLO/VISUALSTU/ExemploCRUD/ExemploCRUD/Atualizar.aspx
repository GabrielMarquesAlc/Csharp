<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Atualizar.aspx.cs" Inherits="ExemploCRUD.Atualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
            text-align: center;
        }
        .auto-style2 {
            width: 53px;
        }
        .auto-style4 {
            height: 36px;
            text-align: center;
        }
        .auto-style5 {
            height: 37px;
            width: 53px;
        }
        .auto-style6 {
            height: 37px;
            width: 25px;
        }
        .auto-style7 {
            width: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    







        <table style="width: 25%; height: 114px; margin-right: 39px;">
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="lblAtualizar" runat="server" style="text-align: center" Text="Atualizar Fabricante"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Cod:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtCod" runat="server" Width="217px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNome" runat="server" Width="215px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" style="margin-left: 0px" Text="Salvar" Width="66px" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="[lblStatus]"></asp:Label>
    







    </div>
    </form>
</body>
</html>
