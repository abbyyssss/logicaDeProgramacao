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

            lblCalc.Text = "a area do quadrado � igual a: " + area + ", o perimetro � igual � " + perimetro;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}