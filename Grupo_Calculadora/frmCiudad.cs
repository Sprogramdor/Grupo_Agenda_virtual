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
    public partial class frmCiudad : Form
    {
        public String Nombre;
        public frmCiudad()
        {
            InitializeComponent();
        }

        private void RJGuardar_Click(object sender, EventArgs e)
        {
            Nombre = tbNombre.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void RJCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
