﻿namespace Projeto_Portaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_usuario_logado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAtt = new System.Windows.Forms.Button();
            this.buttonAddCond = new System.Windows.Forms.Button();
            this.buttonAnotacoes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_moradores = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.button_relatorio = new System.Windows.Forms.Button();
            this.button_Cadastro_Visitantes = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.button_Cadastrar_Novo_Usuario = new System.Windows.Forms.Button();
            this.button_pessoas = new System.Windows.Forms.Button();
            this.button_ocorrencias = new System.Windows.Forms.Button();
            this.button_logoff = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_usuario_logado
            // 
            this.textBox_usuario_logado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_usuario_logado.BackColor = System.Drawing.Color.Gray;
            this.textBox_usuario_logado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_usuario_logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario_logado.ForeColor = System.Drawing.Color.Black;
            this.textBox_usuario_logado.Location = new System.Drawing.Point(457, 709);
            this.textBox_usuario_logado.Name = "textBox_usuario_logado";
            this.textBox_usuario_logado.ReadOnly = true;
            this.textBox_usuario_logado.Size = new System.Drawing.Size(901, 19);
            this.textBox_usuario_logado.TabIndex = 9;
            this.textBox_usuario_logado.TextChanged += new System.EventHandler(this.TextBox_Nome_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = global::Projeto_Portaria.Properties.Resources.edit;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(162, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(44, 32);
            this.buttonEditar.TabIndex = 203;
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonEditar, "Editar");
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAtt
            // 
            this.buttonAtt.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAtt.FlatAppearance.BorderSize = 0;
            this.buttonAtt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtt.ForeColor = System.Drawing.Color.White;
            this.buttonAtt.Image = global::Projeto_Portaria.Properties.Resources.update;
            this.buttonAtt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtt.Location = new System.Drawing.Point(79, 3);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(44, 32);
            this.buttonAtt.TabIndex = 202;
            this.buttonAtt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAtt, "Atualizar");
            this.buttonAtt.UseVisualStyleBackColor = false;
            this.buttonAtt.Click += new System.EventHandler(this.buttonAtt_Click);
            // 
            // buttonAddCond
            // 
            this.buttonAddCond.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddCond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCond.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddCond.FlatAppearance.BorderSize = 0;
            this.buttonAddCond.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAddCond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddCond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddCond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCond.ForeColor = System.Drawing.Color.White;
            this.buttonAddCond.Image = global::Projeto_Portaria.Properties.Resources.add;
            this.buttonAddCond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCond.Location = new System.Drawing.Point(210, 3);
            this.buttonAddCond.Name = "buttonAddCond";
            this.buttonAddCond.Size = new System.Drawing.Size(44, 32);
            this.buttonAddCond.TabIndex = 31;
            this.buttonAddCond.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAddCond, "Adicionar Condominio");
            this.buttonAddCond.UseVisualStyleBackColor = false;
            this.buttonAddCond.Click += new System.EventHandler(this.buttonAddCond_Click);
            // 
            // buttonAnotacoes
            // 
            this.buttonAnotacoes.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnotacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnotacoes.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Projeto_Portaria.Properties.Resources.door_512;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 110);
            this.button3.TabIndex = 28;
            this.button3.Text = "DooR-Acess control";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button3, "Vagalume Soluções");
            this.button3.UseVisualStyleBackColor = false;
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
            this.toolTip1.SetToolTip(this.button_moradores, "Gerenciar Moradores");
            this.button_moradores.UseVisualStyleBackColor = false;
            this.button_moradores.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.BackColor = System.Drawing.Color.Gray;
            this.buttonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBackup.FlatAppearance.BorderSize = 0;
            this.buttonBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.ForeColor = System.Drawing.Color.White;
            this.buttonBackup.Image = global::Projeto_Portaria.Properties.Resources.database;
            this.buttonBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackup.Location = new System.Drawing.Point(12, 514);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(180, 40);
            this.buttonBackup.TabIndex = 1;
            this.buttonBackup.Text = "Backup/Rest";
            this.buttonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonBackup, "Backup/Restaura/Conectar-se");
            this.buttonBackup.UseVisualStyleBackColor = false;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // button_relatorio
            // 
            this.button_relatorio.BackColor = System.Drawing.Color.Transparent;
            this.button_relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.toolTip1.SetToolTip(this.button_relatorio, "Relatorios");
            this.button_relatorio.UseVisualStyleBackColor = false;
            this.button_relatorio.Click += new System.EventHandler(this.button_relatorio_Click);
            // 
            // button_Cadastro_Visitantes
            // 
            this.button_Cadastro_Visitantes.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastro_Visitantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cadastro_Visitantes.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.toolTip1.SetToolTip(this.button_Cadastro_Visitantes, "Entrada/Cadastro Visitantes");
            this.button_Cadastro_Visitantes.UseVisualStyleBackColor = false;
            this.button_Cadastro_Visitantes.Click += new System.EventHandler(this.Button_Cadastro_Visitantes_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Image = global::Projeto_Portaria.Properties.Resources.icon__sair__SYE_icon;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(12, 550);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(180, 41);
            this.buttonSair.TabIndex = 12;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonSair, "Encerrar");
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button_status
            // 
            this.button_status.BackColor = System.Drawing.Color.Transparent;
            this.button_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_status.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // button_Cadastrar_Novo_Usuario
            // 
            this.button_Cadastrar_Novo_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar_Novo_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cadastrar_Novo_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.toolTip1.SetToolTip(this.button_Cadastrar_Novo_Usuario, "Gerenciar Usuários");
            this.button_Cadastrar_Novo_Usuario.UseVisualStyleBackColor = false;
            this.button_Cadastrar_Novo_Usuario.VisibleChanged += new System.EventHandler(this.Button_Cadastrar_Novo_Usuario_VisibleChanged);
            this.button_Cadastrar_Novo_Usuario.Click += new System.EventHandler(this.Button_Cadastrar_Novo_Usuario_Click);
            // 
            // button_pessoas
            // 
            this.button_pessoas.BackColor = System.Drawing.Color.Transparent;
            this.button_pessoas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_pessoas.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // button_ocorrencias
            // 
            this.button_ocorrencias.BackColor = System.Drawing.Color.Transparent;
            this.button_ocorrencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ocorrencias.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // button_logoff
            // 
            this.button_logoff.BackColor = System.Drawing.Color.Transparent;
            this.button_logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_logoff.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Transparent;
            this.buttonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Image = global::Projeto_Portaria.Properties.Resources.cancelar;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(120, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(44, 32);
            this.buttonExcluir.TabIndex = 204;
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonExcluir, "Excluir");
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.buttonAnotacoes);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button_moradores);
            this.panelMenu.Controls.Add(this.buttonBackup);
            this.panelMenu.Controls.Add(this.button_relatorio);
            this.panelMenu.Controls.Add(this.button_Cadastro_Visitantes);
            this.panelMenu.Controls.Add(this.buttonSair);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(196, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 588);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.buttonEditar);
            this.panel2.Controls.Add(this.buttonAtt);
            this.panel2.Controls.Add(this.buttonAddCond);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(195, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 735);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 201;
            this.label1.Text = "Locais";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(245, 687);
            this.dataGridView1.TabIndex = 200;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // visitantesBindingSource
            // 
            this.visitantesBindingSource.DataMember = "visitantes";
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 740);
            this.Controls.Add(this.panel2);
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
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitantesBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button button_moradores;
        private System.Windows.Forms.Button button_relatorio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAnotacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCond;
        private System.Windows.Forms.Button buttonAtt;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
    }
}