namespace ex2forms
{
    partial class frmDollar
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
            btnConvertDol = new Button();
            lblValorDolar = new Label();
            txtLeitorReal = new TextBox();
            lblPreco = new Label();
            lblNomeProduto = new Label();
            lblCotaDol = new Label();
            txtNomeProduto = new TextBox();
            txtCotacao = new TextBox();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnConvertDol
            // 
            btnConvertDol.Location = new Point(465, 298);
            btnConvertDol.Name = "btnConvertDol";
            btnConvertDol.Size = new Size(263, 106);
            btnConvertDol.TabIndex = 0;
            btnConvertDol.Text = "&Converter";
            btnConvertDol.UseVisualStyleBackColor = true;
            btnConvertDol.Click += button1_Click;
            // 
            // lblValorDolar
            // 
            lblValorDolar.AutoSize = true;
            lblValorDolar.Location = new Point(123, 190);
            lblValorDolar.Name = "lblValorDolar";
            lblValorDolar.Size = new Size(129, 15);
            lblValorDolar.TabIndex = 1;
            lblValorDolar.Text = "digite o valor em dólar:";
            lblValorDolar.Click += label1_Click;
            // 
            // txtLeitorReal
            // 
            txtLeitorReal.Location = new Point(250, 187);
            txtLeitorReal.Name = "txtLeitorReal";
            txtLeitorReal.Size = new Size(263, 23);
            txtLeitorReal.TabIndex = 2;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(123, 247);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(169, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "o preço em real aparecerá aqui";
            lblPreco.Click += label1_Click_1;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(94, 101);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(150, 15);
            lblNomeProduto.TabIndex = 4;
            lblNomeProduto.Text = "digite o nome do produto :";
            lblNomeProduto.Click += label1_Click_2;
            // 
            // lblCotaDol
            // 
            lblCotaDol.AutoSize = true;
            lblCotaDol.Location = new Point(103, 143);
            lblCotaDol.Name = "lblCotaDol";
            lblCotaDol.Size = new Size(141, 15);
            lblCotaDol.TabIndex = 5;
            lblCotaDol.Text = "digite a cotação do dólar:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(250, 98);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(263, 23);
            txtNomeProduto.TabIndex = 6;
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(250, 140);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(263, 23);
            txtCotacao.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(58, 298);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(263, 106);
            btnSair.TabIndex = 8;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmDollar
            // 
            AcceptButton = btnConvertDol;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btnSair;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(txtCotacao);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblCotaDol);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblPreco);
            Controls.Add(txtLeitorReal);
            Controls.Add(lblValorDolar);
            Controls.Add(btnConvertDol);
            Name = "frmDollar";
            Text = "calculadora de valor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertDol;
        private Label lblValorDolar;
        private TextBox txtLeitorReal;
        private Label lblPreco;
        private Label lblNomeProduto;
        private Label lblCotaDol;
        private TextBox txtNomeProduto;
        private TextBox txtCotacao;
        private Button btnSair;
    }
}