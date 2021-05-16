namespace Projeto_Portaria
{
    partial class NovoCond
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
            this.textBoxNomeCond = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNomeCond
            // 
            this.textBoxNomeCond.Location = new System.Drawing.Point(18, 15);
            this.textBoxNomeCond.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeCond.Name = "textBoxNomeCond";
            this.textBoxNomeCond.Size = new System.Drawing.Size(427, 22);
            this.textBoxNomeCond.TabIndex = 0;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Horizontal",
            "Vertical"});
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.comboBoxTipo.Location = new System.Drawing.Point(18, 47);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(259, 24);
            this.comboBoxTipo.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(146, 80);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 28);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Salvar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(409, 119);
            this.textBoxCod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(30, 22);
            this.textBoxCod.TabIndex = 3;
            this.textBoxCod.Visible = false;
            // 
            // NovoCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(452, 145);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxNomeCond);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoCond";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NovoCond_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeCond;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCod;
    }
}