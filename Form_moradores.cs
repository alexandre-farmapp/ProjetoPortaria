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
    public partial class Form_moradores : Form
    {
        public Form_moradores()
        {
            InitializeComponent();
        }

        private void Form_moradores_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox_Nome.Text = "";
            textBox_cpf.Text = "";
            textBox_Rua.Text = "";
            textBox_unidade.Text = "";
            textBox_Ramal.Text = "";
            maskedTextBox_fixo.Text = "";
            maskedTextBox_celular.Text = "";
            textBox_Email.Text = "";
            textBox_Modelo.Text = "";
            maskedTextBox_placa.Text = "";
            textBox_Cor.Text = "";
            textBox_observacoes.Text = "";
            pictureBox_Foto_Morador.ImageLocation = "";

            buttonCancelar.Visible = false;
            buttonAddFoto.Visible = false;
            buttonAlterar.Visible = false;
            buttonDeletar.Visible = false;
            buttonAdicionar.Visible = true;

        }

        private void Button_voltar_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_pesquisar_Click(object sender, EventArgs e)
        {
            if (textBox_unidade_morador.Text == "")
            {
                dataGridView1.Visible = true;

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT cod_morador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto from moradores where nome LIKE '" + "%" + textBox_nome_morador.Text + "%" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                sqlConnection.Close();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Rua/Bloco";
                dataGridView1.AutoResizeColumns();
            }
            else if (textBox_nome_morador.Text == "")
            {
                dataGridView1.Visible = true;

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select cod_morador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto from moradores where unidade = '" + textBox_unidade_morador.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                sqlConnection.Close();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Rua/Bloco";
                dataGridView1.AutoResizeColumns();

            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_Nome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_cpf.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_Rua.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_unidade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_Ramal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_fixo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox_celular.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_Email.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox_Modelo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            maskedTextBox_placa.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox_Cor.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox_observacoes.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            pictureBox_Foto_Morador.ImageLocation = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            buttonAlterar.Visible = true;
            buttonDeletar.Visible = true;
            buttonAddFoto.Visible = true;
            buttonCancelar.Visible = true;
            buttonAdicionar.Visible = false;

        }
        public void atualizardatagrid()
        {

            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cod_morador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto from moradores where nome LIKE '" + "%" + textBox_nome_morador.Text + "%" + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Rua/Bloco";
            dataGridView1.AutoResizeColumns();

        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {

            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            //string comando = "UPDATE moradores SET ramal = '" + textBox_Ramal.Text + "' WHERE nome = '"+textBox_Nome.Text+"'";
            string comando = "UPDATE moradores SET nome = @nome, CPF = @CPF, rua = @rua , unidade = @unidade, ramal = @ramal, fixo = @fixo, celular = @celular,";
            comando += "email = @email, observacoes = @observacoes, modelo = @modelo, cor = @cor, placa = @placa,foto = @foto WHERE cod_morador = '" + textBox_id.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@nome", textBox_Nome.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
            sqlCommand.Parameters.AddWithValue("@rua", textBox_Rua.Text);
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@ramal", textBox_Ramal.Text);
            sqlCommand.Parameters.AddWithValue("@fixo", maskedTextBox_fixo.Text);
            sqlCommand.Parameters.AddWithValue("@celular", maskedTextBox_celular.Text);
            sqlCommand.Parameters.AddWithValue("@email", textBox_Email.Text);
            sqlCommand.Parameters.AddWithValue("@observacoes", textBox_observacoes.Text);
            sqlCommand.Parameters.AddWithValue("@foto", pictureBox_Foto_Morador.ImageLocation);
            sqlCommand.Parameters.AddWithValue("@modelo", textBox_Modelo.Text);
            sqlCommand.Parameters.AddWithValue("@cor", textBox_Cor.Text);
            sqlCommand.Parameters.AddWithValue("@placa", maskedTextBox_placa.Text);
            sqlCommand.ExecuteNonQuery();

            atualizardatagrid();      

            textBox_Nome.Text = "";
            textBox_cpf.Text = "";
            textBox_Rua.Text = "";
            textBox_unidade.Text = "";
            textBox_Ramal.Text = "";
            maskedTextBox_fixo.Text = "";
            maskedTextBox_celular.Text = "";
            textBox_Email.Text = "";
            textBox_Modelo.Text = "";
            maskedTextBox_placa.Text = "";
            textBox_Cor.Text = "";
            textBox_observacoes.Text = "";
            buttonAddFoto.Text = "";
            pictureBox_Foto_Morador.ImageLocation = "";


            buttonAlterar.Visible = false;
            buttonDeletar.Visible = false;
            buttonAddFoto.Visible = false;
            buttonCancelar.Visible = false;

            textBox_unidade_morador.Focus();


            sqlConnection.Close();
        }

        private void PictureBox_Foto_Morador_Click(object sender, EventArgs e)
        {
            /*string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select foto from moradores where nome = '" + dataGridView1.CurrentCell.Value + "'";
            cmd.ExecuteNonQuery();
            */
        }

        private void Form_moradores_MouseHover(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox_fixo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Button_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from moradores where cod_morador = '" + textBox_id.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Morador excluido\ncom sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                atualizardatagrid();

                sqlConnection.Close();

                textBox_id.Text = "";
                textBox_Nome.Text = "";
                textBox_cpf.Text = "";
                textBox_Rua.Text = "";
                textBox_unidade.Text = "";
                textBox_Ramal.Text = "";
                maskedTextBox_fixo.Text = "";
                maskedTextBox_celular.Text = "";
                textBox_Email.Text = "";
                textBox_Modelo.Text = "";
                maskedTextBox_placa.Text = "";
                textBox_Cor.Text = "";
                textBox_observacoes.Text = "";
                buttonAddFoto.Text = "";
                pictureBox_Foto_Morador.ImageLocation = "";

                buttonAlterar.Visible = false;
                buttonDeletar.Visible = false;
                buttonAddFoto.Visible = false;
                buttonCancelar.Visible = false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button_Adicionar_Foto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Selecione uma foto";
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Foto_Morador.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Form_moradores_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_nome_morador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Visible = true;

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select cod_morador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto from moradores where nome LIKE '" + "%" + textBox_nome_morador.Text + "%" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                sqlConnection.Close();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Rua/Bloco";
                dataGridView1.AutoResizeColumns();
            }
        }

        private void textBox_unidade_morador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Visible = true;

                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select cod_morador,nome,CPF,rua,unidade,ramal,fixo,celular,email,observacoes,modelo,cor,placa,foto from moradores where unidade = '" + textBox_unidade_morador.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                sqlConnection.Close();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Rua/Bloco";
                dataGridView1.AutoResizeColumns();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBox_Nome.Text != "" && textBox_cpf.Text != "" && textBox_unidade.Text != "")
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "SELECT CPF FROM moradores WHERE CPF = " + textBox_cpf.Text + "";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

                if (sqlCommand.ExecuteScalar() == null)
                {
                    try
                    {
                        comando = "INSERT INTO moradores(Nome,Cpf,Rua,Unidade,Ramal,Fixo,Celular,Email,Observacoes,Foto,Modelo,Cor,Placa) ";
                        comando += "VALUES(@nome,@CPF,@rua,@unidade,@ramal,@fixo,@celular,@email,@observacoes,@foto,@modelo,@cor,@placa)";
                        SqlCommand sqlCommand2 = new SqlCommand(comando, sqlConnection);
                        sqlCommand2.Parameters.AddWithValue("@nome", textBox_Nome.Text);
                        sqlCommand2.Parameters.AddWithValue("@CPF", textBox_cpf.Text);
                        sqlCommand2.Parameters.AddWithValue("@rua", textBox_Rua.Text);
                        sqlCommand2.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
                        sqlCommand2.Parameters.AddWithValue("@ramal", textBox_Ramal.Text);
                        sqlCommand2.Parameters.AddWithValue("@fixo", maskedTextBox_fixo.Text);
                        sqlCommand2.Parameters.AddWithValue("@celular", maskedTextBox_celular.Text);
                        sqlCommand2.Parameters.AddWithValue("@email", textBox_Email.Text);
                        sqlCommand2.Parameters.AddWithValue("@observacoes", textBox_observacoes.Text);
                        sqlCommand2.Parameters.AddWithValue("@foto", openFileDialog1.FileName);
                        sqlCommand2.Parameters.AddWithValue("@modelo", textBox_Modelo.Text);
                        sqlCommand2.Parameters.AddWithValue("@cor", textBox_Cor.Text);
                        sqlCommand2.Parameters.AddWithValue("@placa", maskedTextBox_placa.Text);

                        sqlCommand2.ExecuteNonQuery();

                        sqlConnection.Close();
                        MessageBox.Show("Morador cadastrado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox_Nome.Text = "";
                        textBox_cpf.Text = "";
                        textBox_Rua.Text = "";
                        textBox_unidade.Text = "";
                        textBox_Ramal.Text = "";
                        maskedTextBox_fixo.Text = "";
                        maskedTextBox_celular.Text = "";
                        textBox_Email.Text = "";
                        textBox_Modelo.Text = "";
                        maskedTextBox_placa.Text = "";
                        textBox_Cor.Text = "";
                        textBox_observacoes.Text = "";
                        pictureBox_Foto_Morador.ImageLocation = "";
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Já existe um morador com este CPF");
                    sqlConnection.Close();
                }

            }
            else
            {
                MessageBox.Show("Dados Invalidos!!");
                textBox_Nome.Focus();
            }

        }
    }
    }
