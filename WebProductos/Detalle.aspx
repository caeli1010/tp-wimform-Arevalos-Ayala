<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebProductos.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Producto seleccionado</h1>

        <asp:Label Text="Nombre" ID="lblNombre" runat="server"></asp:Label>
        <asp:Label Text="Descripcion" ID="lblDescripcion" runat="server"></asp:Label>
        <asp:Label Text="Imagen" ID="lblImagen" runat="server"></asp:Label>
  <p>...</p>
  <p><a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a></p>
</div>
</asp:Content>
