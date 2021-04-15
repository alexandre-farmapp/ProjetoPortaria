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
     
    public partial class FormAnotacoes : Form
    {
        
        public FormAnotacoes()
        {
            InitializeComponent();
        }        

        private void FormAnotacoes_Load(object sender, EventArgs e)
        {
            listBoxAnotacao.DataSource = User_info.anotacao;
            textBoxTexto.Focus();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (textBoxTexto.Text != "")
            {
                User_info.anotacao.Add(textBoxTexto.Text);
                User_info.anotacao.Add(DateTime.Now.ToString());
                User_info.anotacao.Add("========================================================");
                listBoxAnotacao.DataSource = null;
                listBoxAnotacao.DataSource = User_info.anotacao;
                textBoxTexto.Clear();
                textBoxTexto.Focus();

            }
            else
            {
                textBoxTexto.Focus();
            }

        }

        private void textBoxTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
