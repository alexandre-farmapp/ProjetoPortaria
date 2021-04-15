namespace Projeto_Portaria
{
    partial class Form_moradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_moradores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_observacoes = new System.Windows.Forms.TextBox();
            this.groupBox_Dados_Veiculo = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_placa = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Cor = new System.Windows.Forms.TextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.label_Modelo_Veiculo = new System.Windows.Forms.Label();
            this.label_Cor_Veiculo = new System.Windows.Forms.Label();
            this.label_PLaca_Veiculo = new System.Windows.Forms.Label();
            this.groupBox_Dados_Pessoais = new System.Windows.Forms.GroupBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ramal = new System.Windows.Forms.TextBox();
            this.textBox_unidade = new System.Windows.Forms.TextBox();
            this.textBox_Rua = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Apartamento = new System.Windows.Forms.Label();
            this.label_Bloco = new System.Windows.Forms.Label();
            this.groupBox_Contato = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.maskedTextBox_celular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_fixo = new System.Windows.Forms.MaskedTextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Celular = new System.Windows.Forms.Label();
            this.label_Fixo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_nome_morador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonAddFoto = new System.Windows.Forms.Button();
            this.pictureBox_Foto_Morador = new System.Windows.Forms.PictureBox();
            this.button_voltar_menu = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.textBox_unidade_morador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox_Dados_Veiculo.SuspendLayout();
            this.groupBox_Dados_Pessoais.SuspendLayout();
            this.groupBox_Contato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto_Morador)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox_observacoes);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 92);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // textBox_observacoes
            // 
            this.textBox_observacoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_observacoes.Location = new System.Drawing.Point(10, 18);
            this.textBox_observacoes.Multiline = true;
            this.textBox_observacoes.Name = "textBox_observacoes";
            this.textBox_observacoes.Size = new System.Drawing.Size(293, 61);
            this.textBox_observacoes.TabIndex = 15;
            // 
            // groupBox_Dados_Veiculo
            // 
            this.groupBox_Dados_Veiculo.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Dados_Veiculo.Controls.Add(this.maskedTextBox_placa);
            this.groupBox_Dados_Veiculo.Controls.Add(this.textBox_Cor);
            this.groupBox_Dados_Veiculo.Controls.Add(this.textBox_Modelo);
            this.groupBox_Dados_Veiculo.Controls.Add(this.label_Modelo_Veiculo);
            this.groupBox_Dados_Veiculo.Controls.Add(this.label_Cor_Veiculo);
            this.groupBox_Dados_Veiculo.Controls.Add(this.label_PLaca_Veiculo);
            this.groupBox_Dados_Veiculo.ForeColor = System.Drawing.Color.White;
            this.groupBox_Dados_Veiculo.Location = new System.Drawing.Point(345, 452);
            this.groupBox_Dados_Veiculo.Name = "groupBox_Dados_Veiculo";
            this.groupBox_Dados_Veiculo.Size = new System.Drawing.Size(294, 92);
            this.groupBox_Dados_Veiculo.TabIndex = 21;
            this.groupBox_Dados_Veiculo.TabStop = false;
            this.groupBox_Dados_Veiculo.Text = "Dados do Veiculo";
            // 
            // maskedTextBox_placa
            // 
            this.maskedTextBox_placa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maskedTextBox_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_placa.Location = new System.Drawing.Point(196, 17);
            this.maskedTextBox_placa.Mask = "aaa-0000";
            this.maskedTextBox_placa.Name = "maskedTextBox_placa";
            this.maskedTextBox_placa.Size = new System.Drawing.Size(89, 26);
            this.maskedTextBox_placa.TabIndex = 17;
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cor.Location = new System.Drawing.Point(46, 52);
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(150, 26);
            this.textBox_Cor.TabIndex = 18;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Modelo.Location = new System.Drawing.Point(47, 18);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(112, 26);
            this.textBox_Modelo.TabIndex = 16;
            // 
            // label_Modelo_Veiculo
            // 
            this.label_Modelo_Veiculo.AutoSize = true;
            this.label_Modelo_Veiculo.Location = new System.Drawing.Point(2, 21);
            this.label_Modelo_Veiculo.Name = "label_Modelo_Veiculo";
            this.label_Modelo_Veiculo.Size = new System.Drawing.Size(52, 13);
            this.label_Modelo_Veiculo.TabIndex = 4;
            this.label_Modelo_Veiculo.Text = "Modelo:";
            // 
            // label_Cor_Veiculo
            // 
            this.label_Cor_Veiculo.AutoSize = true;
            this.label_Cor_Veiculo.Location = new System.Drawing.Point(14, 50);
            this.label_Cor_Veiculo.Name = "label_Cor_Veiculo";
            this.label_Cor_Veiculo.Size = new System.Drawing.Size(30, 13);
            this.label_Cor_Veiculo.TabIndex = 3;
            this.label_Cor_Veiculo.Text = "Cor:";
            // 
            // label_PLaca_Veiculo
            // 
            this.label_PLaca_Veiculo.AutoSize = true;
            this.label_PLaca_Veiculo.Location = new System.Drawing.Point(159, 18);
            this.label_PLaca_Veiculo.Name = "label_PLaca_Veiculo";
            this.label_PLaca_Veiculo.Size = new System.Drawing.Size(43, 13);
            this.label_PLaca_Veiculo.TabIndex = 1;
            this.label_PLaca_Veiculo.Text = "Placa:";
            // 
            // groupBox_Dados_Pessoais
            // 
            this.groupBox_Dados_Pessoais.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_cpf);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_id);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label3);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Ramal);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_unidade);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Rua);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Nome);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Nome);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_CPF);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Apartamento);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Bloco);
            this.groupBox_Dados_Pessoais.ForeColor = System.Drawing.Color.White;
            this.groupBox_Dados_Pessoais.Location = new System.Drawing.Point(209, 224);
            this.groupBox_Dados_Pessoais.Name = "groupBox_Dados_Pessoais";
            this.groupBox_Dados_Pessoais.Size = new System.Drawing.Size(429, 128);
            this.groupBox_Dados_Pessoais.TabIndex = 19;
            this.groupBox_Dados_Pessoais.TabStop = false;
            this.groupBox_Dados_Pessoais.Text = "Dados Pessoais";
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cpf.Location = new System.Drawing.Point(41, 52);
            this.textBox_cpf.MaxLength = 14;
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(145, 26);
            this.textBox_cpf.TabIndex = 8;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(402, 102);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(23, 20);
            this.textBox_id.TabIndex = 88;
            this.textBox_id.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ramal";
            // 
            // textBox_Ramal
            // 
            this.textBox_Ramal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Ramal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ramal.Location = new System.Drawing.Point(175, 91);
            this.textBox_Ramal.Name = "textBox_Ramal";
            this.textBox_Ramal.Size = new System.Drawing.Size(76, 26);
            this.textBox_Ramal.TabIndex = 11;
            // 
            // textBox_unidade
            // 
            this.textBox_unidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_unidade.Location = new System.Drawing.Point(53, 90);
            this.textBox_unidade.Name = "textBox_unidade";
            this.textBox_unidade.Size = new System.Drawing.Size(60, 26);
            this.textBox_unidade.TabIndex = 10;
            // 
            // textBox_Rua
            // 
            this.textBox_Rua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Rua.Location = new System.Drawing.Point(255, 52);
            this.textBox_Rua.Name = "textBox_Rua";
            this.textBox_Rua.Size = new System.Drawing.Size(166, 26);
            this.textBox_Rua.TabIndex = 9;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(41, 17);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(380, 26);
            this.textBox_Nome.TabIndex = 7;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(3, 20);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(43, 13);
            this.label_Nome.TabIndex = 0;
            this.label_Nome.Text = "Nome:";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(5, 56);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(34, 13);
            this.label_CPF.TabIndex = 1;
            this.label_CPF.Text = "CPF:";
            // 
            // label_Apartamento
            // 
            this.label_Apartamento.AutoSize = true;
            this.label_Apartamento.Location = new System.Drawing.Point(5, 94);
            this.label_Apartamento.Name = "label_Apartamento";
            this.label_Apartamento.Size = new System.Drawing.Size(47, 13);
            this.label_Apartamento.TabIndex = 3;
            this.label_Apartamento.Text = "Uni/Ap";
            // 
            // label_Bloco
            // 
            this.label_Bloco.AutoSize = true;
            this.label_Bloco.Location = new System.Drawing.Point(190, 56);
            this.label_Bloco.Name = "label_Bloco";
            this.label_Bloco.Size = new System.Drawing.Size(68, 13);
            this.label_Bloco.TabIndex = 2;
            this.label_Bloco.Text = "Rua/Bloco";
            // 
            // groupBox_Contato
            // 
            this.groupBox_Contato.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Contato.Controls.Add(this.textBox_Email);
            this.groupBox_Contato.Controls.Add(this.maskedTextBox_celular);
            this.groupBox_Contato.Controls.Add(this.maskedTextBox_fixo);
            this.groupBox_Contato.Controls.Add(this.label_Email);
            this.groupBox_Contato.Controls.Add(this.label_Celular);
            this.groupBox_Contato.Controls.Add(this.label_Fixo);
            this.groupBox_Contato.ForeColor = System.Drawing.Color.White;
            this.groupBox_Contato.Location = new System.Drawing.Point(208, 354);
            this.groupBox_Contato.Name = "groupBox_Contato";
            this.groupBox_Contato.Size = new System.Drawing.Size(430, 92);
            this.groupBox_Contato.TabIndex = 20;
            this.groupBox_Contato.TabStop = false;
            this.groupBox_Contato.Text = "Contato";
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(57, 52);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(311, 26);
            this.textBox_Email.TabIndex = 14;
            // 
            // maskedTextBox_celular
            // 
            this.maskedTextBox_celular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maskedTextBox_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_celular.Location = new System.Drawing.Point(271, 18);
            this.maskedTextBox_celular.Mask = "(00)00000-0000";
            this.maskedTextBox_celular.Name = "maskedTextBox_celular";
            this.maskedTextBox_celular.Size = new System.Drawing.Size(150, 26);
            this.maskedTextBox_celular.TabIndex = 13;
            // 
            // maskedTextBox_fixo
            // 
            this.maskedTextBox_fixo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maskedTextBox_fixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_fixo.Location = new System.Drawing.Point(57, 18);
            this.maskedTextBox_fixo.Mask = "(00)0000-0000";
            this.maskedTextBox_fixo.Name = "maskedTextBox_fixo";
            this.maskedTextBox_fixo.Size = new System.Drawing.Size(138, 26);
            this.maskedTextBox_fixo.TabIndex = 12;
            this.maskedTextBox_fixo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox_fixo_MaskInputRejected);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(10, 56);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(45, 13);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "E-mail:";
            // 
            // label_Celular
            // 
            this.label_Celular.AutoSize = true;
            this.label_Celular.Location = new System.Drawing.Point(223, 26);
            this.label_Celular.Name = "label_Celular";
            this.label_Celular.Size = new System.Drawing.Size(50, 13);
            this.label_Celular.TabIndex = 7;
            this.label_Celular.Text = "Celular:";
            // 
            // label_Fixo
            // 
            this.label_Fixo.AutoSize = true;
            this.label_Fixo.Location = new System.Drawing.Point(13, 26);
            this.label_Fixo.Name = "label_Fixo";
            this.label_Fixo.Size = new System.Drawing.Size(34, 13);
            this.label_Fixo.TabIndex = 6;
            this.label_Fixo.Text = "Fixo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(26, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 171);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // textBox_nome_morador
            // 
            this.textBox_nome_morador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_nome_morador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_morador.Location = new System.Drawing.Point(169, 19);
            this.textBox_nome_morador.Name = "textBox_nome_morador";
            this.textBox_nome_morador.Size = new System.Drawing.Size(189, 26);
            this.textBox_nome_morador.TabIndex = 1;
            this.textBox_nome_morador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nome_morador_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
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
            this.button_pesquisar.Location = new System.Drawing.Point(371, 11);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(22, 38);
            this.button_pesquisar.TabIndex = 2;
            this.button_pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_pesquisar, "Consultar");
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.Button_pesquisar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeletar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.deletar_icon;
            this.buttonDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeletar.FlatAppearance.BorderSize = 0;
            this.buttonDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.Location = new System.Drawing.Point(644, 241);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(46, 46);
            this.buttonDeletar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonDeletar, "Deletar");
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Visible = false;
            this.buttonDeletar.Click += new System.EventHandler(this.Button_deletar_Click);
            // 
            // buttonAddFoto
            // 
            this.buttonAddFoto.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddFoto.BackgroundImage = global::Projeto_Portaria.Properties.Resources.explorer;
            this.buttonAddFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFoto.FlatAppearance.BorderSize = 0;
            this.buttonAddFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFoto.ForeColor = System.Drawing.Color.White;
            this.buttonAddFoto.Location = new System.Drawing.Point(169, 420);
            this.buttonAddFoto.Name = "buttonAddFoto";
            this.buttonAddFoto.Size = new System.Drawing.Size(33, 26);
            this.buttonAddFoto.TabIndex = 19;
            this.toolTip1.SetToolTip(this.buttonAddFoto, "Adicionar Imagem");
            this.buttonAddFoto.UseVisualStyleBackColor = false;
            this.buttonAddFoto.Click += new System.EventHandler(this.button_Adicionar_Foto_Click);
            // 
            // pictureBox_Foto_Morador
            // 
            this.pictureBox_Foto_Morador.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Foto_Morador.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Usuario;
            this.pictureBox_Foto_Morador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Foto_Morador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Foto_Morador.Location = new System.Drawing.Point(16, 231);
            this.pictureBox_Foto_Morador.Name = "pictureBox_Foto_Morador";
            this.pictureBox_Foto_Morador.Size = new System.Drawing.Size(186, 215);
            this.pictureBox_Foto_Morador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Foto_Morador.TabIndex = 24;
            this.pictureBox_Foto_Morador.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Foto_Morador, "Foto de Cadastro");
            this.pictureBox_Foto_Morador.Click += new System.EventHandler(this.PictureBox_Foto_Morador_Click);
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
            this.button_voltar_menu.Location = new System.Drawing.Point(644, 495);
            this.button_voltar_menu.Name = "button_voltar_menu";
            this.button_voltar_menu.Size = new System.Drawing.Size(46, 38);
            this.button_voltar_menu.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_voltar_menu, "Voltar");
            this.button_voltar_menu.UseVisualStyleBackColor = false;
            this.button_voltar_menu.Click += new System.EventHandler(this.Button_voltar_menu_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(644, 309);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(66, 45);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Cancelar");
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAlterar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.alterar_icon;
            this.buttonAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAlterar.FlatAppearance.BorderSize = 0;
            this.buttonAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(644, 378);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(58, 45);
            this.buttonAlterar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonAlterar, "Alterar");
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Visible = false;
            this.buttonAlterar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdicionar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Save_icon;
            this.buttonAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdicionar.FlatAppearance.BorderSize = 0;
            this.buttonAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(644, 438);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(58, 45);
            this.buttonAdicionar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.buttonAdicionar, "Adicionar");
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // textBox_unidade_morador
            // 
            this.textBox_unidade_morador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_unidade_morador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_unidade_morador.Location = new System.Drawing.Point(75, 19);
            this.textBox_unidade_morador.Name = "textBox_unidade_morador";
            this.textBox_unidade_morador.Size = new System.Drawing.Size(59, 26);
            this.textBox_unidade_morador.TabIndex = 0;
            this.textBox_unidade_morador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_unidade_morador_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Unidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAdicionar);
            this.groupBox2.Controls.Add(this.buttonDeletar);
            this.groupBox2.Controls.Add(this.buttonAddFoto);
            this.groupBox2.Controls.Add(this.pictureBox_Foto_Morador);
            this.groupBox2.Controls.Add(this.groupBox_Dados_Pessoais);
            this.groupBox2.Controls.Add(this.groupBox_Contato);
            this.groupBox2.Controls.Add(this.button_voltar_menu);
            this.groupBox2.Controls.Add(this.textBox_nome_morador);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonAlterar);
            this.groupBox2.Controls.Add(this.groupBox_Dados_Veiculo);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 555);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moradores";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_moradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 562);
            this.Controls.Add(this.textBox_unidade_morador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_moradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_moradores";
            this.Load += new System.EventHandler(this.Form_moradores_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_moradores_KeyPress);
            this.MouseHover += new System.EventHandler(this.Form_moradores_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Dados_Veiculo.ResumeLayout(false);
            this.groupBox_Dados_Veiculo.PerformLayout();
            this.groupBox_Dados_Pessoais.ResumeLayout(false);
            this.groupBox_Dados_Pessoais.PerformLayout();
            this.groupBox_Contato.ResumeLayout(false);
            this.groupBox_Contato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto_Morador)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_voltar_menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_observacoes;
        private System.Windows.Forms.Button buttonAddFoto;
        private System.Windows.Forms.PictureBox pictureBox_Foto_Morador;
        private System.Windows.Forms.GroupBox groupBox_Dados_Veiculo;
        private System.Windows.Forms.TextBox textBox_Cor;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.Label label_Modelo_Veiculo;
        private System.Windows.Forms.Label label_Cor_Veiculo;
        private System.Windows.Forms.Label label_PLaca_Veiculo;
        private System.Windows.Forms.GroupBox groupBox_Dados_Pessoais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ramal;
        private System.Windows.Forms.TextBox textBox_unidade;
        private System.Windows.Forms.TextBox textBox_Rua;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_Apartamento;
        private System.Windows.Forms.Label label_Bloco;
        private System.Windows.Forms.GroupBox groupBox_Contato;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Celular;
        private System.Windows.Forms.Label label_Fixo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_nome_morador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fixo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_celular;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_placa;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_unidade_morador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_cpf;
        private System.Windows.Forms.Button buttonAdicionar;
    }
}