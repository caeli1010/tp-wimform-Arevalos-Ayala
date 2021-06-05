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
                        List<Articulo> seleccionado = (List<Articulo>)Session["listaArticulos"];
                        Pila.Add(seleccionado.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                    }
                }

                //Repeater
                //repetidor.DataSource = Pila;
                //repetidor.DataBind();
            }

            Session.Add("listaArticulos", Pila);





            //int id = int.Parse(Request.QueryString["id"]);
            //List<Articulo> listado = (List<Articulo>)Session["articulos"];
            //Articulo seleccionado = listado.Find(X => X.Id == id);


            //    for (int i = 0; i <= Pila.Count(); i++)
            //    {
            //        Pila.Push(seleccionado);
            //        Session["contador"] = Pila.Count();
                    //Session["desc" + (int)Session["contador"]] = (string)Pila.Peek().Descripcion;
                    //Session["nom" + (int)Session["contador"]] = (string)Pila.Peek().Nombre;
                    //Session["img" + (int)Session["contador"]] = (string)Pila.Peek().UrlImagen;
           
        }
    }
}