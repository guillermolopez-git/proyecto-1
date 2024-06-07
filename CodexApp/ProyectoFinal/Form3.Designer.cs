namespace ProyectoFinal
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.pais = new System.Windows.Forms.TextBox();
            this.Partidosjugados = new System.Windows.Forms.TextBox();
            this.partidosGanados = new System.Windows.Forms.TextBox();
            this.golesAnotados = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.diferanciaGoles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.golesContra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.partidosPerdidos = new System.Windows.Forms.TextBox();
            this.partidosEmpatados = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Totalgoles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(435, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 120);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(242, 26);
            this.nombre.TabIndex = 1;
            // 
            // pais
            // 
            this.pais.Location = new System.Drawing.Point(155, 159);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(242, 26);
            this.pais.TabIndex = 2;
            // 
            // Partidosjugados
            // 
            this.Partidosjugados.Location = new System.Drawing.Point(155, 266);
            this.Partidosjugados.Name = "Partidosjugados";
            this.Partidosjugados.Size = new System.Drawing.Size(242, 26);
            this.Partidosjugados.TabIndex = 3;
            // 
            // partidosGanados
            // 
            this.partidosGanados.Location = new System.Drawing.Point(555, 254);
            this.partidosGanados.Name = "partidosGanados";
            this.partidosGanados.Size = new System.Drawing.Size(242, 26);
            this.partidosGanados.TabIndex = 4;
            this.partidosGanados.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // golesAnotados
            // 
            this.golesAnotados.Location = new System.Drawing.Point(155, 317);
            this.golesAnotados.Name = "golesAnotados";
            this.golesAnotados.Size = new System.Drawing.Size(242, 26);
            this.golesAnotados.TabIndex = 5;
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(155, 212);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(242, 26);
            this.ciudad.TabIndex = 6;
            // 
            // diferanciaGoles
            // 
            this.diferanciaGoles.Location = new System.Drawing.Point(155, 360);
            this.diferanciaGoles.Name = "diferanciaGoles";
            this.diferanciaGoles.Size = new System.Drawing.Size(242, 26);
            this.diferanciaGoles.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(70, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(96, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(12, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Partidos jugados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(409, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "partidos ganados ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(13, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Goles anotados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(76, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "difrencia de goles ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // golesContra
            // 
            this.golesContra.Location = new System.Drawing.Point(555, 114);
            this.golesContra.Name = "golesContra";
            this.golesContra.Size = new System.Drawing.Size(242, 26);
            this.golesContra.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(414, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Goles encontara ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(409, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "partidos perdidos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label10.Location = new System.Drawing.Point(395, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "partidos empatados ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // partidosPerdidos
            // 
            this.partidosPerdidos.Location = new System.Drawing.Point(555, 159);
            this.partidosPerdidos.Name = "partidosPerdidos";
            this.partidosPerdidos.Size = new System.Drawing.Size(242, 26);
            this.partidosPerdidos.TabIndex = 19;
            // 
            // partidosEmpatados
            // 
            this.partidosEmpatados.Location = new System.Drawing.Point(555, 206);
            this.partidosEmpatados.Name = "partidosEmpatados";
            this.partidosEmpatados.Size = new System.Drawing.Size(242, 26);
            this.partidosEmpatados.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label11.Location = new System.Drawing.Point(409, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total de goles ";
            // 
            // Totalgoles
            // 
            this.Totalgoles.Location = new System.Drawing.Point(546, 311);
            this.Totalgoles.Name = "Totalgoles";
            this.Totalgoles.Size = new System.Drawing.Size(242, 26);
            this.Totalgoles.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(241, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 34);
            this.label12.TabIndex = 23;
            this.label12.Text = "Registro De equipos ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.premieLeague;
            this.pictureBox2.Location = new System.Drawing.Point(2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(795, 455);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Totalgoles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.partidosEmpatados);
            this.Controls.Add(this.partidosPerdidos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.golesContra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diferanciaGoles);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.golesAnotados);
            this.Controls.Add(this.partidosGanados);
            this.Controls.Add(this.Partidosjugados);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox pais;
        private System.Windows.Forms.TextBox Partidosjugados;
        private System.Windows.Forms.TextBox partidosGanados;
        private System.Windows.Forms.TextBox golesAnotados;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.TextBox diferanciaGoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox golesContra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox partidosPerdidos;
        private System.Windows.Forms.TextBox partidosEmpatados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Totalgoles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}