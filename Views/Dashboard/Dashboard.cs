using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.Data.SqlClient;
using WMPLib;


namespace RestauranteUnicode
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();

                    string sql = "INSERT INTO Cardapio (Prato, Descricao, Recheios, Ingredientes, " +
                        "Preco, Opcionais) VALUES (Prato= @Prato, Descricao = @Descricao, " +
                        "Recheios = @Recheios, Ingredientes = @Ingredientes, Preco = @Preco, Opcionais = @Opcionais)";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@Prato", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Descricao", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Recheios", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Ingredientes", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Preco", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Opcionais", textBox6.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir no banco de dados!" + ex.Message);
            }


        }

    // Método para iniciar o player do VLibras 
    private void buttonCustom1_Click(object sender, EventArgs e)
            {
                try
                {

                // Caminho para o executáável do VLibras player 
                string vlibrasPath = @"C:\Users\jason\Source\Repos\teste\VLibrasFiles\VLibras\Player\vlibrasPlayer.exe";

                    // Verifica se o arquivo existe antes de tentar iniciá-lo
                    if (!System.IO.File.Exists(vlibrasPath))
                    {
                        MessageBox.Show("O executável do VLibras player não foi encontrado no caminho especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Inicia o VLibras player
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = vlibrasPath,
                        UseShellExecute = true,
                        CreateNoWindow = true
                    };

                System.Diagnostics.Process.Start(startInfo);

                //WindowsMediaPlayer vlibrasPlayer = new WindowsMediaPlayer();
                //axWindowsMediaPlayer1.uiMode = "none";
                //axWindowsMediaPlayer1.settings.autoStart = true;
                //axWindowsMediaPlayer1.settings.volume = 100;
                //axWindowsMediaPlayer1.settings.mute = false;
                //axWindowsMediaPlayer1.settings.setMode("loop", true);

                //vlibrasPlayer.URL = vlibrasPath;
                //vlibrasPlayer.controls.play();




            }
                catch (Exception ex)
                {
                    // Trata qualquer erros que occurem durante o processo
                    MessageBox.Show("Erro ao iniciar o VLibras Player: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
     }
}

