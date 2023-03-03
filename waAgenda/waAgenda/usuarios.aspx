<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePrincipal.Master" AutoEventWireup="true" CodeBehind="usuarios.aspx.cs" Inherits="waAgenda.usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Lista de Usuários</h3>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="Id" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color: #FFF8DC;">
                <td>
                    <asp:Button runat="server" CommandName="Delete" Text="Excluir" ID="DeleteButton" />
                    <asp:Button runat="server" CommandName="Edit" Text="Editar" ID="EditButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /></td>
                <td>
                    <asp:Label Text='<%# Eval("nome") %>' runat="server" ID="nomeLabel" /></td>
                <td>
                    <asp:Label Text='<%# Eval("email") %>' runat="server" ID="emailLabel" /></td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color: #008A8C; color: #FFFFFF;">
                <td>
                    <asp:Button runat="server" CommandName="Update" Text="Atualizar" ID="UpdateButton" />
                    <asp:Button runat="server" CommandName="Cancel" Text="Cancelar" ID="CancelButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel1" /></td>
                <td>
                    <asp:TextBox Text='<%# Bind("nome") %>' runat="server" ID="nomeTextBox" /></td>
                <td>
                    <asp:TextBox Text='<%# Bind("email") %>' runat="server" ID="emailTextBox" /></td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button runat="server" CommandName="Insert" Text="Inserir" ID="InsertButton" />
                    <asp:Button runat="server" CommandName="Cancel" Text="Limpar" ID="CancelButton" />
                </td>
                <td>
                    <asp:TextBox Text='<%# Bind("Id") %>' runat="server" ID="IdTextBox" /></td>
                <td>
                    <asp:TextBox Text='<%# Bind("nome") %>' runat="server" ID="nomeTextBox" /></td>
                <td>
                    <asp:TextBox Text='<%# Bind("email") %>' runat="server" ID="emailTextBox" /></td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color: #DCDCDC; color: #000000;">
                <td>
                    <asp:Button runat="server" CommandName="Delete" Text="Excluir" ID="DeleteButton" />
                    <asp:Button runat="server" CommandName="Edit" Text="Editar" ID="EditButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /></td>
                <td>
                    <asp:Label Text='<%# Eval("nome") %>' runat="server" ID="nomeLabel" /></td>
                <td>
                    <asp:Label Text='<%# Eval("email") %>' runat="server" ID="emailLabel" /></td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table runat="server" id="itemPlaceholderContainer" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;" border="1">
                            <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                                <th runat="server"></th>
                                <th runat="server">Id</th>
                                <th runat="server">nome</th>
                                <th runat="server">email</th>
                            </tr>
                            <tr runat="server" id="itemPlaceholder"></tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                        <asp:DataPager runat="server" ID="DataPager1">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                <asp:NumericPagerField></asp:NumericPagerField>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
                <td>
                    <asp:Button runat="server" CommandName="Delete" Text="Excluir" ID="DeleteButton" />
                    <asp:Button runat="server" CommandName="Edit" Text="Editar" ID="EditButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /></td>
                <td>
                    <asp:Label Text='<%# Eval("nome") %>' runat="server" ID="nomeLabel" /></td>
                <td>
                    <asp:Label Text='<%# Eval("email") %>' runat="server" ID="emailLabel" /></td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [usuario] WHERE [Id] = @Id" InsertCommand="INSERT INTO [usuario] ([Id], [nome], [email]) VALUES (@Id, @nome, @email)" SelectCommand="SELECT * FROM [usuario]" UpdateCommand="UPDATE [usuario] SET [nome] = @nome, [email] = @email WHERE [Id] = @Id" InsertCommandType="Text" OnInserted="Inserted" OnUpdated="Updated">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="String"></asp:Parameter>
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id" Type="String"></asp:Parameter>
            <asp:Parameter Name="nome" Type="String"></asp:Parameter>
            <asp:Parameter Name="email" Type="String"></asp:Parameter>
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nome" Type="String"></asp:Parameter>
            <asp:Parameter Name="email" Type="String"></asp:Parameter>
            <asp:Parameter Name="Id" Type="String"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
