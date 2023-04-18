namespace Grupo_Calculadora
{
    partial class frmCiudad
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.RJGuardar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJCancelar = new Grupo_Calculadora.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(11, 50);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 14;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(11, 65);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(214, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // RJGuardar
            // 
            this.RJGuardar.BackColor = System.Drawing.Color.Blue;
            this.RJGuardar.BackgroundColor = System.Drawing.Color.Blue;
            this.RJGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJGuardar.BorderRadius = 15;
            this.RJGuardar.BorderSize = 0;
            this.RJGuardar.FlatAppearance.BorderSize = 0;
            this.RJGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJGuardar.ForeColor = System.Drawing.Color.White;
            this.RJGuardar.Location = new System.Drawing.Point(19, 107);
            this.RJGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RJGuardar.Name = "RJGuardar";
            this.RJGuardar.Size = new System.Drawing.Size(92, 32);
            this.RJGuardar.TabIndex = 17;
            this.RJGuardar.Text = "Guardar";
            this.RJGuardar.TextColor = System.Drawing.Color.White;
            this.RJGuardar.UseVisualStyleBackColor = false;
            this.RJGuardar.Click += new System.EventHandler(this.RJGuardar_Click);
            // 
            // RJCancelar
            // 
            this.RJCancelar.BackColor = System.Drawing.Color.Red;
            this.RJCancelar.BackgroundColor = System.Drawing.Color.Red;
            this.RJCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJCancelar.BorderRadius = 15;
            this.RJCancelar.BorderSize = 0;
            this.RJCancelar.FlatAppearance.BorderSize = 0;
            this.RJCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJCancelar.ForeColor = System.Drawing.Color.White;
            this.RJCancelar.Location = new System.Drawing.Point(130, 107);
            this.RJCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RJCancelar.Name = "RJCancelar";
            this.RJCancelar.Size = new System.Drawing.Size(92, 32);
            this.RJCancelar.TabIndex = 18;
            this.RJCancelar.Text = "Cancelar";
            this.RJCancelar.TextColor = System.Drawing.Color.White;
            this.RJCancelar.UseVisualStyleBackColor = false;
            this.RJCancelar.Click += new System.EventHandler(this.RJCancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ciudad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RJCancelar);
            this.Controls.Add(this.RJGuardar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCiudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private RJControls.RJButton RJGuardar;
        private RJControls.RJButton RJCancelar;
        private System.Windows.Forms.Label label1;
    }
}