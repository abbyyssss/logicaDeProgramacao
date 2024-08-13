namespace triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if (double.TryParse(txtLadoA.Text, out ladoA) &&
                double.TryParse(txtLadoB.Text, out ladoB) &&
                double.TryParse(txtLadoC.Text, out ladoC))
            {
                if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
                {
                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        lblResultado.Text = "O triângulo é Equilátero.";
                        pictureBox1.Image = Properties.Resources.equilatero;
                    }
                    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                    {
                        lblResultado.Text = "O triângulo é Isósceles.";
                        pictureBox1.Image = Properties.Resources.isóceles;
                    }
                    else
                    {
                        lblResultado.Text = "O triângulo é Escaleno.";
                        pictureBox1.Image = Properties.Resources.escaleno;
                    }
                }
                else
                {
                    lblResultado.Text = "Os valores informados não formam um triângulo.";
                    pictureBox1.Image = Properties.Resources.Erro;
                }
            }
            else
            {
                lblResultado.Text = "Por favor, insira valores válidos.";
                pictureBox1.Image = Properties.Resources.Erro;
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();

            // Limpa o rótulo de resultado
            lblResultado.Text = "";

            // Limpa a imagem no PictureBox
            pictureBox1.Image = null;
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}