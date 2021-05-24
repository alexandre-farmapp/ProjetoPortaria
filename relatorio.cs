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
using OfficeOpenXml;

namespace Projeto_Portaria
{   
    public partial class relatorio : Form
    {
        public relatorio()
        {
            InitializeComponent();
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "";

            if(textBox_unidade.Text =="" && textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if(textBox_unidade.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
            }
            else if(textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
            }
            else
            {
                comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade " +
                    "AND blocoRua = @blocoRua ORDER BY entrada";
            }
            
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value);
            sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value);
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
            sqlCommand.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoResizeColumns();

            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }               

        private void button_excel_Click(object sender, EventArgs e)
        {/*
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;

                DataTable dataTable = new DataTable();

                using (SqlConnection sqlConnection = new SqlConnection(conexao))
                {
                    sqlConnection.Open();
                    string comando = "";

                    if (textBox_unidade.Text == "" && textBox_ruaBloco.Text == "")
                    {
                        comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                            "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
                    }
                    else if (textBox_unidade.Text == "")
                    {
                        comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                            "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
                    }
                    else if (textBox_ruaBloco.Text == "")
                    {
                        comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                            "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
                    }
                    else
                    {
                        comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                            "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade " +
                            "AND blocoRua = @blocoRua ORDER BY entrada";
                    }

                    SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value);
                    sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value);
                    sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
                    sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
                    sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                }

                DataColumnCollection dataColumnCollection = dataTable.Columns;

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excel = new ExcelPackage())
                {
                    excel.Workbook.Worksheets.Add("Relatorio");
                    var tabela = excel.Workbook.Worksheets["Relatorio"];

                    for (int i = 1; i < dataTable.Rows.Count + 1; i++)
                    {
                        tabela.Cells["A1"].LoadFromDataTable(dataTable, true);                        
                    }
                    
                    FileInfo arqexcel = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Relatorio " + DateTime.Now.ToString().Replace("/", "-").Replace(":", "-").Replace(" ", "-") + ".xlsx");

                    excel.SaveAs(arqexcel);
                    Process.Start(arqexcel.ToString());
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);

            }*/

            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "";

            if (textBox_unidade.Text == "" && textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if (textBox_unidade.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
            }
            else if (textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
            }
            else
            {
                comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade " +
                    "AND blocoRua = @blocoRua ORDER BY entrada";
            }

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value);
            sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value);
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
            sqlCommand.ExecuteNonQuery();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                //StreamWriter para gravar um arquivo
                StreamWriter objetoarquivo = new StreamWriter("Relatorio " + DateTime.Now.ToString("dd-mm-yy") + ".xls", false);//false gera um novo arq toda vez,true grava todos no mesmo arq
                //objetoarquivo.WriteLine("\t\t\tRelatorio " + DateTime.Now.ToString());
                objetoarquivo.WriteLine("Nome\tUnidadeVisitada\tHora entrada\tHora saida");

                while (sqlDataReader.Read())
                {
                    string nome = sqlDataReader["Nome"].ToString();
                    string unidade = sqlDataReader["Unidade"].ToString();
                    string entrada = sqlDataReader["entrada"].ToString();
                    string saida = sqlDataReader["saida"].ToString();

                    objetoarquivo.WriteLine(nome + "\t" + unidade + "\t"+ entrada + "\t"+ saida);
                    //objetoarquivo.Write(unidade + "\t");
                    //objetoarquivo.Write(entrada + "\t");
                    //objetoarquivo.Write(saida + "\n");
                }
                objetoarquivo.Close();
                Process.Start("Relatorio " + DateTime.Now.ToString("dd-mm-yy") + ".xls");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            sqlConnection.Close();

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
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if (textBox_unidade.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
            }
            else if (textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
            }
            else
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade " +
                    "AND blocoRua = @blocoRua ORDER BY entrada";
            }

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value);
            sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value);
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                //int i = 130;
                int j = 160;

                e.Graphics.DrawString("Relatorio", new Font("Arial", 36, FontStyle.Bold), Brushes.Black, new PointF(250, 40));
                e.Graphics.DrawString("Nome", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 130));
                e.Graphics.DrawString("Unidade Visitada", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(250, 130));
                //e.Graphics.DrawString("", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(270, 130));
                e.Graphics.DrawString("Hora entrada", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(400, 130));
                e.Graphics.DrawString("Hora saida", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 130));

                while (sqlDataReader.Read())
                {
                    string nome = sqlDataReader["Nome"].ToString();
                    string unidade = sqlDataReader["Unidade"].ToString();
                    //string placa = sqlDataReader["placa"].ToString();
                    string entrada = sqlDataReader["entrada"].ToString();
                    string saida = sqlDataReader["saida"].ToString();

                    e.Graphics.DrawString(nome, new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, new PointF(50, j));
                    e.Graphics.DrawString(unidade, new Font("Arial", 12, FontStyle.Bold), Brushes.Gray, new PointF(250, j));
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

        private void buttonWord_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "";

            if (textBox_unidade.Text == "" && textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim ORDER BY entrada";
            }
            else if (textBox_unidade.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND blocoRua = @blocoRua ORDER BY entrada";
            }
            else if (textBox_ruaBloco.Text == "")
            {
                comando = "SELECT nome, Unidade, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade ORDER BY entrada";
            }
            else
            {
                comando = "SELECT nome, visitado, entrada, saida, condominio FROM relatorio " +
                    "WHERE condominio = @condominio AND entrada BETWEEN @dataInicio AND @dataFim AND Unidade = @unidade " +
                    "AND blocoRua = @blocoRua ORDER BY entrada";
            }

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataInicio", dateTimePicker_inicio.Value);
            sqlCommand.Parameters.AddWithValue("@dataFim", dateTimePicker_fim.Value);
            sqlCommand.Parameters.AddWithValue("@unidade", textBox_unidade.Text);
            sqlCommand.Parameters.AddWithValue("@blocoRua", textBox_ruaBloco.Text);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
            sqlCommand.ExecuteNonQuery();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                //StreamWriter para gravar um arquivo
                StreamWriter objetoarquivo = new StreamWriter("Relatorio " + DateTime.Now.ToString("dd-mm-yy") + ".doc", false);//false gera um novo arq toda vez,true grava todos no mesmo arq
                objetoarquivo.WriteLine("\t\t\tRelatorio " + DateTime.Now.ToString());
                objetoarquivo.WriteLine("\tNome\t\tUnidade\t\tHora entrada\t\tHora saida");                
                                
                while (sqlDataReader.Read())
                {
                    string nome = sqlDataReader["Nome"].ToString();
                    string visitado = sqlDataReader["Unidade"].ToString();
                    string entrada = sqlDataReader["entrada"].ToString();
                    string saida = sqlDataReader["saida"].ToString();

                    objetoarquivo.Write(nome + "\t");
                    objetoarquivo.Write(visitado + "\t");
                    objetoarquivo.Write(entrada + "\t");
                    objetoarquivo.Write(saida + "\n");
                }
                objetoarquivo.Close();
                Process.Start("Relatorio " + DateTime.Now.ToString("dd-mm-yy") + ".doc");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            sqlConnection.Close();
        }
    }
}
