namespace calculadora_areas
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
            lblinicio = new Label();
            RadioQuadrado = new RadioButton();
            RadioTriangulo = new RadioButton();
            RadioRetangulo = new RadioButton();
            RadioCirculo = new RadioButton();
            RadioTrapezio = new RadioButton();
            lblPergunta = new Label();
            pictureBox1 = new PictureBox();
            lblFormula = new Label();
            lblsla = new Label();
            btnlimpa = new Button();
            btnfazer = new Button();
            btnb1 = new TextBox();
            btnb2 = new TextBox();
            btnb3 = new TextBox();
            lblf1 = new Label();
            lblf2 = new Label();
            lblf3 = new Label();
            lblex = new Label();
            lblex2 = new Label();
            lblexp = new Label();
            lblresult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblinicio
            // 
            lblinicio.AutoSize = true;
            lblinicio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblinicio.Location = new Point(12, 9);
            lblinicio.Name = "lblinicio";
            lblinicio.Size = new Size(270, 30);
            lblinicio.TabIndex = 0;
            lblinicio.Text = "CALCULADORA DE ÁREAS";
            // 
            // RadioQuadrado
            // 
            RadioQuadrado.AutoSize = true;
            RadioQuadrado.Location = new Point(20, 94);
            RadioQuadrado.Name = "RadioQuadrado";
            RadioQuadrado.Size = new Size(78, 19);
            RadioQuadrado.TabIndex = 1;
            RadioQuadrado.TabStop = true;
            RadioQuadrado.Text = "Quadrado";
            RadioQuadrado.UseVisualStyleBackColor = true;
            RadioQuadrado.CheckedChanged += RadioQuadrado_CheckedChanged;
            // 
            // RadioTriangulo
            // 
            RadioTriangulo.AutoSize = true;
            RadioTriangulo.Location = new Point(20, 129);
            RadioTriangulo.Name = "RadioTriangulo";
            RadioTriangulo.Size = new Size(73, 19);
            RadioTriangulo.TabIndex = 2;
            RadioTriangulo.TabStop = true;
            RadioTriangulo.Text = "triângulo";
            RadioTriangulo.UseVisualStyleBackColor = true;
            RadioTriangulo.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // RadioRetangulo
            // 
            RadioRetangulo.AutoSize = true;
            RadioRetangulo.Location = new Point(19, 164);
            RadioRetangulo.Name = "RadioRetangulo";
            RadioRetangulo.Size = new Size(79, 19);
            RadioRetangulo.TabIndex = 3;
            RadioRetangulo.TabStop = true;
            RadioRetangulo.Text = "Retângulo";
            RadioRetangulo.UseVisualStyleBackColor = true;
            RadioRetangulo.CheckedChanged += RadioRetangulo_CheckedChanged;
            // 
            // RadioCirculo
            // 
            RadioCirculo.AutoSize = true;
            RadioCirculo.Location = new Point(20, 201);
            RadioCirculo.Name = "RadioCirculo";
            RadioCirculo.Size = new Size(63, 19);
            RadioCirculo.TabIndex = 4;
            RadioCirculo.TabStop = true;
            RadioCirculo.Text = "Circulo";
            RadioCirculo.UseVisualStyleBackColor = true;
            RadioCirculo.CheckedChanged += RadioCirculo_CheckedChanged;
            // 
            // RadioTrapezio
            // 
            RadioTrapezio.AutoSize = true;
            RadioTrapezio.Location = new Point(20, 241);
            RadioTrapezio.Name = "RadioTrapezio";
            RadioTrapezio.Size = new Size(68, 19);
            RadioTrapezio.TabIndex = 5;
            RadioTrapezio.TabStop = true;
            RadioTrapezio.Text = "Trapézio";
            RadioTrapezio.UseVisualStyleBackColor = true;
            RadioTrapezio.CheckedChanged += RadioTrapezio_CheckedChanged;
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Location = new Point(19, 39);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(168, 15);
            lblPergunta.TabIndex = 6;
            lblPergunta.Text = "qual área você deseja calcular?\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(246, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Location = new Point(337, 277);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(0, 15);
            lblFormula.TabIndex = 8;
            lblFormula.Click += lblFormula_Click;
            // 
            // lblsla
            // 
            lblsla.AutoSize = true;
            lblsla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsla.Location = new Point(242, 272);
            lblsla.Name = "lblsla";
            lblsla.Size = new Size(90, 21);
            lblsla.TabIndex = 9;
            lblsla.Text = "FÓRMULA:";
            // 
            // btnlimpa
            // 
            btnlimpa.Location = new Point(31, 513);
            btnlimpa.Name = "btnlimpa";
            btnlimpa.Size = new Size(97, 42);
            btnlimpa.TabIndex = 10;
            btnlimpa.Text = "limpa";
            btnlimpa.UseVisualStyleBackColor = true;
            // 
            // btnfazer
            // 
            btnfazer.Location = new Point(352, 513);
            btnfazer.Name = "btnfazer";
            btnfazer.Size = new Size(98, 42);
            btnfazer.TabIndex = 11;
            btnfazer.Text = "resolver";
            btnfazer.UseVisualStyleBackColor = true;
            btnfazer.Click += btnfazer_Click;
            // 
            // btnb1
            // 
            btnb1.Location = new Point(31, 369);
            btnb1.Name = "btnb1";
            btnb1.Size = new Size(100, 23);
            btnb1.TabIndex = 12;
            btnb1.Visible = false;
            // 
            // btnb2
            // 
            btnb2.Location = new Point(195, 369);
            btnb2.Name = "btnb2";
            btnb2.Size = new Size(100, 23);
            btnb2.TabIndex = 13;
            // 
            // btnb3
            // 
            btnb3.Location = new Point(350, 369);
            btnb3.Name = "btnb3";
            btnb3.Size = new Size(100, 23);
            btnb3.TabIndex = 14;
            btnb3.Visible = false;
            // 
            // lblf1
            // 
            lblf1.AutoSize = true;
            lblf1.Location = new Point(60, 340);
            lblf1.Name = "lblf1";
            lblf1.Size = new Size(0, 15);
            lblf1.TabIndex = 15;
            // 
            // lblf2
            // 
            lblf2.AutoSize = true;
            lblf2.Location = new Point(226, 340);
            lblf2.Name = "lblf2";
            lblf2.Size = new Size(0, 15);
            lblf2.TabIndex = 16;
            // 
            // lblf3
            // 
            lblf3.AutoSize = true;
            lblf3.Location = new Point(386, 340);
            lblf3.Name = "lblf3";
            lblf3.Size = new Size(0, 15);
            lblf3.TabIndex = 17;
            // 
            // lblex
            // 
            lblex.AutoSize = true;
            lblex.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblex.Location = new Point(42, 419);
            lblex.Name = "lblex";
            lblex.Size = new Size(86, 21);
            lblex.TabIndex = 18;
            lblex.Text = "expressão";
            // 
            // lblex2
            // 
            lblex2.AutoSize = true;
            lblex2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblex2.Location = new Point(370, 419);
            lblex2.Name = "lblex2";
            lblex2.Size = new Size(82, 21);
            lblex2.TabIndex = 19;
            lblex2.Text = "resultado";
            // 
            // lblexp
            // 
            lblexp.AutoSize = true;
            lblexp.Location = new Point(60, 459);
            lblexp.Name = "lblexp";
            lblexp.Size = new Size(0, 15);
            lblexp.TabIndex = 20;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(398, 459);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 15);
            lblresult.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 567);
            Controls.Add(lblresult);
            Controls.Add(lblexp);
            Controls.Add(lblex2);
            Controls.Add(lblex);
            Controls.Add(lblf3);
            Controls.Add(lblf2);
            Controls.Add(lblf1);
            Controls.Add(btnb3);
            Controls.Add(btnb2);
            Controls.Add(btnb1);
            Controls.Add(btnfazer);
            Controls.Add(btnlimpa);
            Controls.Add(lblsla);
            Controls.Add(lblFormula);
            Controls.Add(pictureBox1);
            Controls.Add(lblPergunta);
            Controls.Add(RadioTrapezio);
            Controls.Add(RadioCirculo);
            Controls.Add(RadioRetangulo);
            Controls.Add(RadioTriangulo);
            Controls.Add(RadioQuadrado);
            Controls.Add(lblinicio);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblinicio;
        private RadioButton RadioQuadrado;
        private RadioButton RadioTriangulo;
        private RadioButton RadioRetangulo;
        private RadioButton RadioCirculo;
        private RadioButton RadioTrapezio;
        private Label lblPergunta;
        private PictureBox pictureBox1;
        private Label lblFormula;
        private Label lblsla;
        private Button btnlimpa;
        private Button btnfazer;
        private TextBox btnb1;
        private TextBox btnb2;
        private TextBox btnb3;
        private Label lblf1;
        private Label lblf2;
        private Label lblf3;
        private Label lblex;
        private Label lblex2;
        private Label lblexp;
        private Label lblresult;
    }
}