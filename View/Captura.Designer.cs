
namespace Projeto_Portaria.View
{
    partial class Captura
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.streamtype_comboBox = new System.Windows.Forms.ComboBox();
            this.channel_comboBox = new System.Windows.Forms.ComboBox();
            this.capture_button = new System.Windows.Forms.Button();
            this.start_realplay_button = new System.Windows.Forms.Button();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.realplay_pictureBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realplay_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.streamtype_comboBox);
            this.groupBox2.Controls.Add(this.channel_comboBox);
            this.groupBox2.Controls.Add(this.capture_button);
            this.groupBox2.Controls.Add(this.start_realplay_button);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(389, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 227);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comandos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "StreamType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Canal";
            // 
            // streamtype_comboBox
            // 
            this.streamtype_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamtype_comboBox.FormattingEnabled = true;
            this.streamtype_comboBox.Location = new System.Drawing.Point(20, 81);
            this.streamtype_comboBox.Name = "streamtype_comboBox";
            this.streamtype_comboBox.Size = new System.Drawing.Size(159, 21);
            this.streamtype_comboBox.TabIndex = 6;
            // 
            // channel_comboBox
            // 
            this.channel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channel_comboBox.FormattingEnabled = true;
            this.channel_comboBox.Location = new System.Drawing.Point(20, 35);
            this.channel_comboBox.Name = "channel_comboBox";
            this.channel_comboBox.Size = new System.Drawing.Size(159, 21);
            this.channel_comboBox.TabIndex = 5;
            // 
            // capture_button
            // 
            this.capture_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.capture_button.Location = new System.Drawing.Point(20, 160);
            this.capture_button.Name = "capture_button";
            this.capture_button.Size = new System.Drawing.Size(159, 46);
            this.capture_button.TabIndex = 8;
            this.capture_button.Text = "Capturar";
            this.capture_button.UseVisualStyleBackColor = true;
            this.capture_button.Click += new System.EventHandler(this.capture_button_Click);
            // 
            // start_realplay_button
            // 
            this.start_realplay_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_realplay_button.Location = new System.Drawing.Point(20, 108);
            this.start_realplay_button.Name = "start_realplay_button";
            this.start_realplay_button.Size = new System.Drawing.Size(159, 46);
            this.start_realplay_button.TabIndex = 7;
            this.start_realplay_button.Text = "Visualizar";
            this.start_realplay_button.UseVisualStyleBackColor = true;
            this.start_realplay_button.Click += new System.EventHandler(this.start_realplay_button_Click);
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(257, 459);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(43, 20);
            this.port_textBox.TabIndex = 32;
            this.port_textBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Port(端口):";
            this.label9.Visible = false;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(632, 457);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(115, 23);
            this.login_button.TabIndex = 35;
            this.login_button.Text = "Login(登录)";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Visible = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(374, 459);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(53, 20);
            this.name_textBox.TabIndex = 33;
            this.name_textBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Name(用户):";
            this.label8.Visible = false;
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(504, 459);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.Size = new System.Drawing.Size(103, 20);
            this.pwd_textBox.TabIndex = 34;
            this.pwd_textBox.UseSystemPasswordChar = true;
            this.pwd_textBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Pwd(密码):";
            this.label7.Visible = false;
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(90, 459);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(92, 20);
            this.ip_textBox.TabIndex = 30;
            this.ip_textBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "IP(设备IP):";
            this.label6.Visible = false;
            // 
            // realplay_pictureBox
            // 
            this.realplay_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.realplay_pictureBox.Location = new System.Drawing.Point(6, 19);
            this.realplay_pictureBox.Name = "realplay_pictureBox";
            this.realplay_pictureBox.Size = new System.Drawing.Size(377, 324);
            this.realplay_pictureBox.TabIndex = 31;
            this.realplay_pictureBox.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Projeto_Portaria.Properties.Resources.Icon__Voltar_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(536, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 38);
            this.btnExit.TabIndex = 41;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.realplay_pictureBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 357);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura";
            // 
            // Captura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(629, 372);
            this.Controls.Add(this.port_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pwd_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ip_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Captura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura";
            this.Load += new System.EventHandler(this.Captura_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realplay_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox streamtype_comboBox;
        private System.Windows.Forms.ComboBox channel_comboBox;
        private System.Windows.Forms.Button capture_button;
        private System.Windows.Forms.Button start_realplay_button;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox realplay_pictureBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}