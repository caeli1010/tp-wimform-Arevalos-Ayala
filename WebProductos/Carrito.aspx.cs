using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
using Microsoft.Ajax.Utilities;

namespace WebProductos
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ItemCarrito> Pila;
        protected void Page_Load(object sender, EventArgs e)
        {
        Pila = (List<ItemCarrito>)Session["listaArticulos"];

            if (Pila == null)
                Pila = new List<ItemCarrito>();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {

                    if (Pila.Find(x => x.producto.Id.ToString() == Request.QueryString["id"]) == null)
                    {

                        List<Articulo> seleccionado = (List<Articulo>)Session["articulos"];
                        Articulo artSel = (Articulo)seleccionado.Find(x => x.Id.ToString() == Request.QueryString["id"]);
                        ItemCarrito itemseleccionado   = new ItemCarrito();
                        itemseleccionado.producto = (Articulo)artSel;
                        itemseleccionado.cantidad = 1;
                        Pila.Add(itemseleccionado);
                    }
                }

                //Repeater
                repetidor.DataSource = Pila;
                repetidor.DataBind();
            }

            Session.Add("listaArticulos", Pila);
           
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<ItemCarrito> Pila = (List<ItemCarrito>)Session["listaArticulos"];
            ItemCarrito eliminado = Pila.Find(x => x.producto.Id.ToString() == argument);
            Pila.Remove(eliminado);
            Session["listaArticulos"] = Pila;
            repetidor.DataSource = null;
            repetidor.DataSource = (List<ItemCarrito>)Session["listaArticulos"];
            repetidor.DataBind();
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            //Session["precio"] = ((TextBox)sender).ID;

            //var argument = ((TextBox)sender).ID.ToString();
            //List<ItemCarrito> Pila = (List<ItemCarrito>)Session["listaArticulos"];
            //ItemCarrito seleccionado = Pila.Find(x => x.producto.Id.ToString() == argument);
            //Pila.Remove(seleccionado);

            //ItemCarrito subtotal = new ItemCarrito();

            //Session["precio"] = (decimal)(seleccionado.producto.Precio * int.Parse(((TextBox)sender).Text));
            //Session["precio"] = (decimal)(seleccionado.producto.Precio * 10);
            //subtotal.producto.Precio = (decimal)Session["precio"];
            //Pila.Add(subtotal);
            //Session["listaArticulos"] = Pila;
            //repetidor.DataSource = null;
            //repetidor.DataSource = (List<ItemCarrito>)Session["listaArticulos"];
            //repetidor.DataBind();
        }
    }
}