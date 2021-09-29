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
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarDVR_Click(object sender, EventArgs e)
        {
            string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "INSERT INTO DVRs Values(@condominio, @tipo, @ip, @porta, @usuario, @senha)";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@condominio", Condominio.condominio);
            sqlCommand.Parameters.AddWithValue("@tipo", cbxTipo.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@ip", txtIp.Text);
            sqlCommand.Parameters.AddWithValue("@porta", txtPorta.Text);
            sqlCommand.Parameters.AddWithValue("@usuario", txtUser.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txtSenha.Text);
            sqlCommand.ExecuteNonQuery();
            

        }
    }
}
