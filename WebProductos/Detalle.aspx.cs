using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace WebProductos
{
    public partial class Detalle : System.Web.UI.Page
    {
        public ArticuloNegocio leer;
        protected void Page_Load(object sender, EventArgs e)
        {
            leer = new ArticuloNegocio();

            int id = int.Parse(Request.QueryString["id"]);
            List<Articulo> listado = (List<Articulo>)Session["articulos"];
            Articulo seleccionado = listado.Find(X => X.Id == id);
            lblNombre.Text= seleccionado.Nombre;
            lblDescripcion.Text= seleccionado.Descripcion;
            Session["id"]= (int)seleccionado.Id;
            Session["precio"]= (decimal)seleccionado.Precio;
            Session["imagen"]= seleccionado.UrlImagen;


         }

   

    }
}