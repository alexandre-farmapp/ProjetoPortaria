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
    public partial class Form_status : Form
    {
        public Form_status()
        {
            InitializeComponent();
        }

        private void disparaDatagrid()
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT * FROM temporarios";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoResizeColumns();

            sqlConnection.Close();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void Form_status_Load(object sender, EventArgs e)
        {           
            disparaDatagrid();
        }

        private void Button_Cadastro_Moradores_Click(object sender, EventArgs e)
        {            
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "UPDATE relatorio SET saida = @saida WHERE nome = @nome ";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@saida", textBox_saida.Text.ToString());
                sqlCommand.Parameters.AddWithValue("@nome", textBox_nome.Text);
                sqlCommand.ExecuteNonQuery();

                comando = "DELETE FROM temporarios WHERE nome = '" + textBox_nome.Text + "'";
                SqlCommand sqlCommand2 = new SqlCommand(comando, sqlConnection);
                sqlCommand2.ExecuteNonQuery();

                MessageBox.Show("Saida gerada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                sqlConnection.Close();

                disparaDatagrid();

                textBox_nome.Text = "";
                textBox_entrada.Text = "";
                textBox_saida.Text = "";
                pictureBox1.ImageLocation = "";
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_nome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_entrada.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_saida.Text = DateTime.Now.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
