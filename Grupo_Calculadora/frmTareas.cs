using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_Calculadora {
    public partial class frmTareas : Form {

        
        public int row;
        public frmTareas() {
            InitializeComponent();
        }

        private void frmTareas_Load(object sender, EventArgs e) {
            if (dtgTareas.Rows.Count == 0) {
                btnEditar.Visible = false;
                BtnEliminar.Visible = false;
            }
            cmbTipo.SelectedIndex = 0;
            pnlRegistro.Visible = false;
            btnActualizar.Visible = false;

            dtgTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Para que las columnas se adapten segun el tamaño de texto que exista.
            //dtgTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders; // Para que el tamaño de las filas se adapten al contenido de las misma
            dtgTareas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar contenido de los Headers
            dtgTareas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar contenido de las celdas
            //dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // lineas dobles en filas


            dtgTareas.EnableHeadersVisualStyles = false; // Utilizar las configuraciones del usuario
            DataGridViewCellStyle sty = new DataGridViewCellStyle();
            sty.BackColor = System.Drawing.Color.White;
            sty.ForeColor = System.Drawing.Color.Black;
            sty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold);
            dtgTareas.ColumnHeadersDefaultCellStyle = sty;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            BtnEliminar.Visible = false;
            pnlRegistro.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            
            txtTitulo.Text = dtgTareas.SelectedCells[0].Value.ToString();
            txtDescripcion.Text = dtgTareas.SelectedCells[1].Value.ToString();
            cmbTipo.Text = dtgTareas.SelectedCells[2].Value.ToString();
            pnlRegistro.Visible = true;
            btnAceptar.Visible = false;
            btnActualizar.Visible = true;


            
        }

        private void BtnEliminar_Click(object sender, EventArgs e) {
            dtgTareas.Rows.RemoveAt(dtgTareas.CurrentRow.Index);
            int num = Int32.Parse(lblContador.Text) - 1;
            lblContador.Text = num.ToString();
            if (dtgTareas.Rows.Count == 0) {
                btnEditar.Visible = false;
                BtnEliminar.Visible = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (dtgTareas.Rows.Count == 0) {
                btnAgregar.Visible = true;
                btnEditar.Visible = false;
                BtnEliminar.Visible = false;
                pnlRegistro.Visible = false;
            } else {
                btnAgregar.Visible = true;
                btnEditar.Visible = true;
                BtnEliminar.Visible = true;
                pnlRegistro.Visible = false;
                txtTitulo.Text = "";
                cmbTipo.SelectedIndex = 0;
                txtDescripcion.Text = "";

            }
         
            
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dtgTareas);
            newRow.Cells[0].Value = txtTitulo.Text;
            newRow.Cells[1].Value = txtDescripcion.Text;
            newRow.Cells[2].Value = cmbTipo.Text;
            dtgTareas.Rows.Add(newRow);
            btnAgregar.Visible = true;
            btnEditar.Visible = true;
            BtnEliminar.Visible = true;
            pnlRegistro.Visible = false;
            txtTitulo.Text = "";
            cmbTipo.SelectedIndex = 0;
            txtDescripcion.Text = "";
            int num = 1 + Int32.Parse(lblContador.Text);
            lblContador.Text = num.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            row = dtgTareas.CurrentRow.Index;
            this.dtgTareas[0, row].Value = txtTitulo.Text;
            this.dtgTareas[1, row].Value = txtDescripcion.Text;
            this.dtgTareas[2, row].Value = cmbTipo.Text;
            btnAceptar.Visible = true;
            btnActualizar.Visible = false;
            pnlRegistro.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
