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
    public partial class Cadastro_de_Visitantes : Form
    {
        Thread nx;

        public Cadastro_de_Visitantes()
        {
            InitializeComponent();
        }

        private void GroupBox_Dados_Veiculo_Enter(object sender, EventArgs e)
        {

        }     

        private void Label_Celular_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_de_Visitantes_Load(object sender, EventArgs e)
        {
            textBox_entrada.Text = DateTime.Now.ToString();
            dataGridView1.Visible = false;            
        }        

        private void PictureBox_Foto_Visitante_Click(object sender, EventArgs e)
        {

        }
        
        private void Button_voltar_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void formMenu()
        {
            Application.Run(new form_Menu());
        }

        private void Button_Registrar_Click(object sender, EventArgs e)
        {
            //try
            {
                if (textBox_Nome.Text != "" && textBox_cpf.Text != "" && textBox_visitado.Text != "")
                {
                    string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(conexao);
                    sqlConnection.Open();

                    string comando = "SELECT CPF FROM visitantes WHERE CPF = @cpf";
                    SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@cpf", textBox_cpf.Text);

                    if(sqlCommand.ExecuteScalar() == null)
                    {
                        comando = "INSERT INTO visitantes(nome,CPF,telefone_celular,unidade,visitado,modelo,placa,observacoes,foto) " +
                            "values(@nome, @CPF, @telefone_celular, @unidade, @visitado, @modelo, @placa, @observacoes, @foto)";
                        sqlCommand = new SqlCommand(comando, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@nome", textBox_Nome.Text);
                        sqlCommand.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
                        sqlCommand.Parameters.AddWithValue("@telefone_celular", maskedTextBox_celular.Text);
                        sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
                        sqlCommand.Parameters.AddWithValue("@visitado", textBox_visitado.Text);
                        sqlCommand.Parameters.AddWithValue("@modelo", textBox_Modelo.Text);
                        sqlCommand.Parameters.AddWithValue("@placa", maskedTextBox_placa.Text);
                        sqlCommand.Parameters.AddWithValue("@observacoes", textBox_observacoes.Text);
                        sqlCommand.Parameters.AddWithValue("@foto", openFileDialog1.FileName);
                        sqlCommand.ExecuteNonQuery();

                        comando = "INSERT INTO relatorio(nome,CPF,telefone_celular,unidade,blocoRua,visitado,observacoes,entrada,saida,foto) " +
                            "values(@nome,@CPF,@telefone_celular,@unidade,@blocoRua,@visitado,@observacoes,@entrada,@saida,@foto)";
                        sqlCommand = new SqlCommand(comando, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@nome", textBox_Nome.Text);
                        sqlCommand.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
                        sqlCommand.Parameters.AddWithValue("@telefone_celular", maskedTextBox_celular.Text);
                        sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
                        sqlCommand.Parameters.AddWithValue("@blocoRua", textBoxBlocoRua.Text);
                        sqlCommand.Parameters.AddWithValue("@visitado", textBox_visitado.Text);
                        sqlCommand.Parameters.AddWithValue("@observacoes", textBox_observacoes.Text);
                        sqlCommand.Parameters.AddWithValue("@entrada", textBox_entrada.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@saida", textBox_entrada.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@foto", openFileDialog1.FileName);
                        sqlCommand.ExecuteNonQuery();

                        comando = "INSERT INTO temporarios(nome,CPF,celular,entrada,visitado,carro,placa,foto) " +
                            "values(@nome,@CPF,@celular,@entrada,@visitado,@carro,@placa,@foto)";
                        sqlCommand = new SqlCommand(comando, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@nome", textBox_Nome.Text);
                        sqlCommand.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
                        sqlCommand.Parameters.AddWithValue("@celular", maskedTextBox_celular.Text);
                        sqlCommand.Parameters.AddWithValue("@entrada", textBox_entrada.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@visitado", textBox_visitado.Text);
                        sqlCommand.Parameters.AddWithValue("@carro", textBox_Modelo.Text);
                        sqlCommand.Parameters.AddWithValue("@placa", maskedTextBox_placa.Text);
                        sqlCommand.Parameters.AddWithValue("@foto", openFileDialog1.FileName);
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        comando = "UPDATE visitantes SET Nome=@nome, CPF=@CPF, telefone_celular=@telefone_celular, unidade=@unidade, visitado=@visitado, modelo=@modelo, " +
                            "placa=@placa, observacoes=@observacoes, foto=@foto WHERE CPF= @cpf";
                        sqlCommand = new SqlCommand(comando, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@nome", textBox_Nome.Text);
                        sqlCommand.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
                        sqlCommand.Parameters.AddWithValue("@telefone_celular", maskedTextBox_celular.Text);
                        sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
                        sqlCommand.Parameters.AddWithValue("@visitado", textBox_visitado.Text);
                        sqlCommand.Parameters.AddWithValue("@modelo", textBox_Modelo.Text);
                        sqlCommand.Parameters.AddWithValue("@placa", maskedTextBox_placa.Text);
                        sqlCommand.Parameters.AddWithValue("@observacoes", textBox_observacoes.Text);
                        sqlCommand.Parameters.AddWithValue("@foto", pictureBox_Foto_Visitante.ImageLocation);
                        sqlCommand.ExecuteNonQuery();

                        comando = "INSERT INTO relatorio(Nome,CPF,visitado,Unidade,blocoRua,telefone_celular,observacoes,foto,entrada,saida) " +
                            "values(@Nome,@CPF,@visitado,@unidade,@blocoRua,@telefone_celular,@observacoes,@foto,@entrada,@saida)";
                        sqlCommand = new SqlCommand(comando, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@Nome", textBox_Nome.Text);
                        sqlCommand.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
                        sqlCommand.Parameters.AddWithValue("@telefone_celular", maskedTextBox_celular.Text);
                        sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
                        sqlCommand.Parameters.AddWithValue("@blocoRua", textBoxBlocoRua.Text);
                        sqlCommand.Parameters.AddWithValue("@visitado", textBox_visitado.Text);
                        sqlCommand.Parameters.AddWithValue("@observacoes", textBox_observacoes.Text);
                        sqlCommand.Parameters.AddWithValue("@entrada", textBox_entrada.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@saida", textBox_entrada.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@foto", pictureBox_Foto_Visitante.ImageLocation);
                        sqlCommand.ExecuteNonQuery();

                        comando = "INSERT INTO temporarios(nome,cpf,celular,entrada,visitado,carro,placa,foto) " +
                            "values(@nome,@cpf,@celular,@entrada,@visitado,@carro,@placa,@foto)";
                        sqlCommand = new SqlCommand(comando, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@nome", textBox_Nome.Text);
                        sqlCommand.Parameters.AddWithValue("@cpf", textBox_cpf.Text);
                        sqlCommand.Parameters.AddWithValue("@celular", maskedTextBox_celular.Text);
                        sqlCommand.Parameters.AddWithValue("@entrada", textBox_entrada.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@visitado", textBox_visitado.Text);
                        sqlCommand.Parameters.AddWithValue("@carro", textBox_Modelo.Text);
                        sqlCommand.Parameters.AddWithValue("@placa", maskedTextBox_placa.Text);
                        sqlCommand.Parameters.AddWithValue("@foto", pictureBox_Foto_Visitante.ImageLocation);
                        sqlCommand.ExecuteNonQuery();
                    }                    

                    MessageBox.Show("Visitante cadastrado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dados incompletos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //catch (Exception msg)
            {

               // MessageBox.Show(msg.Message);
            }
            


        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_entrada.Text = DateTime.Now.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(textBox_nome_visitante.Text != "")
            {
                dataGridView1.Visible = true;

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nome,CPF,visitado,unidade,telefone_celular,observacoes,modelo,placa,foto from visitantes where nome LIKE '" + "%" + textBox_nome_visitante.Text + "%" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //dataGridView1.Columns[8].Visible = false;
                dataGridView1.AutoResizeColumns();

                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Digite algo para ser pesquisado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_nome_visitante.Focus();
            }
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Nome.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_cpf.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_visitado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_unidade.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_celular.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_Modelo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox_placa.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_observacoes.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox_Foto_Visitante.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void Button_Adicionar_Foto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Selecione uma foto";
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.png";
            
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox_Foto_Visitante.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Button_datagrid_visible_Click(object sender, EventArgs e)
        {
            //groupBox_Dados_Pessoais.Visible = false;
            //groupBox_pesquisa_morador.Visible = true;
            textBox_Nome.Visible = false;
            textBox_cpf.Visible = false;
            textBox_visitado.Visible = false;
            textBox_unidade.Visible = false;
            textBoxBlocoRua.Visible = false;
            maskedTextBox_celular.Visible = false;
            textBox_entrada.Visible = false;
            button_datagrid_visible.Visible = false;
            label_Nome.Visible = false;
            label_CPF.Visible = false;
            label_Celular.Visible = false;
            label_Bloco.Visible = false;
            label_Apartamento.Visible = false;
            label_entrada.Visible = false;
            labelBlocoRua.Visible = false;

            label_pesquisa_visitado.Visible = true;
            label_pequisa_unidade.Visible = true;
            textBox_unidade_visitado.Visible = true;
            textBox_nome_visitado.Visible = true;
            dataGridView_pesquisa_morador.Visible = true;
            button_pesquisar_morador.Visible = true;
        }

        private void Button_pesquisar_morador_Click(object sender, EventArgs e)
        {            
            if (textBox_unidade_visitado.Text == "")
            {            
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nome,rua,unidade,ramal,fixo,celular from moradores where nome LIKE '" + "%" + textBox_nome_visitado.Text + "%" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView_pesquisa_morador.DataSource = dt;
                dataGridView_pesquisa_morador.AutoResizeColumns();

                sqlConnection.Close();
            }
            else if (textBox_nome_visitado.Text == "")
            {               

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nome,rua,unidade,ramal,fixo,celular from moradores where unidade = '" + textBox_unidade_visitado.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView_pesquisa_morador.DataSource = dt;
                dataGridView_pesquisa_morador.AutoResizeColumns();

                sqlConnection.Close();
            }
        }

        private void DataGridView_pesquisa_morador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            
            textBox_visitado.Text = dataGridView_pesquisa_morador.CurrentRow.Cells[0].Value.ToString();
            textBox_unidade.Text = dataGridView_pesquisa_morador.CurrentRow.Cells[2].Value.ToString();
            textBoxBlocoRua.Text = dataGridView_pesquisa_morador.CurrentRow.Cells[1].Value.ToString();

            textBox_Nome.Visible = true;
            textBox_cpf.Visible = true;
            textBox_visitado.Visible = true;
            textBox_unidade.Visible = true;
            textBoxBlocoRua.Visible = true;
            maskedTextBox_celular.Visible = true;
            textBox_entrada.Visible = true;
            button_datagrid_visible.Visible = true;
            label_Nome.Visible = true;
            label_CPF.Visible = true;
            label_Celular.Visible = true;
            label_Bloco.Visible = true;
            label_Apartamento.Visible = true;
            label_entrada.Visible = true;
            labelBlocoRua.Visible = true;

            label_pesquisa_visitado.Visible = false;
            label_pequisa_unidade.Visible = false;
            textBox_unidade_visitado.Visible = false;
            textBox_nome_visitado.Visible = false;
            dataGridView_pesquisa_morador.Visible = false;
            button_pesquisar_morador.Visible = false;
        }
    }
}
