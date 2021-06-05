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
    <% foreach (dominio.Articulo item in Pila)
        { %>
      <%--  <tr>
            <td> <% = item.marca.Nombre %></td>
        </tr>--%>
         <tr>
            <td> <% =Session["cant"] %></td>
        </tr>
         <tr>
            <td> <% =item.Precio %></td>
        </tr>
     
    <% }%>
          </table>
</asp:Content>
