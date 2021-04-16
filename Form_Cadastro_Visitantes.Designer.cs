namespace Projeto_Portaria
{
    partial class Cadastro_de_Visitantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Visitantes));
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Bloco = new System.Windows.Forms.Label();
            this.label_Celular = new System.Windows.Forms.Label();
            this.groupBox_Dados_Pessoais = new System.Windows.Forms.GroupBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.textBox_visitado = new System.Windows.Forms.TextBox();
            this.maskedTextBox_celular = new System.Windows.Forms.MaskedTextBox();
            this.label_pequisa_unidade = new System.Windows.Forms.Label();
            this.textBox_entrada = new System.Windows.Forms.TextBox();
            this.textBox_nome_visitado = new System.Windows.Forms.TextBox();
            this.label_entrada = new System.Windows.Forms.Label();
            this.label_pesquisa_visitado = new System.Windows.Forms.Label();
            this.textBox_unidade = new System.Windows.Forms.TextBox();
            this.textBox_unidade_visitado = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label_Apartamento = new System.Windows.Forms.Label();
            this.button_pesquisar_morador = new System.Windows.Forms.Button();
            this.button_datagrid_visible = new System.Windows.Forms.Button();
            this.dataGridView_pesquisa_morador = new System.Windows.Forms.DataGridView();/*
            this.moradoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bdportariaDataSetlistamorador1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moradoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);*/
            this.groupBox_Dados_Veiculo = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_placa = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.label_Modelo_Veiculo = new System.Windows.Forms.Label();
            this.label_PLaca_Veiculo = new System.Windows.Forms.Label();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.pictureBox_Foto_Visitante = new System.Windows.Forms.PictureBox();
            this.button_Adicionar_Foto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_observacoes = new System.Windows.Forms.TextBox();
            this.button_voltar_menu = new System.Windows.Forms.Button();
            this.textBox_nome_visitante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBlocoRua = new System.Windows.Forms.TextBox();
            this.labelBlocoRua = new System.Windows.Forms.Label();
            this.groupBox_Dados_Pessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pesquisa_morador)).BeginInit();/*
            ((System.ComponentModel.ISupportInitialize)(this.moradoresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdportariaDataSetlistamorador1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoresBindingSource)).BeginInit();*/
            this.groupBox_Dados_Veiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto_Visitante)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.Location = new System.Drawing.Point(27, 29);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(38, 13);
            this.label_Nome.TabIndex = 0;
            this.label_Nome.Text = "Nome:";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPF.Location = new System.Drawing.Point(27, 60);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(30, 13);
            this.label_CPF.TabIndex = 1;
            this.label_CPF.Text = "CPF:";
            // 
            // label_Bloco
            // 
            this.label_Bloco.AutoSize = true;
            this.label_Bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bloco.Location = new System.Drawing.Point(53, 105);
            this.label_Bloco.Name = "label_Bloco";
            this.label_Bloco.Size = new System.Drawing.Size(47, 13);
            this.label_Bloco.TabIndex = 2;
            this.label_Bloco.Text = "Unidade";
            // 
            // label_Celular
            // 
            this.label_Celular.AutoSize = true;
            this.label_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Celular.Location = new System.Drawing.Point(199, 60);
            this.label_Celular.Name = "label_Celular";
            this.label_Celular.Size = new System.Drawing.Size(42, 13);
            this.label_Celular.TabIndex = 7;
            this.label_Celular.Text = "Celular:";
            this.label_Celular.Click += new System.EventHandler(this.Label_Celular_Click);
            // 
            // groupBox_Dados_Pessoais
            // 
            this.groupBox_Dados_Pessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox_Dados_Pessoais.Controls.Add(this.labelBlocoRua);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBoxBlocoRua);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_cpf);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_visitado);
            this.groupBox_Dados_Pessoais.Controls.Add(this.maskedTextBox_celular);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_pequisa_unidade);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_entrada);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_nome_visitado);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_entrada);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Celular);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_pesquisa_visitado);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_unidade);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_unidade_visitado);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Nome);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Nome);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_CPF);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Apartamento);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Bloco);
            this.groupBox_Dados_Pessoais.Controls.Add(this.button_pesquisar_morador);
            this.groupBox_Dados_Pessoais.Controls.Add(this.button_datagrid_visible);
            this.groupBox_Dados_Pessoais.Controls.Add(this.dataGridView_pesquisa_morador);
            this.groupBox_Dados_Pessoais.ForeColor = System.Drawing.Color.White;
            this.groupBox_Dados_Pessoais.Location = new System.Drawing.Point(36, 203);
            this.groupBox_Dados_Pessoais.Name = "groupBox_Dados_Pessoais";
            this.groupBox_Dados_Pessoais.Size = new System.Drawing.Size(414, 190);
            this.groupBox_Dados_Pessoais.TabIndex = 1;
            this.groupBox_Dados_Pessoais.TabStop = false;
            this.groupBox_Dados_Pessoais.Text = "Dados Pessoais";
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cpf.Location = new System.Drawing.Point(63, 60);
            this.textBox_cpf.MaxLength = 14;
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(130, 24);
            this.textBox_cpf.TabIndex = 67;
            // 
            // textBox_visitado
            // 
            this.textBox_visitado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_visitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_visitado.Location = new System.Drawing.Point(106, 126);
            this.textBox_visitado.Name = "textBox_visitado";
            this.textBox_visitado.Size = new System.Drawing.Size(192, 24);
            this.textBox_visitado.TabIndex = 61;
            // 
            // maskedTextBox_celular
            // 
            this.maskedTextBox_celular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maskedTextBox_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_celular.Location = new System.Drawing.Point(252, 60);
            this.maskedTextBox_celular.Mask = "(00)00000-0000";
            this.maskedTextBox_celular.Name = "maskedTextBox_celular";
            this.maskedTextBox_celular.Size = new System.Drawing.Size(136, 24);
            this.maskedTextBox_celular.TabIndex = 5;
            // 
            // label_pequisa_unidade
            // 
            this.label_pequisa_unidade.AutoSize = true;
            this.label_pequisa_unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pequisa_unidade.Location = new System.Drawing.Point(18, 29);
            this.label_pequisa_unidade.Name = "label_pequisa_unidade";
            this.label_pequisa_unidade.Size = new System.Drawing.Size(47, 13);
            this.label_pequisa_unidade.TabIndex = 62;
            this.label_pequisa_unidade.Text = "Unidade";
            this.label_pequisa_unidade.Visible = false;
            // 
            // textBox_entrada
            // 
            this.textBox_entrada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_entrada.Enabled = false;
            this.textBox_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_entrada.Location = new System.Drawing.Point(132, 156);
            this.textBox_entrada.Name = "textBox_entrada";
            this.textBox_entrada.ReadOnly = true;
            this.textBox_entrada.Size = new System.Drawing.Size(181, 24);
            this.textBox_entrada.TabIndex = 60;
            this.textBox_entrada.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox_nome_visitado
            // 
            this.textBox_nome_visitado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_nome_visitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_visitado.Location = new System.Drawing.Point(177, 22);
            this.textBox_nome_visitado.Name = "textBox_nome_visitado";
            this.textBox_nome_visitado.Size = new System.Drawing.Size(188, 24);
            this.textBox_nome_visitado.TabIndex = 66;
            this.textBox_nome_visitado.Visible = false;
            // 
            // label_entrada
            // 
            this.label_entrada.AutoSize = true;
            this.label_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entrada.Location = new System.Drawing.Point(27, 160);
            this.label_entrada.Name = "label_entrada";
            this.label_entrada.Size = new System.Drawing.Size(97, 13);
            this.label_entrada.TabIndex = 10;
            this.label_entrada.Text = "Data/Hora entrada";
            // 
            // label_pesquisa_visitado
            // 
            this.label_pesquisa_visitado.AutoSize = true;
            this.label_pesquisa_visitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisa_visitado.Location = new System.Drawing.Point(127, 29);
            this.label_pesquisa_visitado.Name = "label_pesquisa_visitado";
            this.label_pesquisa_visitado.Size = new System.Drawing.Size(44, 13);
            this.label_pesquisa_visitado.TabIndex = 63;
            this.label_pesquisa_visitado.Text = "Visitado";
            this.label_pesquisa_visitado.Visible = false;
            // 
            // textBox_unidade
            // 
            this.textBox_unidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_unidade.Location = new System.Drawing.Point(106, 98);
            this.textBox_unidade.Name = "textBox_unidade";
            this.textBox_unidade.Size = new System.Drawing.Size(49, 24);
            this.textBox_unidade.TabIndex = 6;
            // 
            // textBox_unidade_visitado
            // 
            this.textBox_unidade_visitado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_unidade_visitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_unidade_visitado.Location = new System.Drawing.Point(71, 23);
            this.textBox_unidade_visitado.Name = "textBox_unidade_visitado";
            this.textBox_unidade_visitado.Size = new System.Drawing.Size(49, 24);
            this.textBox_unidade_visitado.TabIndex = 64;
            this.textBox_unidade_visitado.Visible = false;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(80, 22);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(285, 24);
            this.textBox_Nome.TabIndex = 3;
            // 
            // label_Apartamento
            // 
            this.label_Apartamento.AutoSize = true;
            this.label_Apartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apartamento.Location = new System.Drawing.Point(53, 133);
            this.label_Apartamento.Name = "label_Apartamento";
            this.label_Apartamento.Size = new System.Drawing.Size(44, 13);
            this.label_Apartamento.TabIndex = 3;
            this.label_Apartamento.Text = "Visitado";
            // 
            // button_pesquisar_morador
            // 
            this.button_pesquisar_morador.BackColor = System.Drawing.Color.Transparent;
            this.button_pesquisar_morador.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Pesquisar_;
            this.button_pesquisar_morador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_pesquisar_morador.FlatAppearance.BorderSize = 0;
            this.button_pesquisar_morador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_pesquisar_morador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_pesquisar_morador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisar_morador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pesquisar_morador.Location = new System.Drawing.Point(371, 16);
            this.button_pesquisar_morador.Name = "button_pesquisar_morador";
            this.button_pesquisar_morador.Size = new System.Drawing.Size(30, 30);
            this.button_pesquisar_morador.TabIndex = 65;
            this.button_pesquisar_morador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pesquisar_morador.UseVisualStyleBackColor = false;
            this.button_pesquisar_morador.Visible = false;
            this.button_pesquisar_morador.Click += new System.EventHandler(this.Button_pesquisar_morador_Click);
            // 
            // button_datagrid_visible
            // 
            this.button_datagrid_visible.BackColor = System.Drawing.Color.Transparent;
            this.button_datagrid_visible.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Pesquisar_;
            this.button_datagrid_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_datagrid_visible.FlatAppearance.BorderSize = 0;
            this.button_datagrid_visible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_datagrid_visible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_datagrid_visible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_datagrid_visible.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_datagrid_visible.Location = new System.Drawing.Point(304, 105);
            this.button_datagrid_visible.Name = "button_datagrid_visible";
            this.button_datagrid_visible.Size = new System.Drawing.Size(30, 30);
            this.button_datagrid_visible.TabIndex = 15;
            this.button_datagrid_visible.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_datagrid_visible.UseVisualStyleBackColor = false;
            this.button_datagrid_visible.Click += new System.EventHandler(this.Button_datagrid_visible_Click);
            // 
            // dataGridView_pesquisa_morador
            // 
            this.dataGridView_pesquisa_morador.AllowUserToAddRows = false;
            this.dataGridView_pesquisa_morador.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_pesquisa_morador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_pesquisa_morador.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_pesquisa_morador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_pesquisa_morador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_pesquisa_morador.Location = new System.Drawing.Point(8, 52);
            this.dataGridView_pesquisa_morador.Name = "dataGridView_pesquisa_morador";
            this.dataGridView_pesquisa_morador.ReadOnly = true;
            this.dataGridView_pesquisa_morador.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_pesquisa_morador.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_pesquisa_morador.Size = new System.Drawing.Size(380, 132);
            this.dataGridView_pesquisa_morador.TabIndex = 14;
            this.dataGridView_pesquisa_morador.Visible = false;
            this.dataGridView_pesquisa_morador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_pesquisa_morador_CellContentClick);
            // 
            // moradoresBindingSource2
            /*
            this.moradoresBindingSource2.DataMember = "moradores";
            this.moradoresBindingSource2.DataSource = this.bdportariaDataSetlistamorador1BindingSource;
            // 
            // moradoresBindingSource1
            // 
            this.moradoresBindingSource1.DataMember = "moradores";
            this.moradoresBindingSource1.DataSource = this.bdportariaDataSetlistamorador1BindingSource;*/
            // 
            // groupBox_Dados_Veiculo
            // 
            this.groupBox_Dados_Veiculo.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Dados_Veiculo.Controls.Add(this.maskedTextBox_placa);
            this.groupBox_Dados_Veiculo.Controls.Add(this.textBox_Modelo);
            this.groupBox_Dados_Veiculo.Controls.Add(this.label_Modelo_Veiculo);
            this.groupBox_Dados_Veiculo.Controls.Add(this.label_PLaca_Veiculo);
            this.groupBox_Dados_Veiculo.ForeColor = System.Drawing.Color.White;
            this.groupBox_Dados_Veiculo.Location = new System.Drawing.Point(36, 398);
            this.groupBox_Dados_Veiculo.Name = "groupBox_Dados_Veiculo";
            this.groupBox_Dados_Veiculo.Size = new System.Drawing.Size(414, 52);
            this.groupBox_Dados_Veiculo.TabIndex = 3;
            this.groupBox_Dados_Veiculo.TabStop = false;
            this.groupBox_Dados_Veiculo.Text = "Dados do Veiculo";
            this.groupBox_Dados_Veiculo.Enter += new System.EventHandler(this.GroupBox_Dados_Veiculo_Enter);
            // 
            // maskedTextBox_placa
            // 
            this.maskedTextBox_placa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maskedTextBox_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_placa.Location = new System.Drawing.Point(237, 19);
            this.maskedTextBox_placa.Mask = "aaa-0000";
            this.maskedTextBox_placa.Name = "maskedTextBox_placa";
            this.maskedTextBox_placa.Size = new System.Drawing.Size(74, 24);
            this.maskedTextBox_placa.TabIndex = 9;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Modelo.Location = new System.Drawing.Point(80, 19);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(78, 24);
            this.textBox_Modelo.TabIndex = 8;
            // 
            // label_Modelo_Veiculo
            // 
            this.label_Modelo_Veiculo.AutoSize = true;
            this.label_Modelo_Veiculo.Location = new System.Drawing.Point(29, 26);
            this.label_Modelo_Veiculo.Name = "label_Modelo_Veiculo";
            this.label_Modelo_Veiculo.Size = new System.Drawing.Size(45, 13);
            this.label_Modelo_Veiculo.TabIndex = 4;
            this.label_Modelo_Veiculo.Text = "Modelo:";
            // 
            // label_PLaca_Veiculo
            // 
            this.label_PLaca_Veiculo.AutoSize = true;
            this.label_PLaca_Veiculo.Location = new System.Drawing.Point(183, 26);
            this.label_PLaca_Veiculo.Name = "label_PLaca_Veiculo";
            this.label_PLaca_Veiculo.Size = new System.Drawing.Size(37, 13);
            this.label_PLaca_Veiculo.TabIndex = 1;
            this.label_PLaca_Veiculo.Text = "Placa:";
            // 
            // button_Registrar
            // 
            this.button_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.button_Registrar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Save_icon;
            this.button_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Registrar.FlatAppearance.BorderSize = 0;
            this.button_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Registrar.Location = new System.Drawing.Point(584, 503);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(49, 38);
            this.button_Registrar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button_Registrar, "Registrar Visitantes");
            this.button_Registrar.UseVisualStyleBackColor = false;
            this.button_Registrar.Click += new System.EventHandler(this.Button_Registrar_Click);
            // 
            // pictureBox_Foto_Visitante
            // 
            this.pictureBox_Foto_Visitante.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Foto_Visitante.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Usuario;
            this.pictureBox_Foto_Visitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Foto_Visitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Foto_Visitante.InitialImage = null;
            this.pictureBox_Foto_Visitante.Location = new System.Drawing.Point(452, 198);
            this.pictureBox_Foto_Visitante.Name = "pictureBox_Foto_Visitante";
            this.pictureBox_Foto_Visitante.Size = new System.Drawing.Size(219, 231);
            this.pictureBox_Foto_Visitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Foto_Visitante.TabIndex = 13;
            this.pictureBox_Foto_Visitante.TabStop = false;
            this.pictureBox_Foto_Visitante.Click += new System.EventHandler(this.PictureBox_Foto_Visitante_Click);
            // 
            // button_Adicionar_Foto
            // 
            this.button_Adicionar_Foto.BackColor = System.Drawing.Color.Transparent;
            this.button_Adicionar_Foto.BackgroundImage = global::Projeto_Portaria.Properties.Resources.explorer;
            this.button_Adicionar_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Adicionar_Foto.FlatAppearance.BorderSize = 0;
            this.button_Adicionar_Foto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Adicionar_Foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Adicionar_Foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Adicionar_Foto.ForeColor = System.Drawing.Color.White;
            this.button_Adicionar_Foto.Location = new System.Drawing.Point(638, 406);
            this.button_Adicionar_Foto.Name = "button_Adicionar_Foto";
            this.button_Adicionar_Foto.Size = new System.Drawing.Size(33, 23);
            this.button_Adicionar_Foto.TabIndex = 11;
            this.button_Adicionar_Foto.UseVisualStyleBackColor = false;
            this.button_Adicionar_Foto.Click += new System.EventHandler(this.Button_Adicionar_Foto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox_observacoes);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // textBox_observacoes
            // 
            this.textBox_observacoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_observacoes.Location = new System.Drawing.Point(11, 19);
            this.textBox_observacoes.Multiline = true;
            this.textBox_observacoes.Name = "textBox_observacoes";
            this.textBox_observacoes.Size = new System.Drawing.Size(392, 68);
            this.textBox_observacoes.TabIndex = 10;
            // 
            // button_voltar_menu
            // 
            this.button_voltar_menu.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar_menu.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Voltar_;
            this.button_voltar_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_voltar_menu.FlatAppearance.BorderSize = 0;
            this.button_voltar_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_voltar_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_voltar_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar_menu.Location = new System.Drawing.Point(640, 515);
            this.button_voltar_menu.Name = "button_voltar_menu";
            this.button_voltar_menu.Size = new System.Drawing.Size(57, 38);
            this.button_voltar_menu.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button_voltar_menu, "Voltar Menu Anterior");
            this.button_voltar_menu.UseVisualStyleBackColor = false;
            this.button_voltar_menu.Click += new System.EventHandler(this.Button_voltar_menu_Click);
            // 
            // textBox_nome_visitante
            // 
            this.textBox_nome_visitante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_nome_visitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_visitante.Location = new System.Drawing.Point(93, 25);
            this.textBox_nome_visitante.Name = "textBox_nome_visitante";
            this.textBox_nome_visitante.Size = new System.Drawing.Size(285, 26);
            this.textBox_nome_visitante.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(36, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 142);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.button_pesquisar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Pesquisar_;
            this.button_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_pesquisar.FlatAppearance.BorderSize = 0;
            this.button_pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pesquisar.Location = new System.Drawing.Point(385, 19);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(30, 30);
            this.button_pesquisar.TabIndex = 1;
            this.button_pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_Adicionar_Foto);
            this.groupBox2.Controls.Add(this.button_Registrar);
            this.groupBox2.Controls.Add(this.pictureBox_Foto_Visitante);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 548);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada de Visitantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(476, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "depois a localize pelo botão acima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Unidade";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(449, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "OBS: tire a foto pelo software de cameras";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxBlocoRua
            // 
            this.textBoxBlocoRua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxBlocoRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlocoRua.Location = new System.Drawing.Point(229, 96);
            this.textBoxBlocoRua.Name = "textBoxBlocoRua";
            this.textBoxBlocoRua.Size = new System.Drawing.Size(69, 24);
            this.textBoxBlocoRua.TabIndex = 68;
            // 
            // labelBlocoRua
            // 
            this.labelBlocoRua.AutoSize = true;
            this.labelBlocoRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlocoRua.Location = new System.Drawing.Point(161, 105);
            this.labelBlocoRua.Name = "labelBlocoRua";
            this.labelBlocoRua.Size = new System.Drawing.Size(59, 13);
            this.labelBlocoRua.TabIndex = 69;
            this.labelBlocoRua.Text = "Bloco/Rua";
            // 
            // Cadastro_de_Visitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 572);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_nome_visitante);
            this.Controls.Add(this.button_voltar_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Dados_Veiculo);
            this.Controls.Add(this.groupBox_Dados_Pessoais);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_de_Visitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Visitantes";
            this.Load += new System.EventHandler(this.Cadastro_de_Visitantes_Load);
            this.groupBox_Dados_Pessoais.ResumeLayout(false);
            this.groupBox_Dados_Pessoais.PerformLayout();/*
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pesquisa_morador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdportariaDataSetlistamorador1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoresBindingSource)).EndInit();*/
            this.groupBox_Dados_Veiculo.ResumeLayout(false);
            this.groupBox_Dados_Veiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto_Visitante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_Bloco;
        private System.Windows.Forms.Label label_Celular;
        private System.Windows.Forms.GroupBox groupBox_Dados_Pessoais;
        private System.Windows.Forms.TextBox textBox_unidade;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.GroupBox groupBox_Dados_Veiculo;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.Label label_Modelo_Veiculo;
        private System.Windows.Forms.Label label_PLaca_Veiculo;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.PictureBox pictureBox_Foto_Visitante;
        private System.Windows.Forms.Button button_Adicionar_Foto;
        private System.Windows.Forms.Label label_Apartamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_observacoes;
        private System.Windows.Forms.Button button_voltar_menu;
        private System.Windows.Forms.TextBox textBox_entrada;
        private System.Windows.Forms.Label label_entrada;
        private System.Windows.Forms.TextBox textBox_nome_visitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_pesquisar;/*
        private System.Windows.Forms.BindingSource moradoresBindingSource;
        private System.Windows.Forms.BindingSource bdportariaDataSetlistamorador1BindingSource;
        private System.Windows.Forms.BindingSource moradoresBindingSource1;
        private System.Windows.Forms.BindingSource moradoresBindingSource2;*/
        private System.Windows.Forms.MaskedTextBox maskedTextBox_celular;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_placa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_visitado;
        private System.Windows.Forms.Button button_datagrid_visible;
        private System.Windows.Forms.DataGridView dataGridView_pesquisa_morador;
        private System.Windows.Forms.Button button_pesquisar_morador;
        private System.Windows.Forms.TextBox textBox_nome_visitado;
        private System.Windows.Forms.TextBox textBox_unidade_visitado;
        private System.Windows.Forms.Label label_pesquisa_visitado;
        private System.Windows.Forms.Label label_pequisa_unidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBlocoRua;
        private System.Windows.Forms.TextBox textBoxBlocoRua;
    }
}