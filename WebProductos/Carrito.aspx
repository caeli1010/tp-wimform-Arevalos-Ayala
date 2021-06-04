<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebProductos.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <% for (int i = 0; i <= (int)Session["contador"]; i++)
        { %>
       esto vale: <%  = Session["nom" + (int)i]  %>
    <% }%>
</asp:Content>
