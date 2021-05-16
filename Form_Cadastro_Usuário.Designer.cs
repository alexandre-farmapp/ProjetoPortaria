namespace Projeto_Portaria
{
    partial class Form_Cadastro_Usuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Usuário));
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.textBox_confirmar = new System.Windows.Forms.TextBox();
            this.label_Usuário = new System.Windows.Forms.Label();
            this.label_Senha = new System.Windows.Forms.Label();
            this.label_Confirmar_Senha = new System.Windows.Forms.Label();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.button_alterar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_salvar2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_novo_usuario = new System.Windows.Forms.GroupBox();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Voltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox_novo_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.Location = new System.Drawing.Point(86, 20);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(189, 26);
            this.textBox_usuario.TabIndex = 1;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(86, 54);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(137, 26);
            this.textBox_senha.TabIndex = 2;
            // 
            // textBox_confirmar
            // 
            this.textBox_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirmar.Location = new System.Drawing.Point(86, 87);
            this.textBox_confirmar.Name = "textBox_confirmar";
            this.textBox_confirmar.PasswordChar = '*';
            this.textBox_confirmar.Size = new System.Drawing.Size(137, 26);
            this.textBox_confirmar.TabIndex = 3;
            // 
            // label_Usuário
            // 
            this.label_Usuário.AutoSize = true;
            this.label_Usuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuário.Location = new System.Drawing.Point(42, 28);
            this.label_Usuário.Name = "label_Usuário";
            this.label_Usuário.Size = new System.Drawing.Size(35, 13);
            this.label_Usuário.TabIndex = 5;
            this.label_Usuário.Text = "Nome";
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Senha.Location = new System.Drawing.Point(42, 62);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(38, 13);
            this.label_Senha.TabIndex = 6;
            this.label_Senha.Text = "Senha";
            // 
            // label_Confirmar_Senha
            // 
            this.label_Confirmar_Senha.AutoSize = true;
            this.label_Confirmar_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Confirmar_Senha.Location = new System.Drawing.Point(27, 95);
            this.label_Confirmar_Senha.Name = "label_Confirmar_Senha";
            this.label_Confirmar_Senha.Size = new System.Drawing.Size(51, 13);
            this.label_Confirmar_Senha.TabIndex = 7;
            this.label_Confirmar_Senha.Text = "Confirmar";
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNome.Location = new System.Drawing.Point(33, 33);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(206, 26);
            this.txtPesqNome.TabIndex = 11;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxCliente.Controls.Add(this.button_alterar);
            this.groupBoxCliente.Controls.Add(this.dataGridView2);
            this.groupBoxCliente.Controls.Add(this.txtPesqNome);
            this.groupBoxCliente.Controls.Add(this.button_deletar);
            this.groupBoxCliente.Controls.Add(this.button_salvar2);
            this.groupBoxCliente.Controls.Add(this.button2);
            this.groupBoxCliente.ForeColor = System.Drawing.Color.White;
            this.groupBoxCliente.Location = new System.Drawing.Point(19, 168);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(300, 283);
            this.groupBoxCliente.TabIndex = 13;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Usuários";
            this.groupBoxCliente.Enter += new System.EventHandler(this.GroupBoxCliente_Enter);
            // 
            // button_alterar
            // 
            this.button_alterar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.alterar_icon;
            this.button_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_alterar.FlatAppearance.BorderSize = 0;
            this.button_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_alterar.ForeColor = System.Drawing.Color.White;
            this.button_alterar.Location = new System.Drawing.Point(262, 238);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(32, 36);
            this.button_alterar.TabIndex = 16;
            this.button_alterar.UseVisualStyleBackColor = true;
            this.button_alterar.Visible = false;
            this.button_alterar.Click += new System.EventHandler(this.button_alterar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CausesValidation = false;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(33, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(206, 163);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // button_deletar
            // 
            this.button_deletar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.deletar_icon;
            this.button_deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_deletar.FlatAppearance.BorderSize = 0;
            this.button_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletar.ForeColor = System.Drawing.Color.White;
            this.button_deletar.Location = new System.Drawing.Point(220, 238);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(46, 36);
            this.button_deletar.TabIndex = 8;
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Visible = false;
            this.button_deletar.Click += new System.EventHandler(this.Button_deletar_Click);
            // 
            // button_salvar2
            // 
            this.button_salvar2.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Save_icon;
            this.button_salvar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_salvar2.FlatAppearance.BorderSize = 0;
            this.button_salvar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_salvar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_salvar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar2.ForeColor = System.Drawing.Color.White;
            this.button_salvar2.Location = new System.Drawing.Point(262, 238);
            this.button_salvar2.Name = "button_salvar2";
            this.button_salvar2.Size = new System.Drawing.Size(32, 36);
            this.button_salvar2.TabIndex = 9;
            this.button_salvar2.UseVisualStyleBackColor = true;
            this.button_salvar2.Visible = false;
            this.button_salvar2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Pesquisar_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(245, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button2, "Consultar");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox_novo_usuario
            // 
            this.groupBox_novo_usuario.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_novo_usuario.Controls.Add(this.label_Usuário);
            this.groupBox_novo_usuario.Controls.Add(this.button_Cadastrar);
            this.groupBox_novo_usuario.Controls.Add(this.label_Confirmar_Senha);
            this.groupBox_novo_usuario.Controls.Add(this.textBox_usuario);
            this.groupBox_novo_usuario.Controls.Add(this.label_Senha);
            this.groupBox_novo_usuario.Controls.Add(this.textBox_senha);
            this.groupBox_novo_usuario.Controls.Add(this.textBox_confirmar);
            this.groupBox_novo_usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_novo_usuario.Location = new System.Drawing.Point(19, 17);
            this.groupBox_novo_usuario.Name = "groupBox_novo_usuario";
            this.groupBox_novo_usuario.Size = new System.Drawing.Size(300, 149);
            this.groupBox_novo_usuario.TabIndex = 14;
            this.groupBox_novo_usuario.TabStop = false;
            this.groupBox_novo_usuario.Text = "Novo Usuario";
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Save_icon1;
            this.button_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cadastrar.FlatAppearance.BorderSize = 0;
            this.button_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.button_Cadastrar.Location = new System.Drawing.Point(229, 107);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(46, 33);
            this.button_Cadastrar.TabIndex = 4;
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.Button_Cadastrar_Click);
            // 
            // button_Voltar
            // 
            this.button_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_Voltar.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Voltar_;
            this.button_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Voltar.FlatAppearance.BorderSize = 0;
            this.button_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voltar.Location = new System.Drawing.Point(273, 450);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(44, 28);
            this.button_Voltar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_Voltar, "Voltar Menu Anterior");
            this.button_Voltar.UseVisualStyleBackColor = false;
            this.button_Voltar.Click += new System.EventHandler(this.Button_Voltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 483);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controle de Usuarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuarios";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 206;
            // 
            // Form_Cadastro_Usuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 495);
            this.Controls.Add(this.groupBox_novo_usuario);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Cadastro_Usuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.Load += new System.EventHandler(this.Form_Cadastro_Usuário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox_novo_usuario.ResumeLayout(false);
            this.groupBox_novo_usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.TextBox textBox_confirmar;
        private System.Windows.Forms.Label label_Usuário;
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.Label label_Confirmar_Senha;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_salvar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBox_novo_usuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}