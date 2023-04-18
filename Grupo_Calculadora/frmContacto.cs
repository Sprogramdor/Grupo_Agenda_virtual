using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_Calculadora
{
    public partial class frmContacto : Form
    {
        public String Nombre;
        public String Apellido;
        public String Telefono;
        public String Celular;
        public String Ciudad;

        public frmContacto()
        {
            InitializeComponent();
            Actualizar.Visible = false;
        }

        private void RJGuardar_Click(object sender, EventArgs e)
        {
            Nombre = tbNombre.Text;
            Apellido = txApellido.Text;
            Telefono = mtbTelefono.Text;
            Celular = mtbCelular.Text;
            Ciudad = cbCiudad.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void RJCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RJAgregar_Click(object sender, EventArgs e)
        {
            frmCiudad Ciudad = new frmCiudad();
            if (Ciudad.ShowDialog() == DialogResult.OK)
            {
                cbCiudad.Items.Add(Ciudad.Nombre);
            }
        }

        public frmContacto(String Nombre, String Apellido, String Telefono, String Celular, String Ciudad)
        {
            InitializeComponent();
            RJGuardar.Visible = false;
            Actualizar.Visible = true;
            titulo.Text = "Actualizar Contacto";
            tbNombre.Text = Nombre;
            txApellido.Text = Apellido;
            mtbTelefono.Text = Telefono;
            mtbCelular.Text = Celular;
            cbCiudad.Text = Ciudad;
        }
    

        private void Actualizar_Click(object sender, EventArgs e)// boton para actualizar datos 
        {
            Nombre = tbNombre.Text;
            Apellido = txApellido.Text;
            Telefono = mtbTelefono.Text;
            Celular = mtbCelular.Text;
            Ciudad = cbCiudad.Text;
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void frmContacto_Load(object sender, EventArgs e) {
            cbCiudad.SelectedIndex = 0;
           
        }
    }
}
