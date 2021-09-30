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
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarDVR_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "INSERT INTO DVRs VALUES(@condominio, @tipo, @ip, @porta, @usuario, @senha, @caminho)";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
            sqlCommand.Parameters.AddWithValue("@tipo", cbxTipo.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@ip", txtIp.Text);
            sqlCommand.Parameters.AddWithValue("@porta", txtPorta.Text);
            sqlCommand.Parameters.AddWithValue("@usuario", txtUser.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txtSenha.Text);
            sqlCommand.Parameters.AddWithValue("@caminho", "");
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();           

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoFoto.Text = folderBrowser.SelectedPath;

                if(txtIp.Text != "")
                {
                    string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(conexao);
                    sqlConnection.Open();

                    string comando = "UPDATE DVRs SET caminhoFoto = @caminho";
                    SqlCommand sqlCommand3 = new SqlCommand(comando, sqlConnection);
                    sqlCommand3.Parameters.AddWithValue("@caminhoFoto", txtCaminhoFoto.Text);
                    sqlCommand3.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Vamos primeiro adicionar um equipamento!");
                    cbxTipo.Focus();
                }
            }
        }

        private void btnExcluirDVR_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "DELETE DVRs WHERE condominio = @condominio";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            cbxTipo.Dispose();
            txtIp.Dispose();
            txtPorta.Dispose();
            txtUser.Dispose();
            txtSenha.Dispose();
        }
    }
}
