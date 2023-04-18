namespace Grupo_Calculadora
{
    partial class frmContacto
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.Actualizar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJAgregar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJCancelar = new Grupo_Calculadora.RJControls.RJButton();
            this.RJGuardar = new Grupo_Calculadora.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(13, 97);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.MaxLength = 25;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(350, 28);
            this.tbNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(11, 72);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(79, 24);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(13, 163);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(85, 24);
            this.lbTelefono.TabIndex = 4;
            this.lbTelefono.Text = "Teléfono";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiudad.Location = new System.Drawing.Point(22, 249);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(70, 24);
            this.lbCiudad.TabIndex = 5;
            this.lbCiudad.Text = "Ciudad";
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "-Seleccionar-",
            "Guayaquil",
            "Quito",
            "Ambato",
            "Loja",
            "Machala",
            "Milagro",
            "Duran",
            "Esmeralda"});
            this.cbCiudad.Location = new System.Drawing.Point(13, 280);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(471, 30);
            this.cbCiudad.TabIndex = 6;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefono.Location = new System.Drawing.Point(13, 194);
            this.mtbTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelefono.Mask = "(999)000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(184, 28);
            this.mtbTelefono.TabIndex = 7;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(396, 194);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCelular.Mask = "000-000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(155, 28);
            this.mtbCelular.TabIndex = 8;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(391, 163);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(69, 24);
            this.lbCelular.TabIndex = 9;
            this.lbCelular.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido";
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo.Location = new System.Drawing.Point(-3, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(762, 57);
            this.titulo.TabIndex = 18;
            this.titulo.Text = "Contacto";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txApellido
            // 
            this.txApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txApellido.Location = new System.Drawing.Point(396, 97);
            this.txApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txApellido.MaxLength = 40;
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(350, 28);
            this.txApellido.TabIndex = 13;
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.OliveDrab;
            this.Actualizar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.Actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Actualizar.BorderRadius = 15;
            this.Actualizar.BorderSize = 0;
            this.Actualizar.FlatAppearance.BorderSize = 0;
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.Color.White;
            this.Actualizar.Location = new System.Drawing.Point(2, 359);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(200, 49);
            this.Actualizar.TabIndex = 19;
            this.Actualizar.Text = "Actualizar Datos";
            this.Actualizar.TextColor = System.Drawing.Color.White;
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // RJAgregar
            // 
            this.RJAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.RJAgregar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.RJAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJAgregar.BorderRadius = 10;
            this.RJAgregar.BorderSize = 0;
            this.RJAgregar.FlatAppearance.BorderSize = 0;
            this.RJAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJAgregar.ForeColor = System.Drawing.Color.White;
            this.RJAgregar.Location = new System.Drawing.Point(568, 270);
            this.RJAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RJAgregar.Name = "RJAgregar";
            this.RJAgregar.Size = new System.Drawing.Size(178, 37);
            this.RJAgregar.TabIndex = 17;
            this.RJAgregar.Text = "Agregar";
            this.RJAgregar.TextColor = System.Drawing.Color.White;
            this.RJAgregar.UseVisualStyleBackColor = false;
            this.RJAgregar.Click += new System.EventHandler(this.RJAgregar_Click);
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
            this.RJCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJCancelar.ForeColor = System.Drawing.Color.White;
            this.RJCancelar.Location = new System.Drawing.Point(219, 359);
            this.RJCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RJCancelar.Name = "RJCancelar";
            this.RJCancelar.Size = new System.Drawing.Size(123, 48);
            this.RJCancelar.TabIndex = 16;
            this.RJCancelar.Text = "Cancelar";
            this.RJCancelar.TextColor = System.Drawing.Color.White;
            this.RJCancelar.UseVisualStyleBackColor = false;
            this.RJCancelar.Click += new System.EventHandler(this.RJCancelar_Click);
            // 
            // RJGuardar
            // 
            this.RJGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.RJGuardar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.RJGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RJGuardar.BorderRadius = 15;
            this.RJGuardar.BorderSize = 0;
            this.RJGuardar.FlatAppearance.BorderSize = 0;
            this.RJGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJGuardar.ForeColor = System.Drawing.Color.White;
            this.RJGuardar.Location = new System.Drawing.Point(12, 359);
            this.RJGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RJGuardar.Name = "RJGuardar";
            this.RJGuardar.Size = new System.Drawing.Size(123, 46);
            this.RJGuardar.TabIndex = 15;
            this.RJGuardar.Text = "Guardar";
            this.RJGuardar.TextColor = System.Drawing.Color.White;
            this.RJGuardar.UseVisualStyleBackColor = false;
            this.RJGuardar.Click += new System.EventHandler(this.RJGuardar_Click);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 414);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.RJAgregar);
            this.Controls.Add(this.RJCancelar);
            this.Controls.Add(this.RJGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txApellido);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContacto";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label label1;
        private RJControls.RJButton RJGuardar;
        private RJControls.RJButton RJCancelar;
        private RJControls.RJButton RJAgregar;
        private System.Windows.Forms.Label titulo;
        private RJControls.RJButton Actualizar;
        private System.Windows.Forms.TextBox txApellido;
    }
}