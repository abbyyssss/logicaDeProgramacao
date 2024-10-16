﻿namespace registroCliente
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
            label1 = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            CPF = new Label();
            label2 = new Label();
            mskRG = new MaskedTextBox();
            label3 = new Label();
            mskCelular = new MaskedTextBox();
            label4 = new Label();
            mskDataDeNascimento = new MaskedTextBox();
            label5 = new Label();
            rdbMasculino = new RadioButton();
            rdbFeminino = new RadioButton();
            rdbOutro = new RadioButton();
            btnCadastrar = new Button();
            label6 = new Label();
            cmbUF = new ComboBox();
            btnExcluirTodos = new Button();
            btnExcluirCliente = new Button();
            txtCodigoCliente = new TextBox();
            label7 = new Label();
            btnBuscar = new Button();
            dataGridViewClientes = new DataGridView();
            btnCarregar = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 7);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(55, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(386, 23);
            txtNome.TabIndex = 1;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(55, 36);
            mskCPF.Mask = "999,999,999-99";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(100, 23);
            mskCPF.TabIndex = 2;
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(12, 39);
            CPF.Name = "CPF";
            CPF.Size = new Size(28, 15);
            CPF.TabIndex = 3;
            CPF.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 5;
            label2.Text = "RG";
            // 
            // mskRG
            // 
            mskRG.Location = new Point(55, 72);
            mskRG.Mask = "99,999,999-9";
            mskRG.Name = "mskRG";
            mskRG.Size = new Size(100, 23);
            mskRG.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 9);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 7;
            label3.Text = "CLL";
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(480, 4);
            mskCelular.Mask = "(99) 99999-9999";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(100, 23);
            mskCelular.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "nascimento";
            // 
            // mskDataDeNascimento
            // 
            mskDataDeNascimento.Location = new Point(87, 249);
            mskDataDeNascimento.Mask = "99/99/9999";
            mskDataDeNascimento.Name = "mskDataDeNascimento";
            mskDataDeNascimento.Size = new Size(100, 23);
            mskDataDeNascimento.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 281);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "sexo";
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(217, 279);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 11;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(136, 279);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 12;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbOutro
            // 
            rdbOutro.AutoSize = true;
            rdbOutro.Location = new Point(74, 279);
            rdbOutro.Name = "rdbOutro";
            rdbOutro.Size = new Size(56, 19);
            rdbOutro.TabIndex = 13;
            rdbOutro.TabStop = true;
            rdbOutro.Text = "Outro";
            rdbOutro.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(209, 310);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(294, 99);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 39);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 15;
            label6.Text = "uf nascimento";
            // 
            // cmbUF
            // 
            cmbUF.FormattingEnabled = true;
            cmbUF.Location = new Point(308, 36);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(121, 23);
            cmbUF.TabIndex = 16;
            // 
            // btnExcluirTodos
            // 
            btnExcluirTodos.Location = new Point(509, 310);
            btnExcluirTodos.Name = "btnExcluirTodos";
            btnExcluirTodos.Size = new Size(193, 99);
            btnExcluirTodos.TabIndex = 17;
            btnExcluirTodos.Text = "excluir todos";
            btnExcluirTodos.UseVisualStyleBackColor = true;
            btnExcluirTodos.Click += btnExcluirTodos_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(11, 310);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(192, 99);
            btnExcluirCliente.TabIndex = 18;
            btnExcluirCliente.Text = "excluir cliente";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(111, 125);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(100, 23);
            txtCodigoCliente.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 128);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 20;
            label7.Text = "código do cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(708, 310);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(163, 99);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(524, 36);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(336, 150);
            dataGridViewClientes.TabIndex = 22;
            dataGridViewClientes.Visible = false;
            dataGridViewClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(524, 192);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(257, 46);
            btnCarregar.TabIndex = 23;
            btnCarregar.Text = "Load Data";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(784, 205);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(87, 99);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.Text = "atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 407);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCarregar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(txtCodigoCliente);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnExcluirTodos);
            Controls.Add(cmbUF);
            Controls.Add(label6);
            Controls.Add(btnCadastrar);
            Controls.Add(rdbOutro);
            Controls.Add(rdbFeminino);
            Controls.Add(rdbMasculino);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mskDataDeNascimento);
            Controls.Add(label3);
            Controls.Add(mskCelular);
            Controls.Add(label2);
            Controls.Add(mskRG);
            Controls.Add(CPF);
            Controls.Add(mskCPF);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private Label CPF;
        private Label label2;
        private MaskedTextBox mskRG;
        private Label label3;
        private MaskedTextBox mskCelular;
        private Label label4;
        private MaskedTextBox mskDataDeNascimento;
        private Label label5;
        private RadioButton rdbMasculino;
        private RadioButton rdbFeminino;
        private RadioButton rdbOutro;
        private Button btnCadastrar;
        private Label label6;
        private ComboBox cmbUF;
        private Button btnExcluirTodos;
        private Button btnExcluirCliente;
        private TextBox txtCodigoCliente;
        private Label label7;
        private Button btnBuscar;
        private DataGridView dataGridViewClientes;
        private Button btnCarregar;
        private Button btnAtualizar;
    }
}