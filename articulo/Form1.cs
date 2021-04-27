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

namespace WindowsFormsAppTP1
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            cargarGrilla();

        }
        void cargarGrilla()
        {
            ArticuloNegocio registro = new ArticuloNegocio();
            try
            {
                listaArticulos = registro.listar();
                dgvDetalle.DataSource = listaArticulos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
        }
    }
}
