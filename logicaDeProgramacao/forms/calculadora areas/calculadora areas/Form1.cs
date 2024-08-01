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
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void lblFormula_Click(object sender, EventArgs e)
        {

        }

        private void btnfazer_Click(object sender, EventArgs e)
        {
            double ladoum = 0;
            double ladodois = 0;
            double seila = 0;
            double resultado;

            if (RadioTrapezio.Checked)
            {
                ladoum = double.Parse(btnb1.Text); // base maior
                ladodois = double.Parse(btnb2.Text); // base menor
                seila = double.Parse(btnb3.Text); // altura
                resultado = (ladoum + ladodois) * seila / 2;
                lblresult.Text = resultado.ToString();
                lblexp.Text = $"(({ladoum} + {ladodois}) * {seila}) / 2";
                btnb1.Focus();
            }
            else if (RadioTriangulo.Checked)
            {
                ladoum = double.Parse(btnb1.Text); // base
                ladodois = double.Parse(btnb2.Text); // altura
                resultado = (ladoum * ladodois) / 2;
                lblresult.Text = resultado.ToString();
                lblexp.Text = $"{ladoum} * {ladodois} / 2";
                btnb1.Focus();
            }
            else if (RadioQuadrado.Checked)
            {
                ladoum = double.Parse(btnb2.Text); // lado
                resultado = ladoum * ladoum;
                lblresult.Text = resultado.ToString();
                lblexp.Text = $"{ladoum}²";
                btnb2.Focus();
            }
            else if (RadioRetangulo.Checked)
            {
                ladoum = double.Parse(btnb1.Text); // base
                ladodois = double.Parse(btnb2.Text); // altura
                resultado = ladoum * ladodois;
                lblresult.Text = resultado.ToString();
                lblexp.Text = $"{ladoum} * {ladodois}";
                btnb1.Focus();
            }
            else if (RadioCirculo.Checked)
            {
                ladodois = double.Parse(btnb2.Text); // raio
                resultado = Math.PI * ladodois * ladodois;
                lblresult.Text = Math.Round(resultado, 2).ToString(); // Arredonda o resultado para 2 casas decimais
                lblexp.Text = $"π * {ladodois}²";
                btnb2.Focus();
            }
            btnb1.Text = "";
            btnb2.Text = "";
            btnb3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
