using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Portaria
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Data Source=" + textBoxServidor.Text + ";Initial Catalog=" + textBoxBanco.Text + ";User Id=" + textBoxUsuario.Text + ";Password=" + textBoxSenha.Text;
                Properties.Settings.Default.Bd_portariaConnectionString = conexao;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            
        }
    }
}
