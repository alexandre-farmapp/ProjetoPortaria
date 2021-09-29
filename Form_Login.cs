using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;//gravar isso
using System.IO;

namespace Projeto_Portaria
{
    public partial class form_Login : Form
    {
        Thread nx;
        public form_Login()
        {
            InitializeComponent();
        }
        
        private void TextBox_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Fazer_Login_Click(object sender, EventArgs e)
        {            
            try
            {
                User_info.usuario_logado = textBox_Usuario.Text;

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "SELECT senha FROM usuarios WHERE usuario = '" + textBox_Usuario.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                string senha = sqlCommand.ExecuteScalar().ToString();
                
                if (textBox_Senha.Text == senha)
                {
                    this.Close();
                    nx = new Thread(formMenu);
                    nx.SetApartmentState(ApartmentState.STA);
                    nx.Start();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos!", "mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Usuario.Text = "";
                    textBox_Senha.Text = "";
                    textBox_Usuario.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Usuario ou senha incorretos!","mensagem!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox_Usuario.Text = "";
                textBox_Senha.Text = "";
                textBox_Usuario.Focus();
            }
        }

        private void formMenu()
        {
            Application.Run(new form_Menu());
        }
        
        private void TextBox_Usuário_TextChanged(object sender, EventArgs e)
        {
            User_info.usuario_logado = textBox_Usuario.Text;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                if (sqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Não foi possivel se conectar ao Banco de dados principal, use o botão conectar-se", "mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonConectar.Visible = true;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                buttonConectar.Visible = true;
                //MessageBox.Show(Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString);
            }
        }

        private string ExtractFilePath(object exename)
        {
            throw new NotImplementedException();
        }

        private void Button_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    User_info.usuario_logado = textBox_Usuario.Text;

                    string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(conexao);
                    sqlConnection.Open();

                    string comando = "SELECT senha FROM usuarios WHERE usuario = '" + textBox_Usuario.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                    string senha = sqlCommand.ExecuteScalar().ToString();
                    
                    if (textBox_Senha.Text == senha)
                    {
                        this.Close();
                        nx = new Thread(formMenu);
                        nx.SetApartmentState(ApartmentState.STA);
                        nx.Start();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos!", "mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Usuario.Text = "";
                        textBox_Senha.Text = "";
                        textBox_Usuario.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Usuario ou senha incorretos!", "mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Usuario.Text = "";
                    textBox_Senha.Text = "";
                    textBox_Usuario.Focus();
                }
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            FormBackup formBackup = new FormBackup();
            formBackup.ShowDialog();
        }
    }
}
