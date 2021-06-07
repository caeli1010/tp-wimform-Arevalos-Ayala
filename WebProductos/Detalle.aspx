<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebProductos.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <hr class="py-3"/>
 
   <h5 class="justify-content-center display-5">Categorias </h5>
  <ul class="nav justify-content-center">
  <% foreach (dominio.Categoria item in categoria)
      {%>

    <li class="nav-item">
    <a class="nav-link btn btn-outline-success" href="#"><% = item.Descripcion %></a>
  </li>

      <%} %>
</ul>
    <hr class="py-1"/>
    <div class=" row">
        <img src="<% = Session["imagen"] %>" class="img-fluid rounded float-right altura-img" alt="" />
    <div class="card-body">

        <h2>
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
        </h2>
        <p>
            <asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label>
        </p>
        <p>

            <% = Session["precio"] %>

        </p>
        <p>


            <a href="Productos" class="btn btn-outline-primary" role="button">Volver</a>
            <a href="Carrito.aspx?id=<% = Session["id"] %>&precio=<%= Session["precio"] %>"
                class="btn btn-outline-success" role="button">Agregar al Carrito</a>

        </p>
    </div>
    </div>
</asp:Content>
