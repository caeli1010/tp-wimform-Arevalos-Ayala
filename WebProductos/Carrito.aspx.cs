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
                        itemseleccionado.cantidad =1;
                        itemseleccionado.subTotal = itemseleccionado.producto.Precio;

                        Pila.Add(itemseleccionado);
                    }
                }
                Session["cuantos"] = (Pila.Count > 0) ? (int)Pila.Count() : 0;

                //Repeater
                repetidor.DataSource = Pila;
                repetidor.DataBind();
            }
            Session["cuantos"] = (Pila.Count > 0) ? (int)Pila.Count() : 0;
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

        protected void btnMas_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulo> seleccionado = (List<Articulo>)Session["articulos"];
            Articulo artPrecioUnitario = (Articulo)seleccionado.Find(x => x.Id.ToString() == argument);

            List<ItemCarrito> Pila = (List<ItemCarrito>)Session["listaArticulos"];
            ItemCarrito sumarcantidad = Pila.Find(x => x.producto.Id.ToString() == argument);
            Session["axuliar"] = (decimal)artPrecioUnitario.Precio;
            Pila.Remove(sumarcantidad);

            sumarcantidad.cantidad += 1;
            sumarcantidad.subTotal = (decimal)((decimal)Session["axuliar"] * (int)sumarcantidad.cantidad);


            Pila.Add(sumarcantidad);
            Session["cuantos"] = (Pila.Count > 0) ? (int)Pila.Count() : 0;
            Session["listaArticulos"] = Pila;
            repetidor.DataSource = null;
            repetidor.DataSource = (List<ItemCarrito>)Session["listaArticulos"];
            repetidor.DataBind();

        }

        protected void btnMenos_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulo> seleccionado = (List<Articulo>)Session["articulos"];
            Articulo artPrecioUnitario = (Articulo)seleccionado.Find(x => x.Id.ToString() == argument);

            List<ItemCarrito> Pila = (List<ItemCarrito>)Session["listaArticulos"];
            ItemCarrito restarCantidad = Pila.Find(x => x.producto.Id.ToString() == argument);
            Session["axuliar"] = (decimal)artPrecioUnitario.Precio;
            Pila.Remove(restarCantidad);

            restarCantidad.cantidad -= 1;
            restarCantidad.cantidad = (restarCantidad.cantidad <=0 )?1:(int)restarCantidad.cantidad;
            restarCantidad.subTotal = (decimal)((decimal)Session["axuliar"] * (int)restarCantidad.cantidad);

            Pila.Add(restarCantidad);
            Session["cuantos"] = (Pila.Count > 0) ? (int)Pila.Count() : 0;
            Session["listaArticulos"] = Pila;
            repetidor.DataSource = null;
            repetidor.DataSource = (List<ItemCarrito>)Session["listaArticulos"];
            repetidor.DataBind();
        }
    }
}