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
    public partial class form_Menu : Form
    {
        Thread fx;
        public form_Menu()
        {
            InitializeComponent();
            atualizardatagrid();
        }
        
        private void Button_Cadastro_Visitantes_Click(object sender, EventArgs e)
        {
            Cadastro_de_Visitantes cadastro_De_Visitantes = new Cadastro_de_Visitantes();
            cadastro_De_Visitantes.ShowDialog();

            fx = new Thread(formVisitantes);
            fx.SetApartmentState(ApartmentState.STA);
            fx.Start();
        }

        private void atualizardatagrid()
        {
            try
            {
                string conexao = Projeto_Portaria.Properties.Settings.Default.Bd_portariaConnectionString;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "SELECT nome FROM Condominios";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;


                if (dataGridView1.Rows.Count > 0)
                {
                    Condominio.condSelecionado = true;
                }
                sqlConnection.Close();

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void formVisitantes()
        {
            //Application.Run(new Cadastro_de_Visitantes());
        }

        private void Button_Cadastrar_Novo_Usuario_Click(object sender, EventArgs e)
        {
            if(User_info.usuario_logado == "admin")
            {
                Form_Cadastro_Usuário form_Cadastro_Usuário = new Form_Cadastro_Usuário();
                form_Cadastro_Usuário.ShowDialog();

                fx = new Thread(formUsuário);
                fx.SetApartmentState(ApartmentState.STA);
                fx.Start();
            }
            else
            {
                MessageBox.Show("Contate o administrador para isso!", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void formUsuário()
        {
            //Application.Run(new Form_Cadastro_Usuário());
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja trocar de Usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
                fx = new Thread(formLogin);
                fx.SetApartmentState(ApartmentState.STA);
                fx.Start();
            }           
        }

        private void formLogin()
        {
            Application.Run(new form_Login());
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {           
            if(User_info.usuario_logado == "admin")
            {
                button_Cadastrar_Novo_Usuario.Visible = true;             
            }
            else
            {
                button_Cadastrar_Novo_Usuario.Visible = true;
            }

            //textBox_usuario_logado.Text = "Usuario : " + User_info.usuario_logado + " " + DateTime.Now.ToLongTimeString();
        }

        private void Button_Cadastrar_Novo_Usuario_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Button_Relatório_Click(object sender, EventArgs e)
        {
            Form_status form_Status = new Form_status();
            form_Status.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_relatorio_ocorrencias form_Relatorio_Ocorrencias = new Form_relatorio_ocorrencias();
            form_Relatorio_Ocorrencias.ShowDialog();
        }

        private void TextBox_Nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(Condominio.conectado == true)
            {
                atualizardatagrid();
            }
            if(Condominio.condSelecionado == true)
            {
                textBox_usuario_logado.Text = " " + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString() + " | Usuario : " + User_info.usuario_logado
                + " | Condominio : " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                textBox_usuario_logado.Text = " " + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString() + " | Usuario : " + User_info.usuario_logado
                + " | Condominio : ";
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form_moradores form_Moradores = new Form_moradores();
            form_Moradores.ShowDialog();

            fx = new Thread(form_moradores);
            fx.SetApartmentState(ApartmentState.STA);
            fx.Start();
        }

        private void form_moradores()
        {
            //Application.Run(new Form_moradores());
        }
        
        private void Button_pessoas_Click(object sender, EventArgs e)
        {
            Form_pessoas_uteis form_Pessoas_Uteis = new Form_pessoas_uteis();
            form_Pessoas_Uteis.ShowDialog();

            fx = new Thread(formpessoas);
            fx.SetApartmentState(ApartmentState.STA);
            fx.Start();
        }

        private void formpessoas()
        {
            //Application.Run(new Form_pessoas_uteis());
        }

        private void Button1_logoff_Click(object sender, EventArgs e)
        {            
            var result = MessageBox.Show("Deseja Encerrar o Sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); //Não usar esse botão, recuperar o botão perdido 
            }            
        }

        private void button_relatorio_Click(object sender, EventArgs e)
        {
            relatorio relatorio = new relatorio();
            relatorio.ShowDialog();

            fx = new Thread(form_relatorio);
            fx.SetApartmentState(ApartmentState.STA);
            fx.Start();
        }

        private void form_relatorio()
        {
            
        }
        
        private void buttonAnotacoes_Click(object sender, EventArgs e)
        {
            FormAnotacoes formAnotacoes = new FormAnotacoes();
            formAnotacoes.ShowDialog();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            FormBackup formBackup = new FormBackup();
            formBackup.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
