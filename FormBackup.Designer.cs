namespace Projeto_Portaria
{
    partial class FormBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConectar = new System.Windows.Forms.Button();
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            this.textBoxBanco = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxRestaurar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonProcurarArq = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.textBoxImportar = new System.Windows.Forms.TextBox();
            this.labelCaminho = new System.Windows.Forms.Label();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxCaminhoCriar = new System.Windows.Forms.TextBox();
            this.groupBoxCriarBackup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConectarLocalBD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonlocalBD = new System.Windows.Forms.Button();
            this.textBoxCaminhoLocalBD = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBoxRestaurar.SuspendLayout();
            this.groupBoxCriarBackup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConectar.Location = new System.Drawing.Point(230, 140);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(95, 37);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServidor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxServidor.Location = new System.Drawing.Point(116, 27);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(209, 22);
            this.textBoxServidor.TabIndex = 1;
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBanco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxBanco.Location = new System.Drawing.Point(116, 56);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(209, 22);
            this.textBoxBanco.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxUsuario.Location = new System.Drawing.Point(116, 84);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(209, 22);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSenha.Location = new System.Drawing.Point(116, 112);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(209, 22);
            this.textBoxSenha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Banco de Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // groupBoxRestaurar
            // 
            this.groupBoxRestaurar.Controls.Add(this.label5);
            this.groupBoxRestaurar.Controls.Add(this.buttonProcurarArq);
            this.groupBoxRestaurar.Controls.Add(this.buttonImportar);
            this.groupBoxRestaurar.Controls.Add(this.textBoxImportar);
            this.groupBoxRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRestaurar.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxRestaurar.Location = new System.Drawing.Point(19, 171);
            this.groupBoxRestaurar.Name = "groupBoxRestaurar";
            this.groupBoxRestaurar.Size = new System.Drawing.Size(599, 136);
            this.groupBoxRestaurar.TabIndex = 23;
            this.groupBoxRestaurar.TabStop = false;
            this.groupBoxRestaurar.Text = "Importar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Caminho";
            // 
            // buttonProcurarArq
            // 
            this.buttonProcurarArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurarArq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProcurarArq.Location = new System.Drawing.Point(487, 40);
            this.buttonProcurarArq.Name = "buttonProcurarArq";
            this.buttonProcurarArq.Size = new System.Drawing.Size(95, 37);
            this.buttonProcurarArq.TabIndex = 15;
            this.buttonProcurarArq.Text = "Procurar";
            this.buttonProcurarArq.UseVisualStyleBackColor = true;
            this.buttonProcurarArq.Click += new System.EventHandler(this.buttonProcurarArq_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonImportar.Location = new System.Drawing.Point(487, 83);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(95, 37);
            this.buttonImportar.TabIndex = 3;
            this.buttonImportar.Text = "Restaurar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // textBoxImportar
            // 
            this.textBoxImportar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxImportar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxImportar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxImportar.Location = new System.Drawing.Point(23, 40);
            this.textBoxImportar.Name = "textBoxImportar";
            this.textBoxImportar.Size = new System.Drawing.Size(458, 22);
            this.textBoxImportar.TabIndex = 12;
            // 
            // labelCaminho
            // 
            this.labelCaminho.AutoSize = true;
            this.labelCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaminho.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCaminho.Location = new System.Drawing.Point(40, 51);
            this.labelCaminho.Name = "labelCaminho";
            this.labelCaminho.Size = new System.Drawing.Size(55, 13);
            this.labelCaminho.TabIndex = 21;
            this.labelCaminho.Text = "Caminho";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProcurar.Location = new System.Drawing.Point(487, 40);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(95, 37);
            this.buttonProcurar.TabIndex = 15;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalvar.Location = new System.Drawing.Point(487, 83);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(95, 37);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxCaminhoCriar
            // 
            this.textBoxCaminhoCriar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCaminhoCriar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCaminhoCriar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCaminhoCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaminhoCriar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCaminhoCriar.Location = new System.Drawing.Point(23, 40);
            this.textBoxCaminhoCriar.Name = "textBoxCaminhoCriar";
            this.textBoxCaminhoCriar.Size = new System.Drawing.Size(458, 22);
            this.textBoxCaminhoCriar.TabIndex = 12;
            // 
            // groupBoxCriarBackup
            // 
            this.groupBoxCriarBackup.Controls.Add(this.buttonProcurar);
            this.groupBoxCriarBackup.Controls.Add(this.buttonSalvar);
            this.groupBoxCriarBackup.Controls.Add(this.textBoxCaminhoCriar);
            this.groupBoxCriarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCriarBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxCriarBackup.Location = new System.Drawing.Point(19, 26);
            this.groupBoxCriarBackup.Name = "groupBoxCriarBackup";
            this.groupBoxCriarBackup.Size = new System.Drawing.Size(599, 136);
            this.groupBoxCriarBackup.TabIndex = 22;
            this.groupBoxCriarBackup.TabStop = false;
            this.groupBoxCriarBackup.Text = "Exportar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDesconectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonConectar);
            this.groupBox1.Controls.Add(this.textBoxServidor);
            this.groupBox1.Controls.Add(this.textBoxBanco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(366, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 189);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectar-se";
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDesconectar.Location = new System.Drawing.Point(116, 140);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(95, 37);
            this.buttonDesconectar.TabIndex = 9;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Visible = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.buttonSair);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 550);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup/Restaurar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonConectarLocalBD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonlocalBD);
            this.groupBox3.Controls.Add(this.textBoxCaminhoLocalBD);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(13, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 189);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Banco local";
            // 
            // buttonConectarLocalBD
            // 
            this.buttonConectarLocalBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectarLocalBD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConectarLocalBD.Location = new System.Drawing.Point(120, 84);
            this.buttonConectarLocalBD.Name = "buttonConectarLocalBD";
            this.buttonConectarLocalBD.Size = new System.Drawing.Size(95, 37);
            this.buttonConectarLocalBD.TabIndex = 9;
            this.buttonConectarLocalBD.Text = "Conectar";
            this.buttonConectarLocalBD.UseVisualStyleBackColor = true;
            this.buttonConectarLocalBD.Click += new System.EventHandler(this.buttonConectarLocalBD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caminho";
            // 
            // buttonlocalBD
            // 
            this.buttonlocalBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlocalBD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonlocalBD.Location = new System.Drawing.Point(230, 84);
            this.buttonlocalBD.Name = "buttonlocalBD";
            this.buttonlocalBD.Size = new System.Drawing.Size(95, 37);
            this.buttonlocalBD.TabIndex = 0;
            this.buttonlocalBD.Text = "Procurar";
            this.buttonlocalBD.UseVisualStyleBackColor = true;
            this.buttonlocalBD.Click += new System.EventHandler(this.buttonlocalBD_Click);
            // 
            // textBoxCaminhoLocalBD
            // 
            this.textBoxCaminhoLocalBD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCaminhoLocalBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaminhoLocalBD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCaminhoLocalBD.Location = new System.Drawing.Point(23, 56);
            this.textBoxCaminhoLocalBD.Name = "textBoxCaminhoLocalBD";
            this.textBoxCaminhoLocalBD.Size = new System.Drawing.Size(302, 22);
            this.textBoxCaminhoLocalBD.TabIndex = 1;
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Voltar_;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSair.Location = new System.Drawing.Point(649, 507);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(59, 37);
            this.buttonSair.TabIndex = 20;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(740, 568);
            this.Controls.Add(this.groupBoxRestaurar);
            this.Controls.Add(this.labelCaminho);
            this.Controls.Add(this.groupBoxCriarBackup);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Restaurar";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            this.groupBoxRestaurar.ResumeLayout(false);
            this.groupBoxRestaurar.PerformLayout();
            this.groupBoxCriarBackup.ResumeLayout(false);
            this.groupBoxCriarBackup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.TextBox textBoxServidor;
        private System.Windows.Forms.TextBox textBoxBanco;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxRestaurar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonProcurarArq;
        private System.Windows.Forms.Button buttonImportar;
        private System.Windows.Forms.TextBox textBoxImportar;
        private System.Windows.Forms.Label labelCaminho;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxCaminhoCriar;
        private System.Windows.Forms.GroupBox groupBoxCriarBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonConectarLocalBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonlocalBD;
        private System.Windows.Forms.TextBox textBoxCaminhoLocalBD;
    }
}