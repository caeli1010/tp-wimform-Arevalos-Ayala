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
    public partial class frmCatalogo : Form
    {
        private Articulo articulo = null;
        private List<Articulo> listaArticulo;
        public frmCatalogo()
        {
            InitializeComponent();
        }
       
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulo = ArticuloNegocio.listar();
                dgvDetalle.DataSource = listaArticulo;
                //ocultarColumnas();
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
       
        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregar = new frmAgregarArticulo();
            agregar.ShowDialog();
            cargarGrilla();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            busqueda();
        }
        private void iconBtnModificar_Click(object sender, EventArgs e)
        {

            articulo = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(articulo);
            modificar.ShowDialog();
            cargarGrilla();
        }
        private void iconBtnEliminar_Click(object sender, EventArgs e)
        {
            articulo = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
            ArticuloNegocio elimina = new ArticuloNegocio();
            try
            {
                if (MessageBox.Show(" Estás seguro que lo vas a eliminar.? ", "Eliminandoo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    elimina.eliminar(articulo.Id);
                    cargarGrilla();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void ocultarColumnas()
        {
            
            //Oculto Columnas de la grilla.
            //Puedo poner el indice de la columna o el nombre de la propiedad.
            dgvDetalle.Columns["Id"].Visible = false;
            dgvDetalle.Columns["Codigo"].Visible = false;
            dgvDetalle.Columns["Descripcion"].Visible = false;
            dgvDetalle.Columns["UrlImagen"].Visible = false;
            dgvDetalle.Columns["Precio"].Visible = false;
        }
        private void txtFiltro_Click(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            //txtFiltro
            List<Articulo> listaFiltrada;
            if (txtFiltro.Text != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.marca.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())|| x.categoria.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = listaFiltrada;
            }
            else
            {
                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = listaArticulo;
            }

            //ocultarColumnas();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

    }
}
