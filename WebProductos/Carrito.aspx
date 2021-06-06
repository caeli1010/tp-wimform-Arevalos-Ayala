<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebProductos.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-dark">
         <thead>
        <tr>
            <th scope="col">producto</th>
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
            <td><%#Eval("producto.Nombre")%></td>
      
            <td> <%#Eval("producto.Id")%> </td>
      
            <td><%#Eval("producto.Precio")%></td>
            <td>  
                <asp:TextBox 
                    ID='txtCantidad' 
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
                <i class=" fa fa-trash "></i>
                <asp:Button Text="Borrar" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("producto.Id")%>'  runat="server" /> </td>
        </tr>
     </ItemTemplate>
        </asp:Repeater>
          </tbody>
</table>
<asp:Label Text='dasd' ID="lblPrecio" runat="server" />
</asp:Content>