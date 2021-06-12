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
    public partial class verCarrito : System.Web.UI.Page
    {
        public List<ItemCarrito> productos;
        public decimal total;
        protected void Page_Load(object sender, EventArgs e)
        {
            productos = Session["listaArticulos"];
            //ItemCarrito seleccionado = productos);
            //int id = selecionado.producto.Id;
            //total = selecionado.subTotal;

        }
    }
}