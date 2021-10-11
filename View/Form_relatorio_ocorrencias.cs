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
    public partial class Form_relatorio_ocorrencias : Form
    {
        public Form_relatorio_ocorrencias()
        {
            InitializeComponent();
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form_relatorio_ocorrencias_Load(object sender, EventArgs e)
        {
            atualizardatagrid2();
        }

        private void atualizardatagrid2()
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ocorrencias";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            sqlConnection.Close();
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox_unidade.Text == "" )
                {
                    MessageBox.Show("Digite a unidade!");
                    textBox_unidade.Focus();
                }
                else if(textBox_rua.Text == "")
                {
                    MessageBox.Show("Digite a Rua/Bloco!");
                    textBox_rua.Focus();
                }
                else if(textBox_ocorrencia.Text == "")
                {
                    MessageBox.Show("Digite a ocorrência!");
                    textBox_ocorrencia.Focus();
                }
                else
                {
                    string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(conexao);
                    sqlConnection.Open();

                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO ocorrencias(unidade, rua, data, hora, min, ocorrencia) VALUES ('" + textBox_unidade.Text + "'," +
                        "'" + textBox_rua.Text + "','" + dateTimePicker1.Text + "','" + comboBox_hora.Text + "','" + comboBox_min.Text + "'," +
                        "'" + textBox_ocorrencia.Text + "')";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();

                    atualizardatagrid2();

                    textBox_unidade.Text = "";
                    textBox_rua.Text = "";
                    textBox_ocorrencia.Text = "";
                    comboBox_hora.SelectedItem = -1;
                    comboBox_min.SelectedItem = -1;
                    dateTimePicker1.Value = DateTime.Now;

                    textBox_ocorrencia.Enabled = false;
                    button_salvar.Visible = false;
                }

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message);
            }
        }

        private void Button_novo_Click(object sender, EventArgs e)
        {
            textBox_unidade.Enabled = true;
            textBox_rua.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox_hora.Enabled = true;
            comboBox_min.Enabled = true;
            textBox_ocorrencia.Enabled = true;
            button_salvar.Visible = true;

            textBox_unidade.Text = "";
            textBox_rua.Text = "";
            comboBox_hora.SelectedItem = -1;
            comboBox_min.SelectedItem = -1;
            textBox_id.Text = "";
            textBox_ocorrencia.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox_unidade.Focus();

            button_alterar.Visible = false;
            button_salvar.Visible = true;
            button_deletar.Visible = false;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(textBox_ocorrencia.Enabled == false)
            {
                if(User_info.usuario_logado == "admin")
                {
                    button_deletar.Visible = true;
                }
                                
                button_alterar.Visible = true;
                button_salvar2.Visible = false;
               // button_salvar.Visible = true;

                textBox_ocorrencia.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                textBox_unidade.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textBox_rua.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                comboBox_hora.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                comboBox_min.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                textBox_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Voce tem que finalizar a ocorrencia em aberto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_alterar_Click(object sender, EventArgs e)
        {
            textBox_ocorrencia.Enabled = true;
            button_salvar2.Visible = true;
            button_novo.Visible = false;
            button_salvar.Visible = false;
            button_alterar.Visible = false;
            
            
        }

        private void Button_salvar2_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "UPDATE ocorrencias SET ocorrencia = @ocorrencia WHERE id = '" + textBox_id.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ocorrencia", textBox_ocorrencia.Text);

            sqlCommand.ExecuteNonQuery();

            atualizardatagrid2();

            textBox_ocorrencia.Enabled = false;
            button_salvar2.Visible = false;
            button_alterar.Visible = false;
            button_novo.Visible = true;
            button_deletar.Visible = false;

            textBox_unidade.Text = "";
            textBox_rua.Text = "";            
            textBox_id.Text = "";
            textBox_ocorrencia.Text = "";
            comboBox_hora.SelectedIndex = -1;
            comboBox_min.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void Button_deletar_Click(object sender, EventArgs e)
        {
            if(User_info.usuario_logado == "admin")
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "delete from ocorrencias where id = '" + textBox_id.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deletado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConnection.Close();
                atualizardatagrid2();

                textBox_unidade.Text = "";
                textBox_rua.Text = "";
                comboBox_hora.SelectedIndex = -1;
                comboBox_min.SelectedIndex = -1;
                textBox_ocorrencia.Text = "";
                textBox_id.Text = "";
                dateTimePicker1.Value = DateTime.Now;

                button_deletar.Visible = false;
                button_novo.Visible = true;
                button_alterar.Visible = false;
                button_salvar.Visible = false;
                button_salvar2.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Só o Administrador pode deletar ocorrencias!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void textBox_ocorrencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
