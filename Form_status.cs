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

        private void Form_status_Load(object sender, EventArgs e)
        {                        
            dataGridView1.Columns[6].Visible = false;
        }

        private void Button_Cadastro_Moradores_Click(object sender, EventArgs e)
        {
            
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "DELETE FROM temporarios WHERE nome = '" + textBox_nome.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Visitante deletado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comando = "";
                comando = "UPDATE relatorio SET saida = @saida WHERE nome = @nome ";
                SqlCommand sqlCommand2 = new SqlCommand(comando, sqlConnection);
                sqlCommand2.Parameters.AddWithValue("@saida", textBox_saida.Text.ToString());
                sqlCommand2.Parameters.AddWithValue("@nome", textBox_nome.Text);
                sqlCommand2.ExecuteNonQuery();

                sqlConnection.Close();

                
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }


            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_nome.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_entrada.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_saida.Text = DateTime.Now.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
