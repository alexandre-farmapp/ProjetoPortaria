namespace Projeto_Portaria
{
    partial class Form_pessoas_uteis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pessoas_uteis));
            this.textBox_nome_sindico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_telefone_sindico = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_telefone_supervisor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nome_supervisor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_telefone_zelador = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_nome_zelador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_alterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomesindicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonesindicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomesupervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomezeladorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonezeladorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasuteisBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasuteisBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasUteisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasUteisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasUteisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_salvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_sair = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasuteisBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasuteisBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasUteisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasUteisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasUteisBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nome_sindico
            // 
            this.textBox_nome_sindico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_sindico.Location = new System.Drawing.Point(53, 26);
            this.textBox_nome_sindico.Name = "textBox_nome_sindico";
            this.textBox_nome_sindico.Size = new System.Drawing.Size(113, 26);
            this.textBox_nome_sindico.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.maskedTextBox_telefone_sindico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_nome_sindico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sindico";
            // 
            // maskedTextBox_telefone_sindico
            // 
            this.maskedTextBox_telefone_sindico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone_sindico.Location = new System.Drawing.Point(227, 26);
            this.maskedTextBox_telefone_sindico.Mask = "(00)00000-0000";
            this.maskedTextBox_telefone_sindico.Name = "maskedTextBox_telefone_sindico";
            this.maskedTextBox_telefone_sindico.Size = new System.Drawing.Size(154, 26);
            this.maskedTextBox_telefone_sindico.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.maskedTextBox_telefone_supervisor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_nome_supervisor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supervisor";
            // 
            // maskedTextBox_telefone_supervisor
            // 
            this.maskedTextBox_telefone_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone_supervisor.Location = new System.Drawing.Point(227, 26);
            this.maskedTextBox_telefone_supervisor.Mask = "(00)00000-0000";
            this.maskedTextBox_telefone_supervisor.Name = "maskedTextBox_telefone_supervisor";
            this.maskedTextBox_telefone_supervisor.Size = new System.Drawing.Size(154, 26);
            this.maskedTextBox_telefone_supervisor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefone";
            // 
            // textBox_nome_supervisor
            // 
            this.textBox_nome_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_supervisor.Location = new System.Drawing.Point(53, 26);
            this.textBox_nome_supervisor.Name = "textBox_nome_supervisor";
            this.textBox_nome_supervisor.Size = new System.Drawing.Size(113, 26);
            this.textBox_nome_supervisor.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.maskedTextBox_telefone_zelador);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_nome_zelador);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zelador";
            // 
            // maskedTextBox_telefone_zelador
            // 
            this.maskedTextBox_telefone_zelador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone_zelador.Location = new System.Drawing.Point(227, 26);
            this.maskedTextBox_telefone_zelador.Mask = "(00)00000-0000";
            this.maskedTextBox_telefone_zelador.Name = "maskedTextBox_telefone_zelador";
            this.maskedTextBox_telefone_zelador.Size = new System.Drawing.Size(153, 26);
            this.maskedTextBox_telefone_zelador.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefone";
            // 
            // textBox_nome_zelador
            // 
            this.textBox_nome_zelador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_zelador.Location = new System.Drawing.Point(53, 26);
            this.textBox_nome_zelador.Name = "textBox_nome_zelador";
            this.textBox_nome_zelador.Size = new System.Drawing.Size(113, 26);
            this.textBox_nome_zelador.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nome";
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
            this.button_alterar.Location = new System.Drawing.Point(14, 313);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(55, 47);
            this.button_alterar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_alterar, "Alterar Dados");
            this.button_alterar.UseVisualStyleBackColor = false;
            this.button_alterar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomesindicoDataGridViewTextBoxColumn,
            this.telefonesindicoDataGridViewTextBoxColumn,
            this.nomesupervisorDataGridViewTextBoxColumn,
            this.telefone_supervisor,
            this.nomezeladorDataGridViewTextBoxColumn,
            this.telefonezeladorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasuteisBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(477, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(42, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nomesindicoDataGridViewTextBoxColumn
            // 
            this.nomesindicoDataGridViewTextBoxColumn.DataPropertyName = "nome_sindico";
            this.nomesindicoDataGridViewTextBoxColumn.HeaderText = "nome_sindico";
            this.nomesindicoDataGridViewTextBoxColumn.Name = "nomesindicoDataGridViewTextBoxColumn";
            this.nomesindicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonesindicoDataGridViewTextBoxColumn
            // 
            this.telefonesindicoDataGridViewTextBoxColumn.DataPropertyName = "telefone_sindico";
            this.telefonesindicoDataGridViewTextBoxColumn.HeaderText = "telefone_sindico";
            this.telefonesindicoDataGridViewTextBoxColumn.Name = "telefonesindicoDataGridViewTextBoxColumn";
            this.telefonesindicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomesupervisorDataGridViewTextBoxColumn
            // 
            this.nomesupervisorDataGridViewTextBoxColumn.DataPropertyName = "nome_supervisor";
            this.nomesupervisorDataGridViewTextBoxColumn.HeaderText = "nome_supervisor";
            this.nomesupervisorDataGridViewTextBoxColumn.Name = "nomesupervisorDataGridViewTextBoxColumn";
            this.nomesupervisorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefone_supervisor
            // 
            this.telefone_supervisor.DataPropertyName = "telefone_supervisor";
            this.telefone_supervisor.HeaderText = "telefone_supervisor";
            this.telefone_supervisor.Name = "telefone_supervisor";
            this.telefone_supervisor.ReadOnly = true;
            // 
            // nomezeladorDataGridViewTextBoxColumn
            // 
            this.nomezeladorDataGridViewTextBoxColumn.DataPropertyName = "nome_zelador";
            this.nomezeladorDataGridViewTextBoxColumn.HeaderText = "nome_zelador";
            this.nomezeladorDataGridViewTextBoxColumn.Name = "nomezeladorDataGridViewTextBoxColumn";
            this.nomezeladorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonezeladorDataGridViewTextBoxColumn
            // 
            this.telefonezeladorDataGridViewTextBoxColumn.DataPropertyName = "telefone_zelador";
            this.telefonezeladorDataGridViewTextBoxColumn.HeaderText = "telefone_zelador";
            this.telefonezeladorDataGridViewTextBoxColumn.Name = "telefonezeladorDataGridViewTextBoxColumn";
            this.telefonezeladorDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.button_salvar.Location = new System.Drawing.Point(15, 313);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(55, 47);
            this.button_salvar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button_salvar, "Salvar Dados");
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Visible = false;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Voltar_;
            this.button_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sair.FlatAppearance.BorderSize = 0;
            this.button_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(358, 325);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(43, 42);
            this.button_sair.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button_sair, "Voltar Menu Anterior");
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.Button_sair_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(189, 340);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(14, 20);
            this.textBox_id.TabIndex = 6;
            this.textBox_id.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button_sair);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.textBox_id);
            this.groupBox4.Controls.Add(this.button_salvar);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.button_alterar);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 380);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contatos";
            // 
            // Form_pessoas_uteis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_pessoas_uteis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_pessoas_uteis";
            this.Load += new System.EventHandler(this.Form_pessoas_uteis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasuteisBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasuteisBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasUteisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasUteisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasUteisBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nome_sindico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone_sindico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone_supervisor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nome_supervisor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone_zelador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_nome_zelador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pessoasUteisBindingSource;
        private System.Windows.Forms.BindingSource pessoasUteisBindingSource1;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.BindingSource pessoasUteisBindingSource2;
        private System.Windows.Forms.BindingSource pessoasuteisBindingSource3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.BindingSource pessoasuteisBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomesindicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonesindicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomesupervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomezeladorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonezeladorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}