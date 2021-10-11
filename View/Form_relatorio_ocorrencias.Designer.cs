namespace Projeto_Portaria
{
    partial class Form_relatorio_ocorrencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_relatorio_ocorrencias));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ocorrencia = new System.Windows.Forms.TextBox();
            this.groupBox_digite_ocorrencia = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_novo = new System.Windows.Forms.Button();
            this.textBox_rua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_min = new System.Windows.Forms.ComboBox();
            this.comboBox_hora = new System.Windows.Forms.ComboBox();
            this.textBox_unidade = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocorrenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocorrenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_alterar = new System.Windows.Forms.Button();
            this.button_salvar2 = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox_digite_ocorrencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hora";
            // 
            // textBox_ocorrencia
            // 
            this.textBox_ocorrencia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_ocorrencia.Enabled = false;
            this.textBox_ocorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ocorrencia.Location = new System.Drawing.Point(6, 19);
            this.textBox_ocorrencia.Multiline = true;
            this.textBox_ocorrencia.Name = "textBox_ocorrencia";
            this.textBox_ocorrencia.Size = new System.Drawing.Size(474, 122);
            this.textBox_ocorrencia.TabIndex = 13;
            this.textBox_ocorrencia.TextChanged += new System.EventHandler(this.textBox_ocorrencia_TextChanged);
            // 
            // groupBox_digite_ocorrencia
            // 
            this.groupBox_digite_ocorrencia.Controls.Add(this.textBox_ocorrencia);
            this.groupBox_digite_ocorrencia.ForeColor = System.Drawing.Color.White;
            this.groupBox_digite_ocorrencia.Location = new System.Drawing.Point(353, 19);
            this.groupBox_digite_ocorrencia.Name = "groupBox_digite_ocorrencia";
            this.groupBox_digite_ocorrencia.Size = new System.Drawing.Size(486, 147);
            this.groupBox_digite_ocorrencia.TabIndex = 16;
            this.groupBox_digite_ocorrencia.TabStop = false;
            this.groupBox_digite_ocorrencia.Text = "Digite a ocorrência";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(198, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            this.label7.Visible = false;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(222, 98);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(85, 20);
            this.textBox_id.TabIndex = 29;
            this.textBox_id.Visible = false;
            // 
            // button_novo
            // 
            this.button_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_novo.BackgroundImage = global::Projeto_Portaria.Properties.Resources.icone_mais_png_4;
            this.button_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_novo.Location = new System.Drawing.Point(744, 459);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(46, 42);
            this.button_novo.TabIndex = 26;
            this.toolTip1.SetToolTip(this.button_novo, "Nova Ocorrência");
            this.button_novo.UseVisualStyleBackColor = false;
            this.button_novo.Click += new System.EventHandler(this.Button_novo_Click);
            // 
            // textBox_rua
            // 
            this.textBox_rua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_rua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_rua.Enabled = false;
            this.textBox_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rua.Location = new System.Drawing.Point(176, 28);
            this.textBox_rua.Name = "textBox_rua";
            this.textBox_rua.Size = new System.Drawing.Size(171, 26);
            this.textBox_rua.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rua/Bloco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = ":";
            // 
            // comboBox_min
            // 
            this.comboBox_min.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox_min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_min.Enabled = false;
            this.comboBox_min.FormattingEnabled = true;
            this.comboBox_min.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.comboBox_min.Location = new System.Drawing.Point(123, 98);
            this.comboBox_min.Name = "comboBox_min";
            this.comboBox_min.Size = new System.Drawing.Size(44, 21);
            this.comboBox_min.TabIndex = 22;
            // 
            // comboBox_hora
            // 
            this.comboBox_hora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hora.Enabled = false;
            this.comboBox_hora.FormattingEnabled = true;
            this.comboBox_hora.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_hora.Location = new System.Drawing.Point(57, 92);
            this.comboBox_hora.Name = "comboBox_hora";
            this.comboBox_hora.Size = new System.Drawing.Size(43, 21);
            this.comboBox_hora.TabIndex = 21;
            // 
            // textBox_unidade
            // 
            this.textBox_unidade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_unidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_unidade.Enabled = false;
            this.textBox_unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_unidade.Location = new System.Drawing.Point(56, 28);
            this.textBox_unidade.Name = "textBox_unidade";
            this.textBox_unidade.Size = new System.Drawing.Size(62, 26);
            this.textBox_unidade.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.ocorrenciaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ocorrenciasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersWidth = 20;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(821, 256);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua/Bloco";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ruaDataGridViewTextBoxColumn.Width = 150;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unid";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 35;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            this.minDataGridViewTextBoxColumn.Width = 35;
            // 
            // ocorrenciaDataGridViewTextBoxColumn
            // 
            this.ocorrenciaDataGridViewTextBoxColumn.DataPropertyName = "ocorrencia";
            this.ocorrenciaDataGridViewTextBoxColumn.HeaderText = "Ocorrência";
            this.ocorrenciaDataGridViewTextBoxColumn.Name = "ocorrenciaDataGridViewTextBoxColumn";
            this.ocorrenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocorrenciaDataGridViewTextBoxColumn.Width = 430;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // button_deletar
            // 
            this.button_deletar.BackColor = System.Drawing.Color.Transparent;
            this.button_deletar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.deletar_icon;
            this.button_deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_deletar.FlatAppearance.BorderSize = 0;
            this.button_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletar.Location = new System.Drawing.Point(655, 460);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(42, 37);
            this.button_deletar.TabIndex = 31;
            this.toolTip1.SetToolTip(this.button_deletar, "Deletar");
            this.button_deletar.UseVisualStyleBackColor = false;
            this.button_deletar.Visible = false;
            this.button_deletar.Click += new System.EventHandler(this.Button_deletar_Click);
            // 
            // button_alterar
            // 
            this.button_alterar.BackColor = System.Drawing.Color.Transparent;
            this.button_alterar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.alterar_icon;
            this.button_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_alterar.FlatAppearance.BorderSize = 0;
            this.button_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alterar.Location = new System.Drawing.Point(703, 460);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(45, 37);
            this.button_alterar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.button_alterar, "Alterar");
            this.button_alterar.UseVisualStyleBackColor = false;
            this.button_alterar.Visible = false;
            this.button_alterar.Click += new System.EventHandler(this.Button_alterar_Click);
            // 
            // button_salvar2
            // 
            this.button_salvar2.BackColor = System.Drawing.Color.Transparent;
            this.button_salvar2.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Save_icon;
            this.button_salvar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_salvar2.FlatAppearance.BorderSize = 0;
            this.button_salvar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_salvar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_salvar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar2.Location = new System.Drawing.Point(692, 460);
            this.button_salvar2.Name = "button_salvar2";
            this.button_salvar2.Size = new System.Drawing.Size(56, 37);
            this.button_salvar2.TabIndex = 28;
            this.toolTip1.SetToolTip(this.button_salvar2, "Salvar");
            this.button_salvar2.UseVisualStyleBackColor = false;
            this.button_salvar2.Visible = false;
            this.button_salvar2.Click += new System.EventHandler(this.Button_salvar2_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.Color.Transparent;
            this.button_salvar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Save_icon;
            this.button_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_salvar.FlatAppearance.BorderSize = 0;
            this.button_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.Location = new System.Drawing.Point(692, 460);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(56, 37);
            this.button_salvar.TabIndex = 18;
            this.toolTip1.SetToolTip(this.button_salvar, "Salvar");
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Visible = false;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Voltar_;
            this.button_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sair.FlatAppearance.BorderSize = 0;
            this.button_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(796, 459);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(43, 42);
            this.button_sair.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_sair, "Voltar Menu Anterior");
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.Button_sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox_digite_ocorrencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox_rua);
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.comboBox_hora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_novo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_deletar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_salvar);
            this.groupBox1.Controls.Add(this.button_salvar2);
            this.groupBox1.Controls.Add(this.textBox_unidade);
            this.groupBox1.Controls.Add(this.button_alterar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 507);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocorrências";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 281);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório";
            // 
            // Form_relatorio_ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 525);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.comboBox_min);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_relatorio_ocorrencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_relatorio_ocorrencias";
            this.Load += new System.EventHandler(this.Form_relatorio_ocorrencias_Load);
            this.groupBox_digite_ocorrencia.ResumeLayout(false);
            this.groupBox_digite_ocorrencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ocorrencia;
        private System.Windows.Forms.GroupBox groupBox_digite_ocorrencia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_min;
        private System.Windows.Forms.ComboBox comboBox_hora;
        private System.Windows.Forms.TextBox textBox_unidade;
        private System.Windows.Forms.TextBox textBox_rua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource ocorrenciasBindingSource;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Button button_salvar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocorrenciaDataGridViewTextBoxColumn;
    }
}