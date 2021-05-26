namespace Projeto_Portaria
{
    partial class form_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.button_Fazer_Login = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonConectar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Usuario.Location = new System.Drawing.Point(190, 136);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(207, 26);
            this.textBox_Usuario.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox_Usuario, "Digite seu Nome de Usuário");
            this.textBox_Usuario.TextChanged += new System.EventHandler(this.TextBox_Usuário_TextChanged);
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Senha.Location = new System.Drawing.Point(190, 164);
            this.textBox_Senha.MaxLength = 100;
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PasswordChar = '*';
            this.textBox_Senha.Size = new System.Drawing.Size(207, 26);
            this.textBox_Senha.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox_Senha, "Digite sua Senha de Usuário");
            this.textBox_Senha.TextChanged += new System.EventHandler(this.TextBox_Senha_TextChanged);
            this.textBox_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Senha_KeyPress);
            // 
            // button_Fazer_Login
            // 
            this.button_Fazer_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Fazer_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Fazer_Login.BackgroundImage")));
            this.button_Fazer_Login.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Fazer_Login.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Fazer_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Fazer_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_Fazer_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fazer_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button_Fazer_Login.ForeColor = System.Drawing.Color.Black;
            this.button_Fazer_Login.Location = new System.Drawing.Point(190, 199);
            this.button_Fazer_Login.Name = "button_Fazer_Login";
            this.button_Fazer_Login.Size = new System.Drawing.Size(103, 27);
            this.button_Fazer_Login.TabIndex = 5;
            this.button_Fazer_Login.Text = "Login";
            this.toolTip1.SetToolTip(this.button_Fazer_Login, "Efetuar Login");
            this.button_Fazer_Login.UseVisualStyleBackColor = false;
            this.button_Fazer_Login.Click += new System.EventHandler(this.Button_Fazer_Login_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Sair.BackgroundImage")));
            this.button_Sair.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button_Sair.ForeColor = System.Drawing.Color.Black;
            this.button_Sair.Location = new System.Drawing.Point(295, 199);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(102, 27);
            this.button_Sair.TabIndex = 7;
            this.button_Sair.Text = "Sair";
            this.button_Sair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.button_Sair, "Fechar Aplicação");
            this.button_Sair.UseVisualStyleBackColor = false;
            this.button_Sair.Click += new System.EventHandler(this.Button_Sair_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConectar.BackgroundImage")));
            this.buttonConectar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConectar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonConectar.ForeColor = System.Drawing.Color.Black;
            this.buttonConectar.Location = new System.Drawing.Point(230, 255);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(126, 27);
            this.buttonConectar.TabIndex = 15;
            this.buttonConectar.Text = "Conectar-se";
            this.buttonConectar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.buttonConectar, "Fechar Aplicação");
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Visible = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Projeto_Portaria.Properties.Resources.Usuario;
            this.pictureBox2.Location = new System.Drawing.Point(151, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Projeto_Portaria.Properties.Resources.chaves;
            this.pictureBox3.Location = new System.Drawing.Point(151, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(258, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "DooR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(209, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Access Control";
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Projeto_Portaria.Properties.Resources.door_5121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(587, 359);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Fazer_Login);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Usuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.GrayText;
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Button button_Fazer_Login;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConectar;
    }
}

