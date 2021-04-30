﻿using System;
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
        private Articulo modificado = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        public frmAgregarArticulo(Articulo modificado)
        {
            InitializeComponent();
            this.modificado = modificado;
            Text = "Modificar Articulo";
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.marca = (Marca)cbxMarca.SelectedItem;
                nuevo.categoria = (Categoria)cbxCategoria.SelectedItem;
                nuevo.UrlImagen = txtImagen.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                //nuevo.Id = nu
                ArticuloNegocio.guardarArticulo(nuevo);
                MessageBox.Show("agregado sin problema");
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
                cbxCategoria.DataSource = categoriasNegocio.listar();
                if(modificado != null)
                {
                    txtCodigo.Text = modificado.Codigo;
                    txtNombre.Text = modificado.Nombre;
                    txtDescripcion.Text = modificado.Descripcion;
                    cbxMarca.SelectedItem = modificado.marca;
                    cbxCategoria.SelectedItem = modificado.categoria;
                    txtImagen.Text = modificado.UrlImagen;
                    txtPrecio.Text = "33456";


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
