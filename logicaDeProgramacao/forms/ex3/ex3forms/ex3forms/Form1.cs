namespace ex3forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");

            lblData.Text = $"Data atual = {dataAtual}";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}