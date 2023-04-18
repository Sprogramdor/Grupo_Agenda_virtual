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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contacto_Click(object sender, EventArgs e)
        {
           
         FrmLista f=new FrmLista();
            f.ShowDialog(); 
    }

        private void Reunion_Click(object sender, EventArgs e)
        {
            fmListaReunion r=new fmListaReunion();    
            r.ShowDialog();

        }

        private void Tareas_Click(object sender, EventArgs e) {
            frmTareas t = new frmTareas();
            t.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
