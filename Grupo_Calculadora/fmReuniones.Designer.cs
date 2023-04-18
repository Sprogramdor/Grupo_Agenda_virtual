namespace Grupo_Calculadora
{
    partial class fmReuniones
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
            this.dateP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.asuntotext = new System.Windows.Forms.TextBox();
            this.horaBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minutoBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.participantes = new System.Windows.Forms.ComboBox();
            this.guardarR = new Grupo_Calculadora.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateP
            // 
            this.dateP.Location = new System.Drawing.Point(26, 229);
            this.dateP.Name = "dateP";
            this.dateP.Size = new System.Drawing.Size(200, 20);
            this.dateP.TabIndex = 0;
            this.dateP.ValueChanged += new System.EventHandler(this.dateP_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asunto de la Reunión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.CLOSE);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 49);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Coral;
            this.CLOSE.FlatAppearance.BorderSize = 0;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLOSE.Location = new System.Drawing.Point(698, 4);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(40, 42);
            this.CLOSE.TabIndex = 0;
            this.CLOSE.Text = "X";
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de la Reunión";
            // 
            // asuntotext
            // 
            this.asuntotext.Location = new System.Drawing.Point(26, 123);
            this.asuntotext.MaxLength = 35;
            this.asuntotext.Name = "asuntotext";
            this.asuntotext.Size = new System.Drawing.Size(285, 20);
            this.asuntotext.TabIndex = 4;
            // 
            // horaBox
            // 
            this.horaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horaBox.FormattingEnabled = true;
            this.horaBox.Location = new System.Drawing.Point(475, 237);
            this.horaBox.Name = "horaBox";
            this.horaBox.Size = new System.Drawing.Size(49, 21);
            this.horaBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duración de la Reunión";
            // 
            // minutoBox
            // 
            this.minutoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutoBox.FormattingEnabled = true;
            this.minutoBox.Location = new System.Drawing.Point(580, 237);
            this.minutoBox.Name = "minutoBox";
            this.minutoBox.Size = new System.Drawing.Size(49, 21);
            this.minutoBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Minutos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de Participantes";
            // 
            // participantes
            // 
            this.participantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.participantes.FormattingEnabled = true;
            this.participantes.Location = new System.Drawing.Point(431, 122);
            this.participantes.Name = "participantes";
            this.participantes.Size = new System.Drawing.Size(137, 21);
            this.participantes.TabIndex = 14;
            // 
            // guardarR
            // 
            this.guardarR.BackColor = System.Drawing.Color.DarkOrange;
            this.guardarR.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.guardarR.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.guardarR.BorderRadius = 15;
            this.guardarR.BorderSize = 0;
            this.guardarR.FlatAppearance.BorderSize = 0;
            this.guardarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarR.ForeColor = System.Drawing.Color.Black;
            this.guardarR.Location = new System.Drawing.Point(295, 326);
            this.guardarR.Name = "guardarR";
            this.guardarR.Size = new System.Drawing.Size(99, 40);
            this.guardarR.TabIndex = 10;
            this.guardarR.Text = "Guardar ";
            this.guardarR.TextColor = System.Drawing.Color.Black;
            this.guardarR.UseVisualStyleBackColor = false;
            this.guardarR.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // fmReuniones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 394);
            this.Controls.Add(this.participantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guardarR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horaBox);
            this.Controls.Add(this.asuntotext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmReuniones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmReuniones_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox asuntotext;
        private System.Windows.Forms.ComboBox horaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox minutoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJControls.RJButton guardarR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox participantes;
        private System.Windows.Forms.Button CLOSE;
    }
}