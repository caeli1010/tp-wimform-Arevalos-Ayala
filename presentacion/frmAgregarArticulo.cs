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
        private Articulo _articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        public frmAgregarArticulo(Articulo _articulo)
        {
            InitializeComponent();
            this._articulo = _articulo;
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
                _articulo.Codigo = txtCodigo.Text;
                _articulo.Nombre = txtNombre.Text;
                _articulo.Descripcion = txtDescripcion.Text;
                _articulo.marca = (Marca)cbxMarca.SelectedItem;
                _articulo.categoria = (Categoria)cbxCategoria.SelectedItem;
                _articulo.UrlImagen = txtImagen.Text;
                _articulo.Precio = decimal.Parse(txtPrecio.Text);

                //_articulo.Id = (_articulo.Id!=0) ? _articulo.Id : 0;
                ArticuloNegocio.guardarArticulo(_articulo);
                MessageBox.Show("correcto!!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void precio(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 ) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar == 46)
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
                if (_articulo != null)
                {
                    txtCodigo.Text = _articulo.Codigo;
                    txtNombre.Text = _articulo.Nombre;
                    txtDescripcion.Text = _articulo.Descripcion;
                    cbxMarca.SelectedValue = _articulo.marca.Id;
                    cbxCategoria.SelectedValue = _articulo.categoria.Id;
                    txtImagen.Text = _articulo.UrlImagen;
                    txtPrecio.Text = _articulo.Precio.ToString();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
