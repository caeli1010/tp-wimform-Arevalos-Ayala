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

            leer.leerArticulo(id);

            mostrar();
         }
        public void mostrar() {
            lblDescripcion.Text = "aca va la descripcion";
            lblNombre.Text = "aca va la Nombre";
            lblImagen.Text = "aca va la imagen";
        }

    }
}