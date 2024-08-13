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
                        lblResultado.Text = "O tri�ngulo � Equil�tero.";
                        pictureBox1.Image = Properties.Resources.equilatero;
                    }
                    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                    {
                        lblResultado.Text = "O tri�ngulo � Is�sceles.";
                        pictureBox1.Image = Properties.Resources.is�celes;
                    }
                    else
                    {
                        lblResultado.Text = "O tri�ngulo � Escaleno.";
                        pictureBox1.Image = Properties.Resources.escaleno;
                    }
                }
                else
                {
                    lblResultado.Text = "Os valores informados n�o formam um tri�ngulo.";
                    pictureBox1.Image = Properties.Resources.Erro;
                }
            }
            else
            {
                lblResultado.Text = "Por favor, insira valores v�lidos.";
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

            // Limpa o r�tulo de resultado
            lblResultado.Text = "";

            // Limpa a imagem no PictureBox
            pictureBox1.Image = null;
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}