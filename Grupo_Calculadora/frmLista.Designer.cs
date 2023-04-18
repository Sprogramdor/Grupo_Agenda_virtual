namespace Grupo_Calculadora
{
    partial class FrmLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgContactos = new System.Windows.Forms.DataGridView();
            this.RJAgregar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJEliminar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJEditar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJSalir = new Grupo_Calculadora.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContactos
            // 
            this.dgContactos.AllowUserToAddRows = false;
            this.dgContactos.AllowUserToDeleteRows = false;
            this.dgContactos.AllowUserToResizeRows = false;
            this.dgContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContactos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgContactos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgContactos.EnableHeadersVisualStyles = false;
            this.dgContactos.GridColor = System.Drawing.SystemColors.Control;
            this.dgContactos.Location = new System.Drawing.Point(1, 38);
            this.dgContactos.Margin = new System.Windows.Forms.Padding(2);
            this.dgContactos.Name = "dgContactos";
            this.dgContactos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgContactos.RowHeadersVisible = false;
            this.dgContactos.RowHeadersWidth = 51;
            this.dgContactos.RowTemplate.Height = 24;
            this.dgContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContactos.Size = new System.Drawing.Size(578, 283);
            this.dgContactos.TabIndex = 0;
            this.dgContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContactos_CellContentClick);
            // 
            // RJAgregar
            // 
            this.RJAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.RJAgregar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.RJAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJAgregar.BorderRadius = 15;
            this.RJAgregar.BorderSize = 0;
            this.RJAgregar.FlatAppearance.BorderSize = 0;
            this.RJAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJAgregar.ForeColor = System.Drawing.Color.White;
            this.RJAgregar.Location = new System.Drawing.Point(11, 329);
            this.RJAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.RJAgregar.Name = "RJAgregar";
            this.RJAgregar.Size = new System.Drawing.Size(84, 31);
            this.RJAgregar.TabIndex = 4;
            this.RJAgregar.Text = "Agregar";
            this.RJAgregar.TextColor = System.Drawing.Color.White;
            this.RJAgregar.UseVisualStyleBackColor = false;
            this.RJAgregar.Click += new System.EventHandler(this.RJAgregar_Click);
            // 
            // RJEliminar
            // 
            this.RJEliminar.BackColor = System.Drawing.Color.DeepPink;
            this.RJEliminar.BackgroundColor = System.Drawing.Color.DeepPink;
            this.RJEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJEliminar.BorderRadius = 15;
            this.RJEliminar.BorderSize = 0;
            this.RJEliminar.FlatAppearance.BorderSize = 0;
            this.RJEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJEliminar.ForeColor = System.Drawing.Color.White;
            this.RJEliminar.Location = new System.Drawing.Point(194, 329);
            this.RJEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.RJEliminar.Name = "RJEliminar";
            this.RJEliminar.Size = new System.Drawing.Size(77, 31);
            this.RJEliminar.TabIndex = 5;
            this.RJEliminar.Text = "Eliminar";
            this.RJEliminar.TextColor = System.Drawing.Color.White;
            this.RJEliminar.UseVisualStyleBackColor = false;
            this.RJEliminar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // RJEditar
            // 
            this.RJEditar.BackColor = System.Drawing.Color.OliveDrab;
            this.RJEditar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.RJEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJEditar.BorderRadius = 15;
            this.RJEditar.BorderSize = 0;
            this.RJEditar.FlatAppearance.BorderSize = 0;
            this.RJEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJEditar.ForeColor = System.Drawing.Color.White;
            this.RJEditar.Location = new System.Drawing.Point(99, 329);
            this.RJEditar.Margin = new System.Windows.Forms.Padding(2);
            this.RJEditar.Name = "RJEditar";
            this.RJEditar.Size = new System.Drawing.Size(73, 31);
            this.RJEditar.TabIndex = 6;
            this.RJEditar.Text = "Editar";
            this.RJEditar.TextColor = System.Drawing.Color.White;
            this.RJEditar.UseVisualStyleBackColor = false;
            this.RJEditar.Click += new System.EventHandler(this.E_Click);
            // 
            // RJSalir
            // 
            this.RJSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.RJSalir.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.RJSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJSalir.BorderRadius = 15;
            this.RJSalir.BorderSize = 0;
            this.RJSalir.FlatAppearance.BorderSize = 0;
            this.RJSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJSalir.ForeColor = System.Drawing.Color.White;
            this.RJSalir.Location = new System.Drawing.Point(493, 329);
            this.RJSalir.Margin = new System.Windows.Forms.Padding(2);
            this.RJSalir.Name = "RJSalir";
            this.RJSalir.Size = new System.Drawing.Size(76, 31);
            this.RJSalir.TabIndex = 7;
            this.RJSalir.Text = "Salir";
            this.RJSalir.TextColor = System.Drawing.Color.White;
            this.RJSalir.UseVisualStyleBackColor = false;
            this.RJSalir.Click += new System.EventHandler(this.RJSalir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contactos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RJSalir);
            this.Controls.Add(this.RJEditar);
            this.Controls.Add(this.RJEliminar);
            this.Controls.Add(this.RJAgregar);
            this.Controls.Add(this.dgContactos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(596, 410);
            this.MinimumSize = new System.Drawing.Size(596, 410);
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContactos;
        private RJControls.RJButton RJAgregar;
        private RJControls.RJButton RJEliminar;
        private RJControls.RJButton RJEditar;
        private RJControls.RJButton RJSalir;
        private System.Windows.Forms.Label label1;
    }
}