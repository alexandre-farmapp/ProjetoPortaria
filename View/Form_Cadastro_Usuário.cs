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
using System.Data.SqlClient;

namespace Projeto_Portaria
{
    public partial class Form_Cadastro_Usuário : Form
    {
        Thread fx;
        public Form_Cadastro_Usuário()
        {
            InitializeComponent();
        }

        private void Button_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario;
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT usuario FROM usuarios WHERE usuario = '" + textBox_usuario.Text + "'";
                
                if(cmd.ExecuteScalar() == null)
                {    
                    if (textBox_usuario.Text == "")
                    {
                        MessageBox.Show("Digite um nome!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_usuario.Focus();
                    }
                    else if (textBox_senha.Text == "")
                    {
                        MessageBox.Show("Digite uma senha!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_senha.Focus();
                    }
                    else if (textBox_senha.Text != textBox_confirmar.Text)
                    {
                        MessageBox.Show("Senhas digitadas estão diferentes!", "Mensagem", MessageBoxButtons.OK);
                        textBox_confirmar.Focus();
                    }
                    if (textBox_senha.Text == textBox_confirmar.Text && textBox_senha.Text != "" && textBox_usuario.Text != "")
                    {
                        conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                        sqlConnection = new SqlConnection(conexao);
                        sqlConnection.Open();

                        cmd = sqlConnection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO usuarios(usuario, senha) VALUES('" + textBox_usuario.Text + "','" + textBox_senha.Text + "')";
                        cmd.ExecuteNonQuery();

                        textBox_usuario.Text = "";
                        textBox_senha.Text = "";
                        textBox_confirmar.Text = "";

                        disparar_datagrid();

                        MessageBox.Show("Usuário Cadastrado\ncom sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    usuario = cmd.ExecuteScalar().ToString();
                    if (textBox_usuario.Text == usuario)
                    {
                        MessageBox.Show("Usuario ja existente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_usuario.Focus();
                    }
                }
                
                sqlConnection.Close();
                
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            
        }

        //CRIANDO CLASSE PARA ATRIBUIR AO DATAGRID
        public void disparar_datagrid()
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM usuarios";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[2].Visible = false;

            sqlConnection.Close();
        }

        private void Button_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }        

        private void Form_Cadastro_Usuário_Load(object sender, EventArgs e)
        {                       
            disparar_datagrid();
        }

        private void Button_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox_usuario.Text != "")
                {
                    string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(conexao);
                    sqlConnection.Open();
                                       
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM usuarios WHERE usuario = '" + textBox_usuario.Text + "'";
                    cmd.ExecuteNonQuery();
                    
                    disparar_datagrid();
                    
                    MessageBox.Show("Usuário excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    sqlConnection.Close();

                    textBox_usuario.Text = "";
                    textBox_senha.Text = "";
                    textBox_confirmar.Text = "";
                    button_Cadastrar.Visible = true;
                    button_salvar2.Visible = false;
                    button_deletar.Visible = false;
                    button_alterar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Clique no usuario desejado para deletar!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox_senha.Text != textBox_confirmar.Text)
            {
                MessageBox.Show("Senhas digitadas incorretas\nPor favor as confirme!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "UPDATE usuarios SET senha = @senha WHERE usuario = '" + textBox_usuario.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@senha", textBox_senha.Text);
                sqlCommand.ExecuteNonQuery();

                disparar_datagrid();

                sqlConnection.Close();

                textBox_usuario.Text = "";
                textBox_senha.Text = "";
                textBox_confirmar.Text = "";

                
                button_salvar2.Visible = false;
                button_Cadastrar.Visible = true;
                textBox_usuario.Enabled = true;
                textBox_senha.Enabled = true;
                textBox_confirmar.Enabled = true;
                groupBox_novo_usuario.Text = "Novo usuario";
            }            
        }

        private void Button2_Click(object sender, EventArgs e)
        {            
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where usuario like '" + "%" + txtPesqNome.Text + "%" + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            sqlConnection.Close();
        }

        private void GroupBoxCliente_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_usuario.Enabled = false;
            textBox_senha.Enabled = false;
            textBox_confirmar.Enabled = false;
            button_Cadastrar.Visible = false;
            button_deletar.Visible = true;
            button_alterar.Visible = true;

            textBox_usuario.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox_senha.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox_confirmar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            groupBox_novo_usuario.Text = "Usuario selecionado";
        }

        private void button_alterar_Click(object sender, EventArgs e)
        {            
            textBox_senha.Enabled = true;
            textBox_confirmar.Enabled = true;
            button_salvar2.Visible = true;
            button_alterar.Visible = false;
            button_Cadastrar.Visible = false;
            button_deletar.Visible = false;
            groupBox_novo_usuario.Text = "Alterando...";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
