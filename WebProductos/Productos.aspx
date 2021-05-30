<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebProductos.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:GridView ID="dvgDetalle" runat="server"></asp:GridView>--%>
    <div class="row">
        <% foreach (dominio.Articulo item in lista)
            {%>
        <div class="col-sm-6 col-md-4">
            <div class="thumbnail">
                <img class="img-responsive" height="150" src="<% = item.UrlImagen %>" alt=" <% = item.Nombre %>">
                <div class="caption">
                    <h1><% = item.Nombre  %></h1>

                    <p><% = item.Descripcion %></p>
                    <p><a href="#" class="btn btn-primary" role="button">Button</a> 
                        <a href="#" class="btn btn-default" role="button">Button</a></p>
                </div>
            </div>
        </div>
        <%   }%>
    </div>
</asp:Content>
