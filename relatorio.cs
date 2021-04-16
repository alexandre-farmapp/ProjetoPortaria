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
                comando = "SELECT nome, visitado, entrada, saida FROM relatorio ";
                comando += "WHERE entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if(textBox_unidade.Text == "")
            {
                comando = "select nome, visitado, entrada, saida from relatorio ";
                comando += "where entrada between @dataInicio and @dataFim and blocoRua = @blocoRua order by entrada";
            }
            else if(textBox_ruaBloco.Text == "")
            {
                comando = "select nome, visitado, entrada, saida from relatorio ";
                comando += "where entrada between @dataInicio and @dataFim and Unidade = @unidade order by entrada";
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
    }
}
