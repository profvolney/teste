using Microsoft.Data.SqlClient;
using RestauranteUnicode.Views;
using RestauranteUnicode.Views.Cadastrar;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace RestauranteUnicode
{
    public partial class Login : Form
    {
        string perfil_id;
        public Login()
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

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var stgAcesso = ConfigurationManager.ConnectionStrings["stgAcesso"].ConnectionString;

        //        string email = textBox1.Text.Trim().ToLower(CultureInfo.InvariantCulture);
        //        string senha = textBox2.Text.Trim().ToLower(CultureInfo.InvariantCulture);

        //        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
        //        {
        //            MessageBox.Show("preencha todos os campos!");
        //            return;
        //        }
        //        else
        //        {
        //            try
        //            {
        //                SqlConnection con1 = new SqlConnection(stgAcesso);
        //                con1.Open();

        //                string sql = "declare @email varchar(50);" +
        //                             "declare @senha_hash varchar(255);" +
        //                             $"set @email = '{email}'" +
        //                             $"set @senha_hash =  hashbytes('SHA2_256', '{senha}') " +
        //                             $"select * from tb_usuarios where email = @email and senha_hash = hashbytes('SHA2_256', @senha_hash) ";

        //                SqlCommand cmd = new SqlCommand(sql, con1);
        //                SqlDataReader reader = cmd.ExecuteReader();

        //                cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
        //                cmd.Parameters.AddWithValue("@senha_hash", SqlDbType.Text).Value = senha;

        //                reader.Close();
        //                cmd.ExecuteNonQuery();

        //                string emailAdmin = ConfigurationManager.AppSettings["emailAdmin"].ToString();
        //                string senhaAdmin = ConfigurationManager.AppSettings["passwordAdmin"].ToString();

        //                string query = "declare @perfil_id int; " +
        //                                "declare @email varchar(50);" +
        //                                "declare @senha_hash varchar(255);" +
        //                                $"set @email = '{email}'" +
        //                                $"set @senha_hash =  hashbytes('SHA2_256', '{senha}') " +
        //                                $"set @perfil_id = (select perfil_id from tb_usuarios where email = '{email}' and senha_hash =  hashbytes('SHA2_256', '{senha}')); " +
        //                                "select @perfil_id as perfil_id;";


        //                SqlConnection con2 = new SqlConnection(stgAcesso);
        //                con2.Open();
        //                SqlCommand cmd2 = new SqlCommand(query, con2);

        //                cmd2.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
        //                cmd2.Parameters.AddWithValue("@senha_hash", SqlDbType.Text).Value = senha;
        //                cmd2.Parameters.Add("@perfil_id", SqlDbType.Int).Value = perfil_id;
        //                SqlDataReader reader2 = cmd2.ExecuteReader();
        //                reader2.Close();

        //                cmd2.ExecuteNonQuery();

        //                if (reader.Read())
        //                {
        //                    string operador = reader["perfil_id"].ToString();

        //                    if (operador == "1" || operador == "2" || operador == "3")
        //                    {
        //                        if (email != emailAdmin || senha != senhaAdmin)
        //                            MessageBox.Show("Você não pode acessar o sistema");
        //                        else if (email != reader["email"].ToString() || senha != reader["senha"].ToString())
        //                            MessageBox.Show("Usuário não encontrado!");
        //                        return;
        //                        //else
        //                        //    MessageBox.Show("Login Efetuado com sucesso!");
        //                    }
        //                    else
        //                        MessageBox.Show("Login Efetuado com sucesso!");


        //                    switch (operador)
        //                    {
        //                        case "1":
        //                            var dashboard = new Dashboard();
        //                            dashboard.Show();
        //                            this.Hide();
        //                            break;

        //                        case "2":
        //                            var cadastrar = new Cadastrar();
        //                            cadastrar.Show();
        //                            this.Hide();
        //                            break;
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Usuário não encontrado!");
        //                    return;
        //                }
        //                reader.Close();
        //                con1.Close();
        //                reader2.Close();
        //                con2.Close();

        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("email ou senha incorretos!" + ex.Message);
        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao tentar conectar no banco de dados!" + ex.Message);
        //    }
        //}

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
                using (SqlConnection conexao = new SqlConnection(stgAcesso))
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
                buttonCustom2.PerformClick();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCustom1.PerformClick();
            }
        }


        private void RestauranteUnicode_Load(object sender, EventArgs e)
        {
            Conexao();
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            try
            {
                var stgAcesso = ConfigurationManager.ConnectionStrings["stgAcesso"].ConnectionString;

                string email = textBox1.Text.Trim().ToLower(CultureInfo.InvariantCulture);
                string senha = textBox2.Text.Trim().ToLower(CultureInfo.InvariantCulture);

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("preencha todos os campos!");
                    return;
                }
                else
                {
                    try
                    {
                        SqlConnection con1 = new SqlConnection(stgAcesso);
                        con1.Open();

                        string sql = "declare @email varchar(50);" +
                                     "declare @senha_hash varchar(255);" +
                                     $"set @email = '{email}'" +
                                     $"set @senha_hash =  hashbytes('SHA2_256', '{senha}') " +
                                     $"select * from tb_usuarios where email = @email and senha_hash = hashbytes('SHA2_256', @senha_hash) ";

                        SqlCommand cmd = new SqlCommand(sql, con1);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.AddWithValue("@senha_hash", SqlDbType.Text).Value = senha;

                        reader.Close();
                        cmd.ExecuteNonQuery();

                        string emailAdmin = ConfigurationManager.AppSettings["emailAdmin"].ToString();
                        string senhaAdmin = ConfigurationManager.AppSettings["passwordAdmin"].ToString();

                        string query = "declare @perfil_id int; " +
                                        "declare @email varchar(50);" +
                                        "declare @senha_hash varchar(255);" +
                                        $"set @email = '{email}'" +
                                        $"set @senha_hash =  hashbytes('SHA2_256', '{senha}') " +
                                        $"set @perfil_id = (select perfil_id from tb_usuarios where email = '{email}' and senha_hash =  hashbytes('SHA2_256', '{senha}')); " +
                                        "select @perfil_id as perfil_id;";


                        SqlConnection con2 = new SqlConnection(stgAcesso);
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand(query, con2);

                        cmd2.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
                        cmd2.Parameters.AddWithValue("@senha_hash", SqlDbType.Text).Value = senha;
                        cmd2.Parameters.Add("@perfil_id", SqlDbType.Int).Value = perfil_id;
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        reader2.Close();

                        cmd2.ExecuteNonQuery();

                        if (reader.Read())
                        {
                            string operador = reader["perfil_id"].ToString();

                            if (operador == "1" || operador == "2" || operador == "3")
                            {
                                if (email != emailAdmin || senha != senhaAdmin)
                                    MessageBox.Show("Você não pode acessar o sistema");
                                else if (email != reader["email"].ToString() || senha != reader["senha"].ToString())
                                    MessageBox.Show("Usuário não encontrado!");
                                return;
                                //else
                                //    MessageBox.Show("Login Efetuado com sucesso!");
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

                                case "3":
                                    MainForm mainForm = new MainForm();
                                    mainForm.Show();
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
                        con1.Close();
                        reader2.Close();
                        con2.Close();

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

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            var cad = new Cadastrar();
            cad.Show();
        }
    }
}
