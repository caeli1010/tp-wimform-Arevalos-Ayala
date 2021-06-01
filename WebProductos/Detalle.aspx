<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebProductos.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

        <img src="<% = Session["img"] %>" class="img-responsive" alt="" />
        <h1><% = Session["nom"] %></h1>
  <%--<p><% =  Session["desc"] %></p>--%>
    <p>
        <label> Cantidad: </label> 
        <input id="cantidad" type="number" name="cantidad" max="4"/>
        <a  href="Productos" class="btn btn-primary" role="button">Volver</a>
        <a href="#" class="btn btn-default" role="button">Agregar al Carrito</a>
    </p>
</div>
</asp:Content>
