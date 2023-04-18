namespace Grupo_Calculadora
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tareas = new Grupo_Calculadora.RJControls.RJButton();
            this.Reunion = new Grupo_Calculadora.RJControls.RJButton();
            this.contacto = new Grupo_Calculadora.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 87);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agenda Virtual ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Navy;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(827, 3);
            this.exit.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 36);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo_Calculadora.Properties.Resources.user_100px;
            this.pictureBox1.Location = new System.Drawing.Point(649, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 109);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario ";
            // 
            // Tareas
            // 
            this.Tareas.BackColor = System.Drawing.Color.Navy;
            this.Tareas.BackgroundColor = System.Drawing.Color.Navy;
            this.Tareas.BorderColor = System.Drawing.Color.Navy;
            this.Tareas.BorderRadius = 15;
            this.Tareas.BorderSize = 0;
            this.Tareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tareas.FlatAppearance.BorderSize = 0;
            this.Tareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tareas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tareas.ForeColor = System.Drawing.Color.White;
            this.Tareas.Image = global::Grupo_Calculadora.Properties.Resources.to_do_60px;
            this.Tareas.Location = new System.Drawing.Point(56, 379);
            this.Tareas.Name = "Tareas";
            this.Tareas.Size = new System.Drawing.Size(325, 87);
            this.Tareas.TabIndex = 6;
            this.Tareas.Text = "Tareas";
            this.Tareas.TextColor = System.Drawing.Color.White;
            this.Tareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tareas.UseVisualStyleBackColor = false;
            this.Tareas.Click += new System.EventHandler(this.Tareas_Click);
            // 
            // Reunion
            // 
            this.Reunion.BackColor = System.Drawing.Color.Navy;
            this.Reunion.BackgroundColor = System.Drawing.Color.Navy;
            this.Reunion.BorderColor = System.Drawing.Color.Navy;
            this.Reunion.BorderRadius = 15;
            this.Reunion.BorderSize = 0;
            this.Reunion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reunion.FlatAppearance.BorderSize = 0;
            this.Reunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reunion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reunion.ForeColor = System.Drawing.Color.White;
            this.Reunion.Image = global::Grupo_Calculadora.Properties.Resources.icons8_línea_de_tiempo_semana_60;
            this.Reunion.Location = new System.Drawing.Point(56, 274);
            this.Reunion.Name = "Reunion";
            this.Reunion.Size = new System.Drawing.Size(325, 87);
            this.Reunion.TabIndex = 5;
            this.Reunion.Text = "Reuniones";
            this.Reunion.TextColor = System.Drawing.Color.White;
            this.Reunion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reunion.UseVisualStyleBackColor = false;
            this.Reunion.Click += new System.EventHandler(this.Reunion_Click);
            // 
            // contacto
            // 
            this.contacto.BackColor = System.Drawing.Color.Navy;
            this.contacto.BackgroundColor = System.Drawing.Color.Navy;
            this.contacto.BorderColor = System.Drawing.Color.Navy;
            this.contacto.BorderRadius = 15;
            this.contacto.BorderSize = 0;
            this.contacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contacto.FlatAppearance.BorderSize = 0;
            this.contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contacto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto.ForeColor = System.Drawing.Color.White;
            this.contacto.Image = global::Grupo_Calculadora.Properties.Resources.icons8_contactos_60__1_;
            this.contacto.Location = new System.Drawing.Point(56, 167);
            this.contacto.Name = "contacto";
            this.contacto.Size = new System.Drawing.Size(325, 87);
            this.contacto.TabIndex = 2;
            this.contacto.Text = " Contactos";
            this.contacto.TextColor = System.Drawing.Color.White;
            this.contacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contacto.UseVisualStyleBackColor = false;
            this.contacto.Click += new System.EventHandler(this.contacto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tareas);
            this.Controls.Add(this.Reunion);
            this.Controls.Add(this.contacto);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(867, 539);
            this.MinimumSize = new System.Drawing.Size(867, 539);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private RJControls.RJButton contacto;
        private RJControls.RJButton Reunion;
        private RJControls.RJButton Tareas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}