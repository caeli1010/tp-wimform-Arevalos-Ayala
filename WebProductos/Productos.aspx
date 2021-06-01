<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebProductos.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:GridView ID="dvgDetalle" runat="server"></asp:GridView>--%>

    <div class="row">
        <% foreach (dominio.Articulo item in lista)
            {%>
        <div class=" col-md-4">
            <div class="thumbnail ">
                <img class="img-responsive"
                    src="<% = item.UrlImagen %>"
                    alt=" <% = item.Nombre %>" />
                <div class="caption">
                    <h1><% = item.Nombre  %></h1>

                    <p><strong> Código :<% = item.Codigo %></strong></p>
                    <p> Precio : $ <% = item.Precio%></p>
                    <p> En 6 coutas : $ <% = item.Precio/6 %></p>
                    <p>
                        <a target="_blank" href="Detalle.aspx?id=<% = item.Id %>" class="btn btn-primary" role="button">Ver Detalle</a>
                        <a href="#" class="btn btn-default" role="button">Agregar al Carrito</a>
                    </p>
                </div>
            </div>
        </div>
        <%   } %>
    </div>
</asp:Content>
