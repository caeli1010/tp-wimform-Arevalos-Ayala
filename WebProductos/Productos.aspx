<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebProductos.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:GridView ID="dvgDetalle" runat="server"></asp:GridView>--%>
    <div class="container-fluid">
    <div class="row pt-4 mx-n2">
        <% foreach (dominio.Articulo item in lista)
            {%>

        <div class=" col-lg-3 col-md-4 col-sm-6 px-2 mb-4"> 
        <div class="card "> 
            <img class="card-img-top img-thumbnail" src="<% = item.UrlImagen %>" alt="<% = item.Nombre %>">
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
  
                <asp:Label ID="lblCantidad" CssClass="text-secondary" runat="server" Text="Cantidad"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCantidad" CssClass="form-control " runat="server" TextMode="Number" MaxLength="3" BorderStyle="Outset" Text="1"></asp:TextBox>
                </div>
                  <a href="#" class="btn btn-default" role="button">Agregar al Carrito</a>
            </div>
        </div>
        </div>

        <%   } %>
    </div>
    </div>
</asp:Content>
