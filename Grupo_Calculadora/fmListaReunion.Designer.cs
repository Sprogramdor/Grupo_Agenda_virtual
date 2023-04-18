namespace Grupo_Calculadora
{
    partial class fmListaReunion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aggReunion = new Grupo_Calculadora.RJControls.RJButton();
            this.eliminarReunion = new Grupo_Calculadora.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataReuniones = new System.Windows.Forms.DataGridView();
            this.asuntobox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechabox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nparticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salir = new Grupo_Calculadora.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReuniones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.aggReunion);
            this.panel1.Controls.Add(this.eliminarReunion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 70);
            this.panel1.TabIndex = 0;
            // 
            // aggReunion
            // 
            this.aggReunion.BackColor = System.Drawing.Color.Coral;
            this.aggReunion.BackgroundColor = System.Drawing.Color.Coral;
            this.aggReunion.BorderColor = System.Drawing.Color.White;
            this.aggReunion.BorderRadius = 15;
            this.aggReunion.BorderSize = 2;
            this.aggReunion.FlatAppearance.BorderSize = 0;
            this.aggReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggReunion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggReunion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aggReunion.Location = new System.Drawing.Point(12, 12);
            this.aggReunion.Name = "aggReunion";
            this.aggReunion.Size = new System.Drawing.Size(156, 40);
            this.aggReunion.TabIndex = 9;
            this.aggReunion.Text = "Agregar Reunión";
            this.aggReunion.TextColor = System.Drawing.Color.WhiteSmoke;
            this.aggReunion.UseVisualStyleBackColor = false;
            this.aggReunion.Click += new System.EventHandler(this.aggReunion_Click);
            // 
            // eliminarReunion
            // 
            this.eliminarReunion.BackColor = System.Drawing.Color.Coral;
            this.eliminarReunion.BackgroundColor = System.Drawing.Color.Coral;
            this.eliminarReunion.BorderColor = System.Drawing.Color.White;
            this.eliminarReunion.BorderRadius = 15;
            this.eliminarReunion.BorderSize = 2;
            this.eliminarReunion.FlatAppearance.BorderSize = 0;
            this.eliminarReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarReunion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarReunion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eliminarReunion.Location = new System.Drawing.Point(665, 12);
            this.eliminarReunion.Name = "eliminarReunion";
            this.eliminarReunion.Size = new System.Drawing.Size(85, 40);
            this.eliminarReunion.TabIndex = 7;
            this.eliminarReunion.Text = "Eliminar";
            this.eliminarReunion.TextColor = System.Drawing.Color.WhiteSmoke;
            this.eliminarReunion.UseVisualStyleBackColor = false;
            this.eliminarReunion.Click += new System.EventHandler(this.eliminarReunion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Reuniones ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataReuniones
            // 
            this.dataReuniones.AllowUserToAddRows = false;
            this.dataReuniones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataReuniones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataReuniones.BackgroundColor = System.Drawing.Color.White;
            this.dataReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReuniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asuntobox,
            this.fechabox,
            this.duracion,
            this.nparticipante});
            this.dataReuniones.Location = new System.Drawing.Point(162, 76);
            this.dataReuniones.Name = "dataReuniones";
            this.dataReuniones.ReadOnly = true;
            this.dataReuniones.Size = new System.Drawing.Size(443, 280);
            this.dataReuniones.TabIndex = 1;
            this.dataReuniones.TabStop = false;
            // 
            // asuntobox
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lavender;
            this.asuntobox.DefaultCellStyle = dataGridViewCellStyle2;
            this.asuntobox.HeaderText = "Asunto";
            this.asuntobox.MaxInputLength = 35;
            this.asuntobox.Name = "asuntobox";
            this.asuntobox.ReadOnly = true;
            // 
            // fechabox
            // 
            this.fechabox.HeaderText = "Fecha";
            this.fechabox.Name = "fechabox";
            this.fechabox.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duración ";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // nparticipante
            // 
            this.nparticipante.HeaderText = "N° Participantes";
            this.nparticipante.Name = "nparticipante";
            this.nparticipante.ReadOnly = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Crimson;
            this.salir.BackgroundColor = System.Drawing.Color.Crimson;
            this.salir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.salir.BorderRadius = 15;
            this.salir.BorderSize = 0;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(640, 398);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(110, 40);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.TextColor = System.Drawing.Color.White;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // fmListaReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dataReuniones);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(778, 489);
            this.MinimumSize = new System.Drawing.Size(778, 489);
            this.Name = "fmListaReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmListaReunion";
            this.Load += new System.EventHandler(this.fmListaReunion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReuniones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataReuniones;
        private RJControls.RJButton salir;
        private RJControls.RJButton eliminarReunion;
        private RJControls.RJButton aggReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechabox;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nparticipante;
    }
}