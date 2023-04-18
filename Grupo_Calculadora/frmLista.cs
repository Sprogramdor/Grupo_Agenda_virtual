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
    public partial class FrmLista : Form
    {
        List<clsContacto> Contactos = new List<clsContacto>(); // lista de contactos
        public FrmLista()
        {
            InitializeComponent();
          
        }

       

        clsContacto Contacto =new clsContacto();
        private void LlenarDataGrid()  // Llenar DataGRid 
        {
            dgContactos.DataSource = null;
            if (Contactos.Count > 0) {
                dgContactos.DataSource = Contactos;
                RJEliminar.Visible = true;
                RJEditar.Visible = true;
             }
            else
            {
                RJEliminar.Visible = false;
                RJEditar.Visible = false;
            }
        }
        private void FrmLista_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
            RJEliminar.Visible = false;
            RJEditar.Visible = false;
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Contactos.RemoveAt(dgContactos.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RJAgregar_Click(object sender, EventArgs e)
        {
            frmContacto Nuevo = new frmContacto();
            if (Nuevo.ShowDialog() == DialogResult.OK)
            {
                Contacto = new clsContacto();
                Contacto.Nombre = Nuevo.Nombre;
                Contacto.Apellido = Nuevo.Apellido;
                Contacto.Telefono = Nuevo.Telefono;
                Contacto.Celular = Nuevo.Celular;
                Contacto.Ciudad = Nuevo.Ciudad;
                Contactos.Add(Contacto);
                LlenarDataGrid();
            }

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Contactos.RemoveAt(dgContactos.CurrentRow.Index);
            LlenarDataGrid();
        }

        

        private void RJSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void E_Click(object sender, EventArgs e)
        {

            int index = dgContactos.CurrentRow.Index;
            frmContacto Nuevo = new frmContacto(Contactos[index].Nombre, Contactos[index].Apellido, Contactos[index].Telefono, Contactos[index].Celular, Contactos[index].Ciudad);
               
            
            if (Nuevo.ShowDialog() == DialogResult.OK)
                {
                Contactos[index].Nombre = Nuevo.Nombre;
                Contactos[index].Apellido = Nuevo.Apellido;
                Contactos[index].Telefono = Nuevo.Telefono;
                Contactos[index].Celular = Nuevo.Celular;
                Contactos[index].Ciudad = Nuevo.Ciudad;
                LlenarDataGrid();
                }
   
        }
    }
}
