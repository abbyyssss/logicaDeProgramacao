namespace ex3forms
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
            lblData = new Label();
            btnOk = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(285, 117);
            lblData.Name = "lblData";
            lblData.Size = new Size(171, 15);
            lblData.TabIndex = 0;
            lblData.Text = "a data de hoje irá aparecer aqui";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(472, 268);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(246, 108);
            btnOk.TabIndex = 1;
            btnOk.Text = "&Data";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button1_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(80, 268);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(246, 108);
            btnSair.TabIndex = 2;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnOk);
            Controls.Add(lblData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private Button btnOk;
        private Button btnSair;
    }
}