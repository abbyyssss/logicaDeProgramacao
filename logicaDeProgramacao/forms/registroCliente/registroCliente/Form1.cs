using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace registroCliente
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=registros;Uid=root;Password='';";
        private const string Password = "1234"; // senha

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUF.Items.AddRange(new string[] {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
                "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
                "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            });
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = mskCPF.Text.Trim();
            string rg = mskRG.Text.Trim();
            string celular = mskCelular.Text.Trim();
            string dataNascimento = mskDataDeNascimento.Text.Trim();
            string ufNascimento = cmbUF.SelectedItem?.ToString();

            string sexo = GetSexo();
            if (sexo == null)
            {
                MessageBox.Show("Selecione um sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) ||
                string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(dataNascimento) || string.IsNullOrEmpty(ufNascimento))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(dataNascimento, out DateTime parsedDate))
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        cmd.Parameters.AddWithValue("@UFnascimento", ufNascimento);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
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

        private void LimparCampos()
        {
            txtNome.Clear();
            mskCPF.Clear();
            mskRG.Clear();
            mskCelular.Clear();
            mskDataDeNascimento.Clear();
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            rdbOutro.Checked = false;
            cmbUF.SelectedItem = null;
        }

        private string GetSexo()
        {
            if (rdbMasculino.Checked) return "M";
            if (rdbFeminino.Checked) return "F";
            if (rdbOutro.Checked) return "O";
            return null;
        }

        private bool senha()
        {
            using (Form passwordForm = new Form())
            {
                TextBox txtPassword = new TextBox() { PasswordChar = '*', Top = 20, Left = 20, Width = 200 };
                Button btnOk = new Button() { Text = "OK", Top = 50, Left = 20, DialogResult = DialogResult.OK };
                passwordForm.Controls.Add(txtPassword);
                passwordForm.Controls.Add(btnOk);
                passwordForm.AcceptButton = btnOk;

                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    return txtPassword.Text == Password;
                }
            }
            return false;
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (senha())
            {
                string codigoCliente = txtCodigoCliente.Text.Trim();

                if (string.IsNullOrEmpty(codigoCliente))
                {
                    MessageBox.Show("Por favor, informe o código do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM clientes WHERE Cliente = @Cliente";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Cliente", codigoCliente);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum cliente encontrado com esse código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            if (senha())
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM clientes";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            int result = cmd.ExecuteNonQuery();
                            MessageBox.Show($"{result} cliente(s) excluído(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (senha())
            {
                string codigoCliente = txtCodigoCliente.Text.Trim();
                string cpf = mskCPF.Text.Trim();

                if (string.IsNullOrEmpty(codigoCliente) && string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Por favor, informe o código do cliente ou CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT nome, cpf, rg, celular, dataNascimento, sexo, uf_nascimento FROM clientes " +
                                       "WHERE Cliente = @Cliente OR cpf = @CPF";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Cliente", string.IsNullOrEmpty(codigoCliente) ? (object)DBNull.Value : codigoCliente);
                            cmd.Parameters.AddWithValue("@CPF", string.IsNullOrEmpty(cpf) ? (object)DBNull.Value : cpf);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNome.Text = reader["nome"].ToString();
                                    mskCPF.Text = reader["cpf"].ToString();
                                    mskRG.Text = reader["rg"].ToString();
                                    mskCelular.Text = reader["celular"].ToString();
                                    mskDataDeNascimento.Text = DateTime.Parse(reader["dataNascimento"].ToString()).ToString("dd/MM/yyyy");
                                    string sexo = reader["sexo"].ToString();
                                    if (sexo == "M") rdbMasculino.Checked = true;
                                    else if (sexo == "F") rdbFeminino.Checked = true;
                                    else rdbOutro.Checked = true;
                                    cmbUF.SelectedItem = reader["uf_nascimento"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum cliente encontrado com os dados informados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.Visible = true;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM clientes";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewClientes.DataSource = dataTable;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
          
            
                if (senha()) // Verifica se o usuário inseriu a senha correta
                {
                    // Obter os valores dos campos
                    string codigoCliente = txtCodigoCliente.Text.Trim();
                    string nome = txtNome.Text.Trim();
                    string cpf = mskCPF.Text.Trim();
                    string rg = mskRG.Text.Trim();
                    string celular = mskCelular.Text.Trim();
                    string dataNascimento = mskDataDeNascimento.Text.Trim();
                    string ufNascimento = cmbUF.SelectedItem?.ToString();
                    string sexo = GetSexo();

                    // Verificar se o código do cliente foi informado
                    if (string.IsNullOrEmpty(codigoCliente))
                    {
                        MessageBox.Show("Por favor, informe o código do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar se todos os campos obrigatórios foram preenchidos
                    if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) ||
                        string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(dataNascimento) || string.IsNullOrEmpty(ufNascimento))
                    {
                        MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar a data de nascimento
                    if (!DateTime.TryParse(dataNascimento, out DateTime parsedDate))
                    {
                        MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Conectar ao banco de dados
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open(); // Abre a conexão
                            string query = "UPDATE clientes SET nome = @Nome, cpf = @CPF, rg = @RG, celular = @Celular, " +
                                           "dataNascimento = @DataNascimento, sexo = @Sexo, uf_nascimento = @UFnascimento " +
                                           "WHERE Cliente = @Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                // Adicionar parâmetros ao comando
                                cmd.Parameters.AddWithValue("@Nome", nome);
                                cmd.Parameters.AddWithValue("@CPF", cpf);
                                cmd.Parameters.AddWithValue("@RG", rg);
                                cmd.Parameters.AddWithValue("@Celular", celular);
                                cmd.Parameters.AddWithValue("@DataNascimento", parsedDate.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@Sexo", sexo);
                                cmd.Parameters.AddWithValue("@UFnascimento", ufNascimento);
                                cmd.Parameters.AddWithValue("@Cliente", codigoCliente);

                                // Executar a atualização
                                int result = cmd.ExecuteNonQuery();

                                // Verificar se a atualização foi bem-sucedida
                                if (result > 0)
                                {
                                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimparCampos(); // Limpa os campos após a atualização
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum cliente encontrado com esse código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
    }

