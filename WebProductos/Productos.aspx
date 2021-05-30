<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebProductos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:GridView ID="dvgDetalle" runat="server"></asp:GridView>--%>
    <% foreach (dominio.Articulo item in lista) {%>
        <h1> <% = item.Nombre  %></h1>
    <%   }%>
</asp:Content>
