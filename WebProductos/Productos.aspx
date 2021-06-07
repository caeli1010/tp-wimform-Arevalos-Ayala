<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebProductos.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr class="py-4"/>
   <h4 class="justify-content-center">Categorias </h4>
  <ul class="nav justify-content-center">
  <li class="nav-item">
    <a class="nav-link btn btn-outline-success" href="#">Electrodomesticos</a>
  </li>
  <li class="nav-item">
    <a class="nav-link btn btn-outline-success" href="#">Telefonos</a>
  </li>
  <li class="nav-item">
    <a class="nav-link btn btn-outline-success" href="#">Impresoras</a>
  </li>
  <li class="nav-item">
    <a class="nav-link btn btn-outline-success" href="#" >Otros</a>
  </li>
</ul>
    <hr class="py-4"/>
    <div class="container-fluid">
    <div class="row pt-4 mx-n2">
        <% foreach (dominio.Articulo item in lista)
            {%>

        <div class=" col-lg-3 col-md-4 col-sm-6 px-2 mb-4"> 
        <div class="card "> 
            <img class=" img-fluid  img-thumbnail"  width="300px" src="<% = item.UrlImagen %>" alt="<% = item.Nombre %>">
            <div class="card-body">
                <h5 class="card-title"><% = item.Nombre  %></h5>
                <p class="card-text">
                    <strong>Código :<% = item.Codigo %></strong>
                </p>
                <p class="card-text">
                    <del class="disabled">Antes: $ <% = item.Precio.ToString("N") %></del>
               
                    <strong>Precio : $ <% = (item.Precio * 85/100).ToString("N") %></strong>
                </p>
                <p class="card-text ">
                <span class="badge badge-danger ">En 6 coutas : $ <% = (item.Precio/6).ToString("N") %></span>

                </p>
                <p class="card-text">

                <a href="Detalle.aspx?id=<% = item.Id %>" class="btn btn-primary" role="button">Ver Detalle</a>
                </p>

                  <a href="Carrito.aspx?id=<% = item.Id %>&precio=<%=item.Precio %>" class="btn btn-outline-success" role="button">Agregar al Carrito</a>
            </div>
        </div>
        </div>

        <%   } %>
    </div>
    </div>
</asp:Content>
