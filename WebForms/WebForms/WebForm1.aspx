﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox runat="server" ID="txtMensagem" OnTextChanged="txtMensagem_TextChanged"></asp:TextBox>
        <asp:Button runat="server" Text="Mostrar Mensagem" ID="btnMostrarMensagem" OnClick="btnMostrarMensagem_Click"></asp:Button>
    </form>
</body>
</html>
