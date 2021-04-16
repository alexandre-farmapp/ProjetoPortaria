using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Portaria
{   
    public partial class relatorio : Form
    {
        String[] documento = new string[10000];
        String[] nome = new String[1000];
        String[] visitado = new String[1000];
        String[] entrada = new String[1000];
        String[] saida = new String[1000];

        public relatorio()
        {
            InitializeComponent();
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            /*
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "select nome,visitado,entrada,saida from relatorio where entrada between '" + dateTimePicker_inicio.Value + "' and '" + dateTimePicker_fim.Value + "' and unidade = '" + textBox_unidade.Text +"' order by entrada";
            SqlDataAdapter dados = new SqlDataAdapter(comando, sqlConnection);
            DataSet fontededados = new DataSet();
            dados.Fill(fontededados);
            dataGridView1.DataSource = fontededados.Tables[0];
            dataGridView1.AutoResizeColumns();
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[7].Visible = false;

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
                        
            int i;
            int j;

            if (reader.Read())
            {
                for(i=0;i<100;i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        documento[j] = reader.GetValue(j).ToString()+ " ";
                    }
                }

            }

            reader.Close();

            sqlConnection.Close();*/

            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "";

            if(textBox_unidade.Text =="" && textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio " +
                    "WHERE entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if(textBox_unidade.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio " +
                    "WHERE entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
            }
            else if(textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio " +
                    "WHERE entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
            }
            
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value.ToString());
            sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value.ToString());
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
            sqlCommand.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoResizeColumns();

            /*
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                int i = 0;
                while (sqlDataReader.Read())
                {
                    nome[i] = sqlDataReader["nome"].ToString();
                    visitado[i] = sqlDataReader["visitado"].ToString();
                    entrada[i] = sqlDataReader["entrada"].ToString();
                    saida[i] = sqlDataReader["saida"].ToString();

                    i++;                   

                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            */

            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }               

        private void button_excel_Click(object sender, EventArgs e)
        {
            string nomeArq = "Relarótio Unidade " + textBox_unidade.Text + textBox_ruaBloco.Text + ".xls";
            // StreamReader // leio o arquivo que ja existe
            StreamWriter objarq = new StreamWriter(nomeArq, false);  // para gerar arquivos (gravar) && Extenção do Arquivo a ser gerado

            objarq.Write("Nome\tVisitado\tentrada\tsaida\n");

            int i = 0;

            while(nome != null)
            {
                objarq.Write(nome[i] +"\t"+ visitado[i] + "\t" + entrada[i] + "\t" + saida[i] + "\n");

                i++;
            }

            /*
            for (i = 0; i < 100; i++)
            {
                objarq.Write(documento[i]);

            }*/
                       
            objarq.Close();
            Process.Start(nomeArq);

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "";

            if (textBox_unidade.Text == "" && textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio " +
                    "WHERE entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if (textBox_unidade.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio " +
                    "WHERE entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
            }
            else if (textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio " +
                    "WHERE entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
            }

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value.ToString());
            sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value.ToString());
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
            sqlCommand.ExecuteNonQuery();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                //int i = 130;
                int j = 160;

                e.Graphics.DrawString("Relatorio", new Font("Arial", 36, FontStyle.Bold), Brushes.Black, new PointF(250, 40));
                e.Graphics.DrawString("Nome", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 130));
                e.Graphics.DrawString("VIsitado", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(180, 130));
                //e.Graphics.DrawString("", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(270, 130));
                e.Graphics.DrawString("Hora entrada", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(400, 130));
                e.Graphics.DrawString("Hora saida", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 130));

                while (sqlDataReader.Read())
                {
                    string nome = sqlDataReader["Nome"].ToString();
                    string visitado = sqlDataReader["Visitado"].ToString();
                    //string placa = sqlDataReader["placa"].ToString();
                    string entrada = sqlDataReader["entrada"].ToString();
                    string saida = sqlDataReader["saida"].ToString();

                    e.Graphics.DrawString(nome, new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, new PointF(50, j));
                    e.Graphics.DrawString(visitado, new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, new PointF(180, j));
                    //e.Graphics.DrawString(placa, new Font("Centuey Gothic", 12, FontStyle.Bold), Brushes.Gray, new PointF(270, j));
                    e.Graphics.DrawString(entrada, new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, new PointF(400, j));
                    e.Graphics.DrawString(saida, new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, new PointF(600, j));
                    //i += 10;
                    j += 35;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            sqlConnection.Close();
        }
    }
}
