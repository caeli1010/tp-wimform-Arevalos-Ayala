<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="verCarrito.aspx.cs" Inherits="WebProductos.verCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <tr>    
        <asp:Button ID="btnTotal" runat="server" Text="Total" />
        <td> <asp:Button ID="btnEnvioDomicilio" runat="server" Text="Envio a domicilio" /></td>
        <td>Total a pagar</td>
    </tr>
    <tr>
        <% foreach (dominio.ItemCarrito item in productos){ %>
        <td><% =item.subTotal %> </td>
        <% } %>
        <%--<td><asp:Label ID="lblCosto" runat="server" Text="$ 350"></asp:Label></td>
        <td><%  %></td>--%>
        </tr>
</asp:Content>
