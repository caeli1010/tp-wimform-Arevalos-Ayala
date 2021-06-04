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
            //Session["desc"] = seleccionado.Descripcion;
            //Session["nom"] = seleccionado.Nombre;
            //Session["img"] = seleccionado.UrlImagen;
            int cont = 0;
            if (cont == 0) {
             (Articulo)Session["Articulo"+cont] = seleccionado;
                cont++;
             (int)Session["cantidad"] = cont;
            }
            else
            {
                Session["Articulo" + cont] = seleccionado;
                cont++;
                Session["cantidad"] = cont;
            }

        }
    }
}