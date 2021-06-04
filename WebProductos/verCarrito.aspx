<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="verCarrito.aspx.cs" Inherits="WebProductos.verCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <% for (int i = 0; i <= (int)Session["cantidad"]; i++)
        { %>
       <p> esto vale: <%  = Session["nom"+(int)i] %> </p>
    <% }%>
</asp:Content>
