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
        public decimal total=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            productos = (List<ItemCarrito>)Session["listaArticulos"];
            foreach (ItemCarrito item in productos)
            {
               total+= (decimal)item.subTotal;
            }
            lblTotal.Text = total.ToString();
        }
    }
}