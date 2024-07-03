namespace ex1
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lados;
            double area;
            double perimetro;

            lados = double.Parse(txtQuadrado.Text);

            area = lados * lados;

            perimetro = lados * 4;

            lblCalc.Text = "a area do quadrado é igual a: " + area + ", o perimetro é igual à " + perimetro;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}