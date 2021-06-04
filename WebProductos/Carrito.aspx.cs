using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace WebProductos
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            decimal precio = decimal.Parse(Request.QueryString["precio"]);
            List<Articulo> listado = (List<Articulo>)Session["articulos"];
            Articulo seleccionado = listado.Find(X => X.Id == id);

            
              
            if ((int)Session["cantidad"]==0 ) {

                Session["desc"+(int)Session["cantidad"]] = seleccionado.Descripcion;
                Session["nom"+(int)Session["cantidad"]] = seleccionado.Nombre;
                Session["img"+(int)Session["cantidad"]] = seleccionado.UrlImagen;
               
                
                Session["cantidad"]= 1;
            }
            else
            {
                Session["desc" + (int)Session["cantidad"]] = seleccionado.Descripcion;
                Session["nom" + (int)Session["cantidad"]] = seleccionado.Nombre;
                Session["img" + (int)Session["cantidad"]] = seleccionado.UrlImagen;
               
                Session["cantidad"] = (int)Session["cantidad"]+1;
            }

        }
    }
}