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
    public partial class fmListaReunion : Form
    {
         List<Reuniones> listareunion ; // lista de Reuniones
        
        
        public fmListaReunion()
        {
            InitializeComponent();
            listareunion = new List<Reuniones>();
        }

        private void LlenarDataGrid()  // Llenar DataGRid 
        {
        
                dataReuniones.Rows.Clear();
           foreach (var item in listareunion)
            {
                dataReuniones.Rows.Add(item.Asunto,item.fecha.ToShortDateString(),item.DuracionHora+":"+item.DuracionMinuto+"Horas",item.Participantes);
            }
            this.eliminarReunion.Visible = true;

        }


        private void fmListaReunion_Load(object sender, EventArgs e)
        {
            this.eliminarReunion.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aggReunion_Click(object sender, EventArgs e) // crear una reunión nueva 

        {
            fmReuniones freunion = new fmReuniones();
            if (freunion.ShowDialog() == DialogResult.OK)
            {
                Reuniones reunion = new Reuniones();
                reunion.Asunto=freunion.Asunto;
                reunion.DuracionMinuto=freunion.DuracionMinuto;
                reunion.DuracionHora=freunion.DuracionHora;
                reunion.fecha = freunion.fecha;
                reunion.Participantes=freunion.Participantes;
               
                this.listareunion.Add(reunion);
                
                LlenarDataGrid();
               
            }

        }

        private void eliminarReunion_Click(object sender, EventArgs e)
        {
            
            
            if(listareunion.Count > 0)
            {
                listareunion.RemoveAt(dataReuniones.CurrentRow.Index);
               
            }
            LlenarDataGrid();
        }
    }
}
