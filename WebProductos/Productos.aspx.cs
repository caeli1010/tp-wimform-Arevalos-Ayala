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
    public partial class Productos : System.Web.UI.Page
    {
        public List<Articulo> lista;
        //public List<ItemCarrito> 
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
            lista = negocio.listar();
            Session.Add("articulos", lista);
             Session["cant"] = int.Parse(txtCantidad.Text);
            }
            catch (Exception error)
            {
                Session.Add("Error", error.ToString());
                Response.Redirect("Error.aspx");               
            }

        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Session["cant"] = int.Parse(((TextBox)sender).Text);
        }
    }
}