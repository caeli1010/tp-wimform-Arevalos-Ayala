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
    public partial class SiteMaster : MasterPage
    {
        private List<Articulo> listaArticulo;
        protected void Page_Load(object sender, EventArgs e)
        {
            listaArticulo = new List<Articulo>();

         
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            List<Articulo> listaFiltrada;
            if (txtFiltro.Text != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.marca.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.categoria.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                Session["articulos"] = listaFiltrada;
                Response.Redirect("Productos.aspx");


            }
            else
            {
                listaFiltrada = new List<Articulo>();
                Session["articulos"] = listaFiltrada;
                Response.Redirect("Productos.aspx");
            }
        }
    }
}