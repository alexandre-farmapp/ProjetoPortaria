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
    public partial class Form_pessoas_uteis : Form
    {
        public Form_pessoas_uteis()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            button_salvar.Visible = true;
            button_alterar.Visible = false;
        }

        private void Form_pessoas_uteis_Load(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT * FROM pessoasuteis";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();

            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_nome_sindico.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_telefone_sindico.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_nome_supervisor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_telefone_supervisor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_nome_zelador.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_telefone_zelador.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if(User_info.usuario_logado == "admin")
            {
                button_alterar.Visible = true;                
            }
            else
            {
                button_alterar.Visible = false;
                button_salvar.Visible = false;
            }

        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                //string comando = "UPDATE moradores SET ramal = '" + textBox_Ramal.Text + "' WHERE nome = '"+textBox_Nome.Text+"'";
                string comando = "UPDATE pessoasuteis SET nome_sindico = @nome_sindico, telefone_sindico = @telefone_sindico, nome_supervisor = @nome_supervisor, ";
                comando += "telefone_supervisor = @telefone_supervisor, nome_zelador = @nome_zelador, telefone_zelador = @telefone_zelador ";
                comando += "WHERE id = '" + textBox_id.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nome_sindico", textBox_nome_sindico.Text);
                sqlCommand.Parameters.AddWithValue("@telefone_sindico", maskedTextBox_telefone_sindico.Text);
                sqlCommand.Parameters.AddWithValue("@nome_supervisor", textBox_nome_supervisor.Text);
                sqlCommand.Parameters.AddWithValue("@telefone_supervisor", maskedTextBox_telefone_supervisor.Text);
                sqlCommand.Parameters.AddWithValue("@nome_zelador", textBox_nome_zelador.Text);
                sqlCommand.Parameters.AddWithValue("@telefone_zelador", maskedTextBox_telefone_zelador.Text);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Dados salvo com Sucesso!!", "Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button_salvar.Visible = false;
                button_alterar.Visible = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message);
            }
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
