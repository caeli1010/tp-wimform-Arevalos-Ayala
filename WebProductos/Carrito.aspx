<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebProductos.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table">
        <thead class=" table-dark">
            <tr>
                <th scope="col">Imagen</th>
                <th scope="col">Producto</th>
                <th scope="col">Id Item</th>
                <th scope="col">Precio</th>
                <th scope="col">Cantidad</th>
                <th scope="col">Acción</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>
                    <tr>
                        <td>
                            <img src='<%#Eval("producto.UrlImagen")%>' width="50px"  class="img-fluid img-thumbnail" />

                        </td>
                        <td><%#Eval("producto.Nombre")%></td>

                        <td><%#Eval("producto.Id")%> </td>

                        <td><%#Eval("subTotal")%></td>
                        <td><%#Eval("cantidad")%>
                            <asp:Button
                                Text="+"
                                CssClass="btn btn-outline-success"
                                ID="btnMas"
                                OnClick="btnMas_Click"
                                CommandArgument='<%#Eval("producto.Id")%>'
                                runat="server" />
                           
                            <asp:Button
                                Text="-"
                                CssClass="btn btn-outline-danger "
                                ID="btnMenos"
                                OnClick="btnMenos_Click"
                                CommandArgument='<%#Eval("producto.Id")%>'
                                runat="server" />
                          
                        </td>
                        <td>
                            <i class="bi bi-trash text-warning"></i>
                            <asp:Button Text='Eliminar'
                                CssClass="  btn btn-outline-warning"
                                ID="btnEliminar"
                                OnClick="btnEliminar_Click"
                                CommandArgument='<%#Eval("producto.Id")%>'
                                runat="server" />
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
