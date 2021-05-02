using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;
        public frmDetalle(Articulo _articulo)
        {
            InitializeComponent();
            this.articulo = _articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {

            txtDetalle.Text = "Nombre :" + articulo.Nombre +
                "\r\nDescripción: " + articulo.Descripcion+
                "\r\nPrecio: " + articulo.Precio+
                "\r\nMarca: " + articulo.marca.Nombre;
            try
            {
                imgDetalle.Load((string)articulo.UrlImagen);
            }
            catch (Exception)
            {
                imgDetalle.Load("https://c.tenor.com/eDchk3srtycAAAAj/piffle-error.gif");
            }
        }
        private void frmDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
