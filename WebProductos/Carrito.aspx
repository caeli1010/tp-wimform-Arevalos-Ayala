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
            <td><img src='<%#Eval("producto.UrlImagen")%>' width="50px" class="img-thumbnail" /></td>
            <td><%#Eval("producto.Nombre")%></td>
      
            <td> <%#Eval("producto.Id")%> </td>
      
            <td><%#Eval("producto.Precio")%></td>
            <td>  
                <asp:TextBox 
                    ID='txtCantidad' CssClass="col-md-2"
                    TextMode="Number" 
                    MaxLength="3" 
                    AutoPostBack="true"
                    BorderStyle="Outset"
                    OnTextChanged="txtCantidad_TextChanged"
                    Text='<%#Eval("cantidad")%>'  
                    
                    runat="server">
                </asp:TextBox> 
            </td>   
            <td>
                <i class="bi bi-trash text-warning">
                    </i>
                <asp:Button Text='Eliminar' CssClass="  btn btn-outline-warning" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("producto.Id")%>'  runat="server" /> 
                    </td>
        
        </tr>
     </ItemTemplate>
        </asp:Repeater>
          </tbody>
</table>
<asp:Label Text='dasd' ID="lblPrecio" runat="server" />
</asp:Content>