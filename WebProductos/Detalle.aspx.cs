﻿using System;
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
        public List<Categoria> categoria;
        protected void Page_Load(object sender, EventArgs e)
        {
            leer = new ArticuloNegocio();
            CategoriaNegocio negocio = new CategoriaNegocio();

            List<Articulo> listado = (List<Articulo>)Session["articulos"];
            Articulo seleccionado = listado.Find(X => X.Id.ToString() == Request.QueryString["id"]);
            lblNombre.Text= seleccionado.Nombre;
            lblDescripcion.Text= seleccionado.Descripcion;
            Session["id"]= (int)seleccionado.Id;
            Session["precio"]= seleccionado.Precio.ToString("N");
            Session["imagen"]= seleccionado.UrlImagen;

            categoria = negocio.listar();

         }

   

    }
}