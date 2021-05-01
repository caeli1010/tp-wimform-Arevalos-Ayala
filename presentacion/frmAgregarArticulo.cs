using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace presentacion
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        public frmAgregarArticulo(Articulo _articulo)
        {
            InitializeComponent();
            this.articulo = _articulo;
            Text = "Modificar Articulo";
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo nuevo = new Articulo();
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.marca = (Marca)cbxMarca.SelectedItem;
                    articulo.categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.UrlImagen = txtImagen.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);

                //_articulo.Id = (_articulo.Id!=0) ? _articulo.Id : 0;
                if (articulo.Id == 0)
                {
                    ArticuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado correctamente!!");
                    
                }
                else
                {
                    ArticuloNegocio.modificar(articulo);
                    MessageBox.Show(" Modificado correctamente!!");
                    
                }
               
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void precio(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 ) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar == 44)
                e.Handled = true;

            //Pregunto si es Enter.
            else if (e.KeyChar == 13)
            {
                //Si es Enter, pregunto si la cantidad de caracteres es mayor a 0.
                if (txtPrecio.Text.Length > 0)            
                //Si es Enter y no se ingresaron caracteres, controlo el evento.
                e.Handled = true;

            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcasNegocio = new MarcaNegocio();
            CategoriaNegocio categoriasNegocio = new CategoriaNegocio();
            try
            {

                cbxMarca.DataSource = marcasNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Nombre";
                cbxCategoria.DataSource = categoriasNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cbxMarca.SelectedValue = articulo.marca.Id;
                    cbxCategoria.SelectedValue = articulo.categoria.Id;
                    txtImagen.Text = articulo.UrlImagen;
                    txtPrecio.Text = (string)articulo.Precio.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
