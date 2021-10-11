namespace Projeto_Portaria
{
    partial class FormAnotacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnotacoes));
            this.textBoxTexto = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.listBoxAnotacao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTexto
            // 
            this.textBoxTexto.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTexto.Location = new System.Drawing.Point(12, 382);
            this.textBoxTexto.Multiline = true;
            this.textBoxTexto.Name = "textBoxTexto";
            this.textBoxTexto.Size = new System.Drawing.Size(402, 42);
            this.textBoxTexto.TabIndex = 0;
            this.textBoxTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTexto_KeyPress);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnviar.FlatAppearance.BorderSize = 0;
            this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnviar.Image")));
            this.buttonEnviar.Location = new System.Drawing.Point(427, 382);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(39, 42);
            this.buttonEnviar.TabIndex = 2;
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // listBoxAnotacao
            // 
            this.listBoxAnotacao.BackColor = System.Drawing.SystemColors.GrayText;
            this.listBoxAnotacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAnotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnotacao.FormattingEnabled = true;
            this.listBoxAnotacao.ItemHeight = 16;
            this.listBoxAnotacao.Location = new System.Drawing.Point(12, 12);
            this.listBoxAnotacao.Name = "listBoxAnotacao";
            this.listBoxAnotacao.Size = new System.Drawing.Size(454, 352);
            this.listBoxAnotacao.TabIndex = 5;
            // 
            // FormAnotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(478, 436);
            this.Controls.Add(this.listBoxAnotacao);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnotacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anotações";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAnotacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTexto;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.ListBox listBoxAnotacao;
    }
}