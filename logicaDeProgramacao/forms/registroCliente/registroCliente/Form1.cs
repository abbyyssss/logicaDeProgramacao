using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace registroCliente
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=registros;Uid=root;Password='';";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialização, se necessário
            // Preencher o ComboBox com as UFs, por exemplo:
            cmbUF.Items.AddRange(new string[]
            {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
                "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
                "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            });
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Coleta os dados do formulário
            string nome = txtNome.Text.Trim();
            string cpf = mskCPF.Text.Trim();
            string rg = mskRG.Text.Trim();
            string celular = mskCelular.Text.Trim();
            string dataNascimento = mskDataDeNascimento.Text.Trim();
            string ufNascimento = cmbUF.SelectedItem?.ToString(); // Coleta a UF

            string sexo = GetSexo();
            if (sexo == null)
            {
                MessageBox.Show("Selecione um sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) ||
                string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(dataNascimento) || string.IsNullOrEmpty(ufNascimento))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação da data de nascimento
            if (!DateTime.TryParse(dataNascimento, out DateTime parsedDate))
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nome, cpf, rg, celular, dataNascimento, sexo, uf_nascimento) " +
                                   "VALUES (@Nome, @CPF, @RG, @Celular, @DataNascimento, @Sexo, @UFnascimento)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@RG", rg);
                        cmd.Parameters.AddWithValue("@Celular", celular);
                        cmd.Parameters.AddWithValue("@DataNascimento", parsedDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Sexo", sexo);
                        cmd.Parameters.AddWithValue("@UFnascimento", ufNascimento); // Adiciona a UF

                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        // Verifica se o registro foi inserido com sucesso
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSexo()
        {
            if (rdbMasculino.Checked)
                return "M";
            if (rdbFeminino.Checked)
                return "F";
            if (rdbOutro.Checked)
                return "O"; // Valor para "Outro"
            return null; // Nenhuma opção selecionada
        }
    }
}
