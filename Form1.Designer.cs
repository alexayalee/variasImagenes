namespace variasImagenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            buttonPrimavera = new Button();
            buttonInvierno = new Button();
            buttonVerano = new Button();
            Nombre = new Label();
            buttonOtono = new Button();
            buttonSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.primavera;
            pictureBox1.Location = new Point(234, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonPrimavera
            // 
            buttonPrimavera.BackColor = Color.RosyBrown;
            buttonPrimavera.Location = new Point(161, 264);
            buttonPrimavera.Name = "buttonPrimavera";
            buttonPrimavera.Size = new Size(75, 23);
            buttonPrimavera.TabIndex = 1;
            buttonPrimavera.Text = "Primavera";
            buttonPrimavera.UseVisualStyleBackColor = false;
            buttonPrimavera.Click += button1_Click;
            // 
            // buttonInvierno
            // 
            buttonInvierno.BackColor = Color.RosyBrown;
            buttonInvierno.Location = new Point(522, 264);
            buttonInvierno.Name = "buttonInvierno";
            buttonInvierno.Size = new Size(75, 23);
            buttonInvierno.TabIndex = 2;
            buttonInvierno.Text = "Invierno";
            buttonInvierno.UseVisualStyleBackColor = false;
            buttonInvierno.Click += button2_Click;
            // 
            // buttonVerano
            // 
            buttonVerano.BackColor = Color.RosyBrown;
            buttonVerano.Location = new Point(282, 264);
            buttonVerano.Name = "buttonVerano";
            buttonVerano.Size = new Size(75, 23);
            buttonVerano.TabIndex = 3;
            buttonVerano.Text = "Verano";
            buttonVerano.UseVisualStyleBackColor = false;
            buttonVerano.Click += buttonVerano_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(522, 314);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(148, 15);
            Nombre.TabIndex = 4;
            Nombre.Text = "Alexa Yalee Sanchez Tejeda";
            // 
            // buttonOtono
            // 
            buttonOtono.BackColor = Color.RosyBrown;
            buttonOtono.Location = new Point(407, 264);
            buttonOtono.Name = "buttonOtono";
            buttonOtono.Size = new Size(75, 23);
            buttonOtono.TabIndex = 5;
            buttonOtono.Text = "Otoño";
            buttonOtono.UseVisualStyleBackColor = false;
            buttonOtono.Click += buttonOtono_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.RosyBrown;
            buttonSalir.Location = new Point(338, 310);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(buttonOtono);
            Controls.Add(Nombre);
            Controls.Add(buttonVerano);
            Controls.Add(buttonInvierno);
            Controls.Add(buttonPrimavera);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonPrimavera;
        private Button buttonInvierno;
        private Button buttonVerano;
        private Label Nombre;
        private Button buttonOtono;
        private Button buttonSalir;
    }
}
