<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebProductos.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>producto</td>
       
            <td>Cantidad</td>
       
            <td>Precio</td>
        </tr>
    <% foreach (dominio.Articulo item in Pila)
        { %>
        <tr>
            <td><% = item.Nombre %></td>
      
            <td> <% = Session["cant"] %></td>
      
            <td> <% =item.Precio %></td>
            <td>  <asp:TextBox ID="txtCantidad" runat="server" MaxLength="3" ></asp:TextBox> 
                <%--<input type="number" value="<% = Session['cant'] %>" />--%>
            </td>      
        </tr>
     
    <% }%>
          </table>
</asp:Content>
