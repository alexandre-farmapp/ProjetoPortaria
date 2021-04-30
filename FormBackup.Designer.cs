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
            this.groupBoxRestaurar.SuspendLayout();
            this.groupBoxCriarBackup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(148, 135);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(95, 37);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.Location = new System.Drawing.Point(116, 27);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(165, 20);
            this.textBoxServidor.TabIndex = 1;
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.Location = new System.Drawing.Point(116, 55);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(165, 20);
            this.textBoxBanco.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(116, 82);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(165, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(116, 109);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(165, 20);
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
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Banco de Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 112);
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
            this.groupBoxRestaurar.Location = new System.Drawing.Point(12, 165);
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
            this.buttonProcurarArq.Location = new System.Drawing.Point(487, 40);
            this.buttonProcurarArq.Name = "buttonProcurarArq";
            this.buttonProcurarArq.Size = new System.Drawing.Size(95, 37);
            this.buttonProcurarArq.TabIndex = 15;
            this.buttonProcurarArq.Text = "Procurar";
            this.buttonProcurarArq.UseVisualStyleBackColor = true;
            // 
            // buttonImportar
            // 
            this.buttonImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportar.Location = new System.Drawing.Point(487, 83);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(95, 37);
            this.buttonImportar.TabIndex = 3;
            this.buttonImportar.Text = "Restaurar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            // 
            // textBoxImportar
            // 
            this.textBoxImportar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxImportar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImportar.Location = new System.Drawing.Point(23, 40);
            this.textBoxImportar.Name = "textBoxImportar";
            this.textBoxImportar.Size = new System.Drawing.Size(458, 20);
            this.textBoxImportar.TabIndex = 12;
            // 
            // labelCaminho
            // 
            this.labelCaminho.AutoSize = true;
            this.labelCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaminho.Location = new System.Drawing.Point(32, 36);
            this.labelCaminho.Name = "labelCaminho";
            this.labelCaminho.Size = new System.Drawing.Size(55, 13);
            this.labelCaminho.TabIndex = 21;
            this.labelCaminho.Text = "Caminho";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.Location = new System.Drawing.Point(487, 40);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(95, 37);
            this.buttonProcurar.TabIndex = 15;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(487, 83);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(95, 37);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // textBoxCaminhoCriar
            // 
            this.textBoxCaminhoCriar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCaminhoCriar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCaminhoCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaminhoCriar.Location = new System.Drawing.Point(23, 40);
            this.textBoxCaminhoCriar.Name = "textBoxCaminhoCriar";
            this.textBoxCaminhoCriar.Size = new System.Drawing.Size(458, 20);
            this.textBoxCaminhoCriar.TabIndex = 12;
            // 
            // groupBoxCriarBackup
            // 
            this.groupBoxCriarBackup.Controls.Add(this.buttonProcurar);
            this.groupBoxCriarBackup.Controls.Add(this.buttonSalvar);
            this.groupBoxCriarBackup.Controls.Add(this.textBoxCaminhoCriar);
            this.groupBoxCriarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCriarBackup.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCriarBackup.Name = "groupBoxCriarBackup";
            this.groupBoxCriarBackup.Size = new System.Drawing.Size(599, 136);
            this.groupBoxCriarBackup.TabIndex = 22;
            this.groupBoxCriarBackup.TabStop = false;
            this.groupBoxCriarBackup.Text = "Exportar";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(151, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 186);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectar-se";
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRestaurar);
            this.Controls.Add(this.labelCaminho);
            this.Controls.Add(this.groupBoxCriarBackup);
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Restaurar";
            this.groupBoxRestaurar.ResumeLayout(false);
            this.groupBoxRestaurar.PerformLayout();
            this.groupBoxCriarBackup.ResumeLayout(false);
            this.groupBoxCriarBackup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}