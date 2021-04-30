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

namespace Projeto_Portaria
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Data Source=" + textBoxServidor.Text + ";Initial Catalog=" + textBoxBanco.Text + ";User Id=" + textBoxUsuario.Text + ";Password=" + textBoxSenha.Text;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();

                    Properties.Settings.Default.Bd_portariaConnectionString = conexao;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    MessageBox.Show("Conectado!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A conexão falhou!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }                
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBoxCaminhoCriar.Text = folderBrowser.SelectedPath;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string dataBase = sqlConnection.Database.ToString();

            if (textBoxCaminhoCriar.Text == "")
            {
                MessageBox.Show("insira um caminho", "mensagem", MessageBoxButtons.OK);
            }
            else
            {

                string comando = "BACKUP DATABASE [" + dataBase + "] TO DISK = '" + textBoxCaminhoCriar.Text + "\\backup-" + DateTime.Today.ToString("dd-mm-yyyy") + ".bak'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Backup realizado com sucesso!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxCaminhoCriar.Text = "";
            }
        }

        private void buttonProcurarArq_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "SQL SERVER database backups files|*.bak";
            fileDialog.Title = "Importar Banco de Dados";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImportar.Text = fileDialog.FileName;
            }
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string dataBase = sqlConnection.Database.ToString();

            if (textBoxImportar.Text == "")
            {
                MessageBox.Show("Insira um caminho", "mensagem", MessageBoxButtons.OK);
            }
            else
            {
                //GRANT “permissão” ON “objeto” TO “usuário”
                /*string comando = "GRANT ALTER ON [ " + dataBase + " ] TO USER";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                string comando1 = "ALTER DATABASE [ " + dataBase + " ] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                SqlCommand sqlCommand1 = new SqlCommand(comando1, sqlConnection);
                sqlCommand1.ExecuteNonQuery();

                //RESTORE DATABASE Vendas FROM DISK = 'C:\Boson\DBVENDAS_20190115.BAK' WITH REPLACE
                string comando2 = "USE MASTER RESTORE DATABASE [ " + dataBase + " ] FROM DISK = '" + textBoxImportar.Text + "' WITH REPLACE;";
                SqlCommand sqlCommand2 = new SqlCommand(comando2, sqlConnection);
                sqlCommand2.ExecuteNonQuery();

                string comando3 = "ALTER DATABASE [ " + dataBase + " ] SET MULTI_USER;";
                SqlCommand sqlCommand3 = new SqlCommand(comando3, sqlConnection);
                sqlCommand3.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Dados importados com sucesso!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                MessageBox.Show("Em desenvolvimento!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT * FROM Servidor WHERE id = 1";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                textBoxServidor.Text = sqlDataReader["nomeServidor"].ToString();
                textBoxBanco.Text = sqlDataReader["bancoDados"].ToString();
                textBoxUsuario.Text = sqlDataReader["usuario"].ToString();
                textBoxSenha.Text = sqlDataReader["senha"].ToString();
                buttonConectar.Text = "Conectado";
            }

            sqlConnection.Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
