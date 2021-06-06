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
        public List<Articulo> Pila;
        protected void Page_Load(object sender, EventArgs e)
        {
        Pila = (List<Articulo>)Session["listaArticulos"];

            if (Pila == null)
                Pila = new List<Articulo>();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    if (Pila.Find(x => x.Id.ToString() == Request.QueryString["id"]) == null)
                    {
                        List<Articulo> seleccionado = (List<Articulo>)Session["articulos"];
                        Pila.Add(seleccionado.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                    }
                }

                //Repeater
                //repetidor.DataSource = Pila;
                //repetidor.DataBind();
            }

            Session.Add("listaArticulos", Pila);

           
        }

    }
}