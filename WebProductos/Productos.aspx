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

                    <p><strong> Código :<% = item.Codigo %></strong>
                        <br />
                        <del class="disabled"> Antes: $ <% = item.Precio.ToString("N") %></del>
                        <br />
                        <strong> Precio : $ <% = (item.Precio * 85/100).ToString("N") %></strong>

                    </p>
                    <p><span class="badge badge-danger ">En 6 coutas : $ <% = (item.Precio/6).ToString("N") %></span></p>
                    <p>
                        <a  href="Detalle.aspx?id=<% = item.Id %>" class="btn btn-primary" role="button">Ver Detalle</a>
                        <p>
                        <asp:Label ID="lblCantidad" CssClass="bg-danger " runat="server" Text="Cantidad"></asp:Label>
                        <asp:TextBox ID="txtCantidad"  runat="server" TextMode="Number" MaxLength="3" BorderStyle="Outset" CssClass="form-control bg-danger"></asp:TextBox>
                        </p>
                            <a href="#" class="btn btn-default" role="button">Agregar al Carrito</a>
                    </p>
                </div>
            </div>
        </div>
        <%   } %>
    </div>
</asp:Content>