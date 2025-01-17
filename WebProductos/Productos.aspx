﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebProductos.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr class="py-3" />

    <h5 class="justify-content-center display-5">Categorias </h5>
    <ul class="nav justify-content-center">

        <% foreach (dominio.Categoria item in categoria)
          {%>

            <li class="nav-item">
            <a class="nav-link btn btn-outline-success" href="Productos.aspx?id=<% =item.Id %>"><% = item.Descripcion %></a>
            </li>

          <%} %>
    </ul>
    <hr class="py-1" />
    <div class="container-fluid">
        <div class="row pt-4 mx-n2">
            <% if (id == 0)
                {%>
            <% foreach (dominio.Articulo item in lista)
                {%>

            <div class=" col-lg-3 col-md-4 col-sm-6 px-2 mb-4">
                <div class="card ">
                    <img class=" img-fluid  img-thumbnail " src="<% = item.UrlImagen %>" alt="<% = item.Nombre %>">
                    <div class="card-body">
                        <h5 class="card-title"><% = item.Nombre  %></h5>
                        <p class="card-text">
                            <strong>Código :<% = item.Codigo %></strong>
                        </p>
                        <p class="card-text">
                            <del class="disabled">Antes: $ <% = item.Precio.ToString("N") %></del>

                            <strong>Precio : $ <% = (item.Precio * 85 / 100).ToString("N") %></strong>
                        </p>
                        <p class="card-text ">
                            <span class="badge badge-danger ">En 6 coutas : $ <% = (item.Precio / 6).ToString("N") %></span>

                        </p>
                        <p class="card-text">

                            <a href="Detalle.aspx?id=<% = item.Id %>" class="btn btn-primary" role="button">Ver Detalle</a>
                        </p>

                        <a href="Carrito.aspx?id=<% = item.Id %>&precio=<%=item.Precio %>" class="btn btn-outline-success" role="button">Agregar al Carrito</a>
                    </div>
                </div>
            </div>

            <%   } %>
            <%} %>
            <%else
                { %>
                    
                     <% foreach (dominio.Articulo cat in lista)
                {%>
                    <%if (cat.categoria.Id == id)
                        {%>
            <div class=" col-lg-3 col-md-4 col-sm-6 px-2 mb-4">
                <div class="card ">
                    <img class=" img-fluid  img-thumbnail " src="<% = cat.UrlImagen %>" alt="<% = cat.Nombre %>">
                    <div class="card-body">
                        <h5 class="card-title"><% = cat.Nombre  %></h5>
                        <p class="card-text">
                            <strong>Código :<% = cat.Codigo %></strong>
                        </p>
                        <p class="card-text">
                            <del class="disabled">Antes: $ <% = cat.Precio.ToString("N") %></del>

                            <strong>Precio : $ <% = (cat.Precio * 85 / 100).ToString("N") %></strong>
                        </p>
                        <p class="card-text ">
                            <span class="badge badge-danger ">En 6 coutas : $ <% = (cat.Precio / 6).ToString("N") %></span>

                        </p>
                        <p class="card-text">

                            <a href="Detalle.aspx?id=<% = cat.Id %>" class="btn btn-primary" role="button">Ver Detalle</a>
                        </p>

                        <a href="Carrito.aspx?id=<% = cat.Id %>&precio=<%=cat.Precio %>" class="btn btn-outline-success" role="button">Agregar al Carrito</a>
                    </div>
                </div>
            </div>
            <%} %>
            <%   } %>

            <%} %>
        </div>
    </div>
</asp:Content>
