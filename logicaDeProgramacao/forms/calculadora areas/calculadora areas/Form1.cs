namespace calculadora_areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTriangulo.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\kauan.mcvquaresma\Desktop\hoje\triangulo-5_xl.jpeg");
                lblFormula.Text = "b*h/2";
                lblf1.Text = " lado ";
                lblf2.Text = " altura ";
                btnb2.Visible = true;
                btnb1.Visible = true;
                btnb3.Visible = false;
                lblf3.Text = "";
                btnb1.Focus();
                // Reset form color
                this.BackColor = SystemColors.Control;
                lblFormula.ForeColor = SystemColors.ControlText;
                lblf1.ForeColor = SystemColors.ControlText;
                lblf2.ForeColor = SystemColors.ControlText;
                lblf3.ForeColor = SystemColors.ControlText;
            }
        }

        private void RadioQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioQuadrado.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\kauan.mcvquaresma\Desktop\hoje\quadrado.jfif");
                lblFormula.Text = "l²";
                lblf2.Text = " lado ";
                btnb2.Visible = true;
                lblf1.Text = "";
                lblf3.Text = "";
                btnb1.Visible = false;
                btnb3.Visible = false;
                btnb2.Focus();
                // Change form color to green
                this.BackColor = Color.Green;
                lblFormula.ForeColor = Color.White;
                lblf1.ForeColor = Color.White;
                lblf2.ForeColor = Color.White;
                lblf3.ForeColor = Color.White;
            }
        }

        private void RadioRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioRetangulo.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\kauan.mcvquaresma\Desktop\hoje\retangulo-roxo-claro.jpg");
                lblFormula.Text = "b*h";
                lblf3.Text = "";
                lblf1.Text = " base ";
                lblf2.Text = " altura ";
                btnb2.Visible = true;
                btnb1.Visible = true;
                btnb3.Visible = false;
                btnb1.Focus();
                // Reset form color
                this.BackColor = SystemColors.Control;
                lblFormula.ForeColor = SystemColors.ControlText;
                lblf1.ForeColor = SystemColors.ControlText;
                lblf2.ForeColor = SystemColors.ControlText;
                lblf3.ForeColor = SystemColors.ControlText;
            }
        }

        private void RadioCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCirculo.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\kauan.mcvquaresma\Desktop\hoje\250px-Circle_-_black_simple.svg.png");
                lblFormula.Text = "πr²";
                lblf1.Text = "";
                lblf3.Text = "";
                lblf2.Text = " raio ";
                btnb1.Visible = false;
                btnb2.Visible = true;
                btnb3.Visible = false;
                btnb2.Focus();
                // Reset form color
                this.BackColor = SystemColors.Control;
                lblFormula.ForeColor = SystemColors.ControlText;
                lblf1.ForeColor = SystemColors.ControlText;
                lblf2.ForeColor = SystemColors.ControlText;
                lblf3.ForeColor = SystemColors.ControlText;
            }
        }

        private void RadioTrapezio_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTrapezio.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\kauan.mcvquaresma\Desktop\hoje\download.png");
                lblFormula.Text = "((B+b)*h/2)";
                lblf1.Text = " base (B)";
                lblf2.Text = " base (b) ";
                lblf3.Text = " altura ";
                btnb2.Visible = true;
                btnb1.Visible = true;
                btnb3.Visible = true;
                btnb1.Focus();
                // Change form color to cyan blue
                this.BackColor = Color.Cyan;
                lblFormula.ForeColor = Color.Black;
                lblf1.ForeColor = Color.Black;
                lblf2.ForeColor = Color.Black;
                lblf3.ForeColor = Color.Black;
            }
        }

        private void lblFormula_Click(object sender, EventArgs e)
        {
            // Optional event handler for lblFormula click
        }

        private void btnfazer_Click(object sender, EventArgs e)
        {
            double lado1 = 0;
            double lado2 = 0;
            double lado3 = 0;
            double resultado;

            // Validação de entrada
            if (RadioTrapezio.Checked)
            {
                if (double.TryParse(btnb1.Text, out lado1) &&
                    double.TryParse(btnb2.Text, out lado2) &&
                    double.TryParse(btnb3.Text, out lado3))
                {
                    resultado = Math.Round((lado1 + lado2) * lado3 / 2, 2);
                    lblresult.Text = resultado.ToString();
                    lblexp.Text = $"(({lado1} + {lado2}) * {lado3}) / 2";
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores numéricos válidos.");
                }
            }
            else if (RadioTriangulo.Checked)
            {
                if (double.TryParse(btnb1.Text, out lado1) &&
                    double.TryParse(btnb2.Text, out lado2))
                {
                    resultado = Math.Round((lado1 * lado2) / 2, 2);
                    lblresult.Text = resultado.ToString();
                    lblexp.Text = $"{lado1} * {lado2} / 2";
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores numéricos válidos.");
                }
            }
            else if (RadioQuadrado.Checked)
            {
                if (double.TryParse(btnb2.Text, out lado1))
                {
                    resultado = Math.Round(lado1 * lado1, 2);
                    lblresult.Text = resultado.ToString();
                    lblexp.Text = $"{lado1}²";
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores numéricos válidos.");
                }
            }
            else if (RadioRetangulo.Checked)
            {
                if (double.TryParse(btnb1.Text, out lado1) &&
                    double.TryParse(btnb2.Text, out lado2))
                {
                    resultado = Math.Round(lado1 * lado2, 2);
                    lblresult.Text = resultado.ToString();
                    lblexp.Text = $"{lado1} * {lado2}";
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores numéricos válidos.");
                }
            }
            else if (RadioCirculo.Checked)
            {
                if (double.TryParse(btnb2.Text, out lado2))
                {
                    resultado = Math.Round(Math.PI * lado2 * lado2, 2);
                    lblresult.Text = resultado.ToString();
                    lblexp.Text = $"π * {lado2}²";
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores numéricos válidos.");
                }
            }

            // Limpar campos
            btnb1.Text = "";
            btnb2.Text = "";
            btnb3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlimpa_Click(object sender, EventArgs e)
        {
            // Desmarcar todos os RadioButtons
            RadioTriangulo.Checked = false;
            RadioQuadrado.Checked = false;
            RadioRetangulo.Checked = false;
            RadioCirculo.Checked = false;
            RadioTrapezio.Checked = false;

            // Limpar texto dos TextBoxes ou Labels
            btnb1.Text = "";
            btnb2.Text = "";
            btnb3.Text = "";

            // Restaurar texto dos Labels
            lblFormula.Text = "";
            lblf1.Text = "";
            lblf2.Text = "";
            lblf3.Text = "";
            lblresult.Text = "";
            lblexp.Text = "";

            // Ocultar ou mostrar botões conforme necessário
            btnb1.Visible = false;
            btnb2.Visible = false;
            btnb3.Visible = false;

            // resetar cores
            this.BackColor = SystemColors.Control;
            lblFormula.ForeColor = SystemColors.ControlText;
            lblf1.ForeColor = SystemColors.ControlText;
            lblf2.ForeColor = SystemColors.ControlText;
            lblf3.ForeColor = SystemColors.ControlText;
        }
    }
}