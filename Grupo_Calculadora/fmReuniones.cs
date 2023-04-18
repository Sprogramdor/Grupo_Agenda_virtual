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
    public partial class fmReuniones : Form
    {
        public String Asunto;
        public  int DuracionHora;
        public  int DuracionMinuto;
        public int Participantes;
        public DateTime fecha;
      


        public fmReuniones()
        {
            InitializeComponent();
            this.cargaCombobox();
           
        }

        private void fmReuniones_Load(object sender, EventArgs e)
        {
            participantes.SelectedIndex = 0;

        }

        private void dateP_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void rjButton1_Click(object sender, EventArgs e) //guardarCita
        {
            this.Asunto = asuntotext.Text;
            if (horaBox.Text == "" || minutoBox.Text == "")
            {
                this.DuracionHora = 0;
                this.DuracionMinuto = 0;

            }
            else
            {
                this.DuracionHora = Int16.Parse(horaBox.Text);
                this.DuracionMinuto = Int16.Parse(minutoBox.Text);
            }
                fecha= new DateTime(dateP.Value.Year, dateP.Value.Month,dateP.Value.Day,dateP.Value.Hour, dateP.Value.Minute,dateP.Value.Second);
            this.Participantes = Int16.Parse(participantes.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public void cargaCombobox() // Carga Combo Box de hora y minutos 
        {
            for (int i = 1; i <= 12; i++)
            {
                this.horaBox.Items.Add(i);
            }
            for (int i = 0;i<= 59; i++)
            {
                this.minutoBox.Items.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                this.participantes.Items.Add(i);
            }

        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
