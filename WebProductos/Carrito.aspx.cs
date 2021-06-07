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

        protected void btnMas_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulo> seleccionado = (List<Articulo>)Session["articulos"];
            Articulo artPrecioUnitario = (Articulo)seleccionado.Find(x => x.Id.ToString() == argument);

            List<ItemCarrito> Pila = (List<ItemCarrito>)Session["listaArticulos"];
            ItemCarrito sumarcantidad = Pila.Find(x => x.producto.Id.ToString() == argument);

            Pila.Remove(sumarcantidad);

            sumarcantidad.cantidad += 1;
            sumarcantidad.producto.Precio = (decimal)(artPrecioUnitario.Precio * (int)sumarcantidad.cantidad);


            Pila.Add(sumarcantidad);

            Session["listaArticulos"] = Pila;
            repetidor.DataSource = null;
            repetidor.DataSource = (List<ItemCarrito>)Session["listaArticulos"];
            repetidor.DataBind();

        }

        protected void btnMenos_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<ItemCarrito> Pila = (List<ItemCarrito>)Session["listaArticulos"];
            ItemCarrito sumarcantidad = Pila.Find(x => x.producto.Id.ToString() == argument);
            sumarcantidad.cantidad -= 1;
            int auxiliar = (sumarcantidad.cantidad==0)? 1 : (int)sumarcantidad.cantidad;
            Pila.Remove(sumarcantidad);
            sumarcantidad.producto.Precio = sumarcantidad.producto.Precio * (int)auxiliar;

            Pila.Add(sumarcantidad);

            Session["listaArticulos"] = Pila;
            repetidor.DataSource = null;
            repetidor.DataSource = (List<ItemCarrito>)Session["listaArticulos"];
            repetidor.DataBind();
        }
    }
}