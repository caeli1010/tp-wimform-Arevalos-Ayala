<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebProductos.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>producto</td>
        </tr>
        <tr>
            <td>Cantidad</td>
        </tr>
        <tr>
            <td>Precio</td>
        </tr>
    <% foreach (dominio.ItemCarrito item in Pila)
        { %>
        <tr>
            <td> <% =item.producto.Nombre %></td>
        </tr>
         <tr>
            <td> <% =item.cantidad %></td>
        </tr>
         <tr>
            <td> <% =item.subTotal %></td>
        </tr>
     
    <% }%>
          </table>
</asp:Content>
