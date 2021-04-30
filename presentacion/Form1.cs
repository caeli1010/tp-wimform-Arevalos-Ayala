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
using FontAwesome.Sharp;
namespace presentacion
{
    public partial class frmCatalogo : Form
    {
       
        private List<Articulo> listaArticulo;
       
        public frmCatalogo()
        {
            InitializeComponent();
        }
      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            this.btnSearch.Text = "Listar";
        }

        private void cargarGrilla()
        {
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulo = ArticuloNegocio.listar();
                dgvDetalle.DataSource = listaArticulo;

                //dgvDetalle.Columns["UrlImagen"].Visible = false;//ocultamos la columna
                //dgvDetalle.Columns["Precio"].Visible = true;
                //dgvDetalle.Columns["Precio"]. = dgvDetalle.MiddleRight;
                
                RecargarImg(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void RecargarImg(string img)
        {
            pbxImagen.Load(img);
        }

        private void dgvDetalle_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.UrlImagen);
        }

     
        private void btnListar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificado = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(modificado);
            modificar.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            this.btnSearch.Text = "Buscar";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregar = new frmAgregarArticulo();
            agregar.ShowDialog();
            //cargarGrilla();
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo modificado = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(modificado);
            modificar.ShowDialog();
        }
    }
}
