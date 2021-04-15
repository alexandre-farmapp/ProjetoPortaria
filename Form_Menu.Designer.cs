namespace Projeto_Portaria
{
    partial class form_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Menu));
            this.visitantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_usuario_logado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button_relatorio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_moradores = new System.Windows.Forms.Button();
            this.button_pessoas = new System.Windows.Forms.Button();
            this.button_logoff = new System.Windows.Forms.Button();
            this.button_ocorrencias = new System.Windows.Forms.Button();
            this.button_Cadastrar_Novo_Usuario = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.button_Cadastro_Visitantes = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonAnotacoes = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.visitantesBindingSource)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // visitantesBindingSource
            // 
            this.visitantesBindingSource.DataMember = "visitantes";
            // 
            // textBox_usuario_logado
            // 
            this.textBox_usuario_logado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_usuario_logado.BackColor = System.Drawing.Color.Gray;
            this.textBox_usuario_logado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_usuario_logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario_logado.ForeColor = System.Drawing.Color.Black;
            this.textBox_usuario_logado.Location = new System.Drawing.Point(400, 709);
            this.textBox_usuario_logado.Name = "textBox_usuario_logado";
            this.textBox_usuario_logado.ReadOnly = true;
            this.textBox_usuario_logado.Size = new System.Drawing.Size(623, 19);
            this.textBox_usuario_logado.TabIndex = 9;
            this.textBox_usuario_logado.TextChanged += new System.EventHandler(this.TextBox_Nome_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Projeto_Portaria.Properties.Resources.door_512;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 110);
            this.button3.TabIndex = 28;
            this.button3.Text = "DooR-Acess control";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button3, "Vagalume Soluções");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_relatorio
            // 
            this.button_relatorio.BackColor = System.Drawing.Color.Transparent;
            this.button_relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_relatorio.FlatAppearance.BorderSize = 0;
            this.button_relatorio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorio.ForeColor = System.Drawing.Color.White;
            this.button_relatorio.Image = global::Projeto_Portaria.Properties.Resources.icon__pesquisar__PRB_icon;
            this.button_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_relatorio.Location = new System.Drawing.Point(12, 348);
            this.button_relatorio.Name = "button_relatorio";
            this.button_relatorio.Size = new System.Drawing.Size(180, 40);
            this.button_relatorio.TabIndex = 25;
            this.button_relatorio.Text = "Pesquisar";
            this.button_relatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_relatorio, "Consultar Moradores");
            this.button_relatorio.UseVisualStyleBackColor = false;
            this.button_relatorio.Click += new System.EventHandler(this.button_relatorio_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Projeto_Portaria.Properties.Resources.icon__sair__SYE_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button1, "Encerrar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Sair_;
            this.button_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sair.FlatAppearance.BorderSize = 0;
            this.button_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.ForeColor = System.Drawing.Color.Transparent;
            this.button_sair.Location = new System.Drawing.Point(1419, 12);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(162, 88);
            this.button_sair.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button_sair, "Encerrar Sistema");
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.Button1_logoff_Click);
            // 
            // button_moradores
            // 
            this.button_moradores.BackColor = System.Drawing.Color.Gray;
            this.button_moradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_moradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_moradores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_moradores.FlatAppearance.BorderSize = 0;
            this.button_moradores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_moradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_moradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_moradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_moradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_moradores.ForeColor = System.Drawing.Color.White;
            this.button_moradores.Image = global::Projeto_Portaria.Properties.Resources.family_icon_cOg_icon;
            this.button_moradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_moradores.Location = new System.Drawing.Point(12, 144);
            this.button_moradores.Name = "button_moradores";
            this.button_moradores.Size = new System.Drawing.Size(180, 45);
            this.button_moradores.TabIndex = 0;
            this.button_moradores.Text = "Moradores";
            this.button_moradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_moradores, "Consultar Moradores");
            this.button_moradores.UseVisualStyleBackColor = false;
            this.button_moradores.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button_pessoas
            // 
            this.button_pessoas.BackColor = System.Drawing.Color.Transparent;
            this.button_pessoas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_pessoas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_pessoas.FlatAppearance.BorderSize = 0;
            this.button_pessoas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_pessoas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_pessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pessoas.ForeColor = System.Drawing.Color.White;
            this.button_pessoas.Image = global::Projeto_Portaria.Properties.Resources.icon__contato__oficial_Bq5_icon1;
            this.button_pessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pessoas.Location = new System.Drawing.Point(12, 306);
            this.button_pessoas.Name = "button_pessoas";
            this.button_pessoas.Size = new System.Drawing.Size(180, 40);
            this.button_pessoas.TabIndex = 5;
            this.button_pessoas.Text = "Contatos";
            this.button_pessoas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_pessoas, "Contatos Condominio");
            this.button_pessoas.UseVisualStyleBackColor = false;
            this.button_pessoas.Click += new System.EventHandler(this.Button_pessoas_Click);
            // 
            // button_logoff
            // 
            this.button_logoff.BackColor = System.Drawing.Color.Transparent;
            this.button_logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_logoff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_logoff.FlatAppearance.BorderSize = 0;
            this.button_logoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_logoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logoff.ForeColor = System.Drawing.Color.White;
            this.button_logoff.Image = global::Projeto_Portaria.Properties.Resources.icon__logoff__wr0_icon;
            this.button_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logoff.Location = new System.Drawing.Point(12, 432);
            this.button_logoff.Name = "button_logoff";
            this.button_logoff.Size = new System.Drawing.Size(180, 41);
            this.button_logoff.TabIndex = 7;
            this.button_logoff.Text = "Logoff";
            this.button_logoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_logoff, "Trocar Usuário do Sistema");
            this.button_logoff.UseVisualStyleBackColor = false;
            this.button_logoff.Click += new System.EventHandler(this.Button_sair_Click);
            // 
            // button_ocorrencias
            // 
            this.button_ocorrencias.BackColor = System.Drawing.Color.Transparent;
            this.button_ocorrencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ocorrencias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ocorrencias.FlatAppearance.BorderSize = 0;
            this.button_ocorrencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ocorrencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ocorrencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ocorrencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ocorrencias.ForeColor = System.Drawing.Color.White;
            this.button_ocorrencias.Image = global::Projeto_Portaria.Properties.Resources.icon__ocorr__ncias__Jh7_icon;
            this.button_ocorrencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ocorrencias.Location = new System.Drawing.Point(12, 264);
            this.button_ocorrencias.Name = "button_ocorrencias";
            this.button_ocorrencias.Size = new System.Drawing.Size(180, 40);
            this.button_ocorrencias.TabIndex = 4;
            this.button_ocorrencias.Text = "Ocorrências";
            this.button_ocorrencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_ocorrencias, "Realizar Ocorrência");
            this.button_ocorrencias.UseVisualStyleBackColor = false;
            this.button_ocorrencias.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_Cadastrar_Novo_Usuario
            // 
            this.button_Cadastrar_Novo_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar_Novo_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cadastrar_Novo_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Cadastrar_Novo_Usuario.FlatAppearance.BorderSize = 0;
            this.button_Cadastrar_Novo_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cadastrar_Novo_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cadastrar_Novo_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastrar_Novo_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar_Novo_Usuario.ForeColor = System.Drawing.Color.White;
            this.button_Cadastrar_Novo_Usuario.Image = global::Projeto_Portaria.Properties.Resources.icon__usu__rios__Qwf_icon1;
            this.button_Cadastrar_Novo_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cadastrar_Novo_Usuario.Location = new System.Drawing.Point(12, 390);
            this.button_Cadastrar_Novo_Usuario.Name = "button_Cadastrar_Novo_Usuario";
            this.button_Cadastrar_Novo_Usuario.Size = new System.Drawing.Size(180, 40);
            this.button_Cadastrar_Novo_Usuario.TabIndex = 6;
            this.button_Cadastrar_Novo_Usuario.Text = "Usuarios";
            this.button_Cadastrar_Novo_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_Cadastrar_Novo_Usuario, "Cadastro de Usuários");
            this.button_Cadastrar_Novo_Usuario.UseVisualStyleBackColor = false;
            this.button_Cadastrar_Novo_Usuario.VisibleChanged += new System.EventHandler(this.Button_Cadastrar_Novo_Usuario_VisibleChanged);
            this.button_Cadastrar_Novo_Usuario.Click += new System.EventHandler(this.Button_Cadastrar_Novo_Usuario_Click);
            // 
            // button_status
            // 
            this.button_status.BackColor = System.Drawing.Color.Transparent;
            this.button_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_status.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_status.FlatAppearance.BorderSize = 0;
            this.button_status.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_status.ForeColor = System.Drawing.Color.White;
            this.button_status.Image = global::Projeto_Portaria.Properties.Resources.icon__status__oficial_lf9_icon;
            this.button_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_status.Location = new System.Drawing.Point(12, 227);
            this.button_status.Name = "button_status";
            this.button_status.Size = new System.Drawing.Size(180, 40);
            this.button_status.TabIndex = 3;
            this.button_status.Text = "Status";
            this.button_status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_status, "Status de Entrada e Saída");
            this.button_status.UseVisualStyleBackColor = false;
            this.button_status.Click += new System.EventHandler(this.Button_Relatório_Click);
            // 
            // button_Cadastro_Visitantes
            // 
            this.button_Cadastro_Visitantes.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastro_Visitantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cadastro_Visitantes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Cadastro_Visitantes.FlatAppearance.BorderSize = 0;
            this.button_Cadastro_Visitantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cadastro_Visitantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cadastro_Visitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastro_Visitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastro_Visitantes.ForeColor = System.Drawing.Color.White;
            this.button_Cadastro_Visitantes.Image = global::Projeto_Portaria.Properties.Resources.icon__visitantes__Qf6_icon;
            this.button_Cadastro_Visitantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cadastro_Visitantes.Location = new System.Drawing.Point(12, 186);
            this.button_Cadastro_Visitantes.Name = "button_Cadastro_Visitantes";
            this.button_Cadastro_Visitantes.Size = new System.Drawing.Size(180, 40);
            this.button_Cadastro_Visitantes.TabIndex = 2;
            this.button_Cadastro_Visitantes.Text = "Visitantes";
            this.button_Cadastro_Visitantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_Cadastro_Visitantes, "Cadastro de Visitantes");
            this.button_Cadastro_Visitantes.UseVisualStyleBackColor = false;
            this.button_Cadastro_Visitantes.Click += new System.EventHandler(this.Button_Cadastro_Visitantes_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.BackColor = System.Drawing.Color.Gray;
            this.buttonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBackup.FlatAppearance.BorderSize = 0;
            this.buttonBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.ForeColor = System.Drawing.Color.White;
            this.buttonBackup.Image = global::Projeto_Portaria.Properties.Resources.icon__cadastro_moradores__JlK_icon;
            this.buttonBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackup.Location = new System.Drawing.Point(12, 514);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(180, 40);
            this.buttonBackup.TabIndex = 1;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonBackup, "Cadastro de Moradores");
            this.buttonBackup.UseVisualStyleBackColor = false;
            this.buttonBackup.Click += new System.EventHandler(this.Button_Cadastro_Moradores_Click);
            // 
            // buttonAnotacoes
            // 
            this.buttonAnotacoes.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnotacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnotacoes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAnotacoes.FlatAppearance.BorderSize = 0;
            this.buttonAnotacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAnotacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnotacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnotacoes.ForeColor = System.Drawing.Color.White;
            this.buttonAnotacoes.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnotacoes.Image")));
            this.buttonAnotacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnotacoes.Location = new System.Drawing.Point(12, 474);
            this.buttonAnotacoes.Name = "buttonAnotacoes";
            this.buttonAnotacoes.Size = new System.Drawing.Size(180, 41);
            this.buttonAnotacoes.TabIndex = 29;
            this.buttonAnotacoes.Text = "Anotações";
            this.buttonAnotacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAnotacoes, "Anotações");
            this.buttonAnotacoes.UseVisualStyleBackColor = false;
            this.buttonAnotacoes.Click += new System.EventHandler(this.buttonAnotacoes_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.buttonAnotacoes);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button_moradores);
            this.panelMenu.Controls.Add(this.buttonBackup);
            this.panelMenu.Controls.Add(this.button_relatorio);
            this.panelMenu.Controls.Add(this.button_Cadastro_Visitantes);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button_status);
            this.panelMenu.Controls.Add(this.button_Cadastrar_Novo_Usuario);
            this.panelMenu.Controls.Add(this.button_pessoas);
            this.panelMenu.Controls.Add(this.button_ocorrencias);
            this.panelMenu.Controls.Add(this.button_logoff);
            this.panelMenu.Location = new System.Drawing.Point(-1, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 741);
            this.panelMenu.TabIndex = 29;
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 740);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.textBox_usuario_logado);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DooR-Controle de Acesso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitantesBindingSource)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button button_Cadastro_Visitantes;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Button button_Cadastrar_Novo_Usuario;
        private System.Windows.Forms.Button button_ocorrencias;
        private System.Windows.Forms.Button button_logoff;
        private System.Windows.Forms.BindingSource visitantesBindingSource;
        private System.Windows.Forms.TextBox textBox_usuario_logado;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_pessoas;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_moradores;
        private System.Windows.Forms.Button button_relatorio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAnotacoes;
    }
}