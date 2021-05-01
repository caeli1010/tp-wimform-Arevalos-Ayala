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
    public partial class frmNuevo : Form
    {
        private bool bandera = true;

        public frmNuevo()
        {
            InitializeComponent();
        }
        public frmNuevo(bool _bandera)
        {
            InitializeComponent();
            bandera = (_bandera==true)?true:false;
            Text = (_bandera == true)?"Agregar Categoria":"Agregar Marca"; 
            lblNuevo.Text = (_bandera == true) ? "Agregar Categoria" : "Agregar Marca";
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {

        }

        private void iBtnAceptar_Click(object sender, EventArgs e)
        { 
            if(bandera == true)
            {
                CategoriaNegocio cargar = new CategoriaNegocio();
                Categoria cNueva = new Categoria(txtNuevo.Text);
                cargar.agregar(cNueva);
                MessageBox.Show("La categoria "+txtNuevo.Text+" se agregó correctamente!!");
                Close();
            }
            else
            {
                MarcaNegocio asignar = new MarcaNegocio();
                Marca mNueva = new Marca(txtNuevo.Text);
                asignar.agregar(mNueva);
                MessageBox.Show("La marca " + txtNuevo.Text + " se agregó correctamente!!");
                Close();
            }
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
