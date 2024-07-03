namespace ex2forms
{
    public partial class frmDollar : Form
    {
        public frmDollar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(816, 489);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produto;
            double LeitorDolar;
            double Cotacao;
            double Valorfinal;

            produto = txtNomeProduto.Text;

            LeitorDolar = double.Parse(txtLeitorReal.Text);
            Cotacao = double.Parse(txtCotacao.Text);

            Valorfinal = LeitorDolar * Cotacao;

            string valorFormatado = string.Format("{0:C}", Valorfinal);
            lblPreco.Text = "seu produto:" + produto + " com o preço convertido para real é : R$" + valorFormatado;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}