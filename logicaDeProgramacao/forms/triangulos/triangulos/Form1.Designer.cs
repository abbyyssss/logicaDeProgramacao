namespace triangulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnsair = new Button();
            btnCalc = new Button();
            pictureBox1 = new PictureBox();
            lblLadoA = new Label();
            lblLadoB = new Label();
            lblLadoC = new Label();
            txtLadoC = new TextBox();
            txtLadoB = new TextBox();
            txtLadoA = new TextBox();
            lblResultado = new Label();
            btnLimpar = new Button();
            lblsuperficial = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnsair
            // 
            btnsair.Image = (Image)resources.GetObject("btnsair.Image");
            btnsair.Location = new Point(25, 487);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(152, 117);
            btnsair.TabIndex = 0;
            btnsair.Text = "&Sair";
            btnsair.TextAlign = ContentAlignment.TopCenter;
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // btnCalc
            // 
            btnCalc.Image = (Image)resources.GetObject("btnCalc.Image");
            btnCalc.Location = new Point(506, 487);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(152, 117);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "&Calcular";
            btnCalc.TextAlign = ContentAlignment.TopCenter;
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(399, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(37, 107);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(44, 15);
            lblLadoA.TabIndex = 3;
            lblLadoA.Text = "lado A:";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(38, 188);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(43, 15);
            lblLadoB.TabIndex = 4;
            lblLadoB.Text = "lado B:";
            // 
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Location = new Point(37, 285);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(44, 15);
            lblLadoC.TabIndex = 5;
            lblLadoC.Text = "lado C:";
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(87, 282);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(100, 23);
            txtLadoC.TabIndex = 6;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(87, 185);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(100, 23);
            txtLadoB.TabIndex = 7;
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(87, 104);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(100, 23);
            txtLadoA.TabIndex = 8;
            txtLadoA.Text = "5";
            txtLadoA.TextChanged += txtLadoA_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(408, 290);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 9;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(266, 487);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(152, 117);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "&Limpar";
            btnLimpar.TextAlign = ContentAlignment.TopCenter;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblsuperficial
            // 
            lblsuperficial.AutoSize = true;
            lblsuperficial.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsuperficial.Location = new Point(475, 9);
            lblsuperficial.Name = "lblsuperficial";
            lblsuperficial.Size = new Size(118, 20);
            lblsuperficial.TabIndex = 11;
            lblsuperficial.Text = "TRIÂNGULOS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btnCalc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnsair;
            ClientSize = new Size(709, 646);
            Controls.Add(pictureBox2);
            Controls.Add(lblsuperficial);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(txtLadoA);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoC);
            Controls.Add(lblLadoC);
            Controls.Add(lblLadoB);
            Controls.Add(lblLadoA);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalc);
            Controls.Add(btnsair);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsair;
        private Button btnCalc;
        private PictureBox pictureBox1;
        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblLadoC;
        private TextBox txtLadoC;
        private TextBox txtLadoB;
        private TextBox txtLadoA;
        private Label lblResultado;
        private Button btnLimpar;
        private Label lblsuperficial;
        private PictureBox pictureBox2;
    }
}