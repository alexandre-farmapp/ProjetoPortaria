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
    public partial class NovoCond : Form
    {
        public NovoCond(string Cod, string nome, string tipo)
        {
            InitializeComponent();
            if (Condominio.comando == "UPDATE")
            {
                textBoxCod.Text = Cod;
                textBoxNomeCond.Text = nome;
                comboBoxTipo.Text = tipo;
            }
            else if (Condominio.comando == "DELETE")
            {
                textBoxCod.Text = Cod;
                textBoxNomeCond.Text = nome;
                comboBoxTipo.Text = tipo;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "";

            if(Condominio.comando == "INSERT")
            {
                comando = "INSERT INTO Condominios (nome, tipo) VALUES (@nome, @tipo)";
            }
            else if(Condominio.comando == "UPDATE")
            {
                comando = "UPDATE Condominios SET nome=@nome, tipo=@tipo WHERE Cod = @cod";
            }
            else if(Condominio.comando == "DELETE")
            {
                comando = "DELETE FROM Condominios WHERE Cod = @cod";
            }
            
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@nome", textBoxNomeCond.Text);
            sqlCommand.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@cod", textBoxCod.Text);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            Condominio.comando = "";
            Condominio.condSelecionado = false;
            this.Close();
        }

        private void NovoCond_Load(object sender, EventArgs e)
        {
            if (Condominio.comando == "INSERT")
            {
                this.Text = "Adicionar Condominio";
            }
            else if (Condominio.comando == "UPDATE")
            {
                this.Text = "Alterar Condominio";
            }
            else if (Condominio.comando == "DELETE")
            {
                this.Text = "Deletar Condominio";
            }
        }
    }
}
