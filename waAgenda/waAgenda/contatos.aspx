<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePrincipal.Master" AutoEventWireup="true" CodeBehind="contatos.aspx.cs" Inherits="waAgenda.contatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Novo Contato" Font-Bold="true" Font-Size="Large" Font-Names="Verdana"></asp:Label><br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label><br />
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="E-mail"></asp:Label><br />
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label><br />
    <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox><asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" /><br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Lista de Contatos" Font-Bold="true" Font-Size="Large" Font-Names="Verdana"></asp:Label><br />
    <br />
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" ShowEditButton="True"></asp:CommandField>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" InsertVisible="False" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome"></asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email"></asp:BoundField>
            <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone"></asp:BoundField>
        </Columns>

        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></FooterStyle>

        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" BackColor="#FFCC66" ForeColor="#333333"></PagerStyle>

        <RowStyle BackColor="#FFFBD6" ForeColor="#333333"></RowStyle>

        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#FDF5AC"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#4D0000"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#FCF6C0"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#820000"></SortedDescendingHeaderStyle>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' DeleteCommand="DELETE FROM [Contato] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Contato] ([nome], [email], [Telefone]) VALUES (@nome, @email, @Telefone)" SelectCommand="SELECT * FROM [Contato]" UpdateCommand="UPDATE [Contato] SET [nome] = @nome, [email] = @email, [Telefone] = @Telefone WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32"></asp:Parameter>
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="nome" Type="String"></asp:Parameter>
            <asp:Parameter Name="email" Type="String"></asp:Parameter>
            <asp:Parameter Name="Telefone" Type="String"></asp:Parameter>
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nome" Type="String"></asp:Parameter>
            <asp:Parameter Name="email" Type="String"></asp:Parameter>
            <asp:Parameter Name="Telefone" Type="String"></asp:Parameter>
            <asp:Parameter Name="Id" Type="Int32"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
