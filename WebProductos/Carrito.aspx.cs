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
        public static Stack<Articulo>Pila;
        protected void Page_Load(object sender, EventArgs e)
        {
        Pila = new Stack<Articulo>();

            int id = int.Parse(Request.QueryString["id"]);
            decimal precio = decimal.Parse(Request.QueryString["precio"]);
            List<Articulo> listado = (List<Articulo>)Session["articulos"];
            Articulo seleccionado = listado.Find(X => X.Id == id);

            Pila.Push(seleccionado);

                for (int i = 0; i <= Pila.Count(); i++)
                {
                    Session["contador"] = Pila.Count();
                    Session["desc" + (int)Session["contador"]] = (string)Pila.Peek().Descripcion;
                    Session["nom" + (int)Session["contador"]] = (string)Pila.Peek().Nombre;
                    Session["img" + (int)Session["contador"]] = (string)Pila.Peek().UrlImagen;
                }
        }
    }
}