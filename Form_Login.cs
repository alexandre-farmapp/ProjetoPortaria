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

namespace Projeto_Portaria
{
    public partial class form_Login : Form
    {
        Thread nx;
        public form_Login()
        {
            InitializeComponent();
        }

        private void PictureBox_Usuario_Click(object sender, EventArgs e)
        {

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

                string comando = "select senha from usuarios where usuario = '" + textBox_Usuario.Text + "'";
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

        private void Button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_Usuario.Text = "";
            textBox_Senha.Text = "";
        }

        private void TextBox_Usuário_TextChanged(object sender, EventArgs e)
        {
            User_info.usuario_logado = textBox_Usuario.Text;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

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

                    string comando = "select senha from usuarios where usuario = '" + textBox_Usuario.Text + "'";
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
    }
}
