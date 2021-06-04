<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="verCarrito.aspx.cs" Inherits="WebProductos.verCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <% for (int i = 1; i <= (int)Session["contador"]; i++)
        { %>
       <p> esto vale: <%  = Session["nom"+(int)i] %> </p>
    <% }%>
</asp:Content>
