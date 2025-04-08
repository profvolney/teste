using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using RestauranteUnicode.Views.Cadastrar;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestauranteUnicode
{
    public partial class RestauranteUnicode : Form
    {
        public RestauranteUnicode()
        {            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var stgAcesso = ConfigurationManager.ConnectionStrings["stgAcesso"].ConnectionString;

                string email = txtEmail.Text.Trim();
                string senha = txtSenha.Text.Trim();

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("preencha todos os campos!");
                    return;
                }
                else
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(stgAcesso);
                        con.Open();

                        string sql = "select * from usuarios where email = @email and senha_hash = @senha_hash";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha_hash", senha);
                        cmd.ExecuteNonQuery();

                        string emailAdmin = ConfigurationManager.AppSettings["emailAdmin"].ToString();
                        string senhaAdmin = ConfigurationManager.AppSettings["passwordAdmin"].ToString();

                        string query = "SELECT perfil_id FROM perfis pf INNER JOIN permissoes per ON pf.id = per.id INNER JOIN telas tl ON tl.id = per.tela_id Order by tl.id;";

                        MySqlCommand cmd2 = new MySqlCommand(query, con);

                        cmd2.ExecuteNonQuery();

                        MySqlDataReader reader = cmd2.ExecuteReader();

                        //string operador = query.SingleOrDefault().ToString();                        

                        if (reader.Read())
                        {
                            string operador = reader["perfil_id"].ToString();

                            if (operador == "1")
                            {
                                if (email != emailAdmin || senha != senhaAdmin)
                                    MessageBox.Show("Você não pode acessar o sistema");
                            }
                            else
                                MessageBox.Show("Login Efetuado com sucesso!");

                            switch (operador)
                            {
                                case "1":
                                    var dashboard = new Dashboard();
                                    dashboard.Show();
                                    this.Hide();
                                    break;

                                case "2":
                                    var cadastrar = new Cadastrar();
                                    cadastrar.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado!");
                            return;
                        }
                        reader.Close();
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("email ou senha incorretos!" + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar no banco de dados!" + ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cad = new Cadastrar();
            cad.Show();
        }

        private void Conexao()
        {
            try
            {
                var stgAcesso = ConfigurationManager.ConnectionStrings["stgAcesso"].ConnectionString;
                //Criando a instância da Conexão
                using (MySqlConnection conexao = new MySqlConnection(stgAcesso))
                {
                    //Abrindo a conexão
                    conexao.Open();

                    // Mostra a mensagem para o usuário caso exista a conexão. 
                    MessageBox.Show("Conectado com sucesso! ");

                    // Fecha a conexão
                    conexao.Close();
                }

            }
            catch (Exception ex)
            {
                // Caso não exista a conexão, a mensagem é mostrada. 
                throw new ArgumentException("Erro ao tentar conectar no banco de dado! "
                    + ex.Message);
            }

        }
        private void btnCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }


        private void RestauranteUnicode_Load(object sender, EventArgs e)
        {
            Conexao();
        }

    }
}
