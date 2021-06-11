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
        public List<Categoria> categoria;
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            CategoriaNegocio leer = new CategoriaNegocio();
            categoria = leer.listar();
            try
            {
                if (Session["articulos"] == null)
                {
                    lista = negocio.listar();
                    Session.Add("articulos", lista);
                }
                else
                {
                    if (Request.QueryString["id"] != null)
                    {
                        id = int.Parse(Request.QueryString["id"]);
 
                    }
                        lista = (List<Articulo>)Session["articulos"];
                }
            }
            catch (Exception error)
            {
                Session.Add("Error", error.ToString());
                Response.Redirect("Error.aspx");               
            }

        }

    }
}