namespace ex1
{
    partial class frmForm
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
            lblLado = new Label();
            txtQuadrado = new TextBox();
            btnFechar = new Button();
            btnCalcular = new Button();
            lblCalc = new Label();
            SuspendLayout();
            // 
            // lblLado
            // 
            lblLado.AutoSize = true;
            lblLado.Location = new Point(61, 87);
            lblLado.Name = "lblLado";
            lblLado.Size = new Size(145, 15);
            lblLado.TabIndex = 0;
            lblLado.Text = "Digite o lado do quadrado";
            // 
            // txtQuadrado
            // 
            txtQuadrado.Location = new Point(212, 84);
            txtQuadrado.Name = "txtQuadrado";
            txtQuadrado.Size = new Size(165, 23);
            txtQuadrado.TabIndex = 1;
            txtQuadrado.TextChanged += textBox1_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(61, 243);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(107, 70);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(271, 243);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(106, 70);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCalc
            // 
            lblCalc.AutoSize = true;
            lblCalc.Location = new Point(61, 162);
            lblCalc.Name = "lblCalc";
            lblCalc.Size = new Size(237, 15);
            lblCalc.TabIndex = 4;
            lblCalc.Text = "o cálculo do seu quadrado irá aparecer aqui";
            // 
            // frmForm
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFechar;
            ClientSize = new Size(429, 389);
            Controls.Add(lblCalc);
            Controls.Add(btnCalcular);
            Controls.Add(btnFechar);
            Controls.Add(txtQuadrado);
            Controls.Add(lblLado);
            Name = "frmForm";
            Text = "projeto calc quadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLado;
        private TextBox txtQuadrado;
        private Button btnFechar;
        private Button btnCalcular;
        private Label lblCalc;
    }
}