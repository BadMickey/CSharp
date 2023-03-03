<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="waAgenda.registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label><br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
            <asp:Label runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <asp:Label runat="server" Text="Senha"></asp:Label><br />
            <asp:TextBox ID="TxtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" /><br />
            <br />
        </div>
    </form>
</body>
</html>
