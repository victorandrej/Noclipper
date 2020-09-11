namespace NoClipper
{
    partial class AlterarSenha
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
            this.BT_salvarSenha = new System.Windows.Forms.Button();
            this.TB_senhaAntiga = new System.Windows.Forms.TextBox();
            this.TB_senhaNova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_salvarSenha
            // 
            this.BT_salvarSenha.Location = new System.Drawing.Point(93, 102);
            this.BT_salvarSenha.Name = "BT_salvarSenha";
            this.BT_salvarSenha.Size = new System.Drawing.Size(75, 23);
            this.BT_salvarSenha.TabIndex = 0;
            this.BT_salvarSenha.Text = "Alterar";
            this.BT_salvarSenha.UseVisualStyleBackColor = true;
            this.BT_salvarSenha.Click += new System.EventHandler(this.BT_salvarSenha_Click);
            // 
            // TB_senhaAntiga
            // 
            this.TB_senhaAntiga.Location = new System.Drawing.Point(83, 39);
            this.TB_senhaAntiga.Name = "TB_senhaAntiga";
            this.TB_senhaAntiga.PasswordChar = '*';
            this.TB_senhaAntiga.Size = new System.Drawing.Size(100, 20);
            this.TB_senhaAntiga.TabIndex = 1;
            // 
            // TB_senhaNova
            // 
            this.TB_senhaNova.Location = new System.Drawing.Point(83, 76);
            this.TB_senhaNova.Name = "TB_senhaNova";
            this.TB_senhaNova.PasswordChar = '*';
            this.TB_senhaNova.Size = new System.Drawing.Size(100, 20);
            this.TB_senhaNova.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha antiga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova senha";
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_senhaNova);
            this.Controls.Add(this.TB_senhaAntiga);
            this.Controls.Add(this.BT_salvarSenha);
            this.MaximumSize = new System.Drawing.Size(273, 188);
            this.MinimumSize = new System.Drawing.Size(273, 188);
            this.Name = "AlterarSenha";
            this.Text = "Alterar Senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlterarSenha_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_salvarSenha;
        private System.Windows.Forms.TextBox TB_senhaAntiga;
        private System.Windows.Forms.TextBox TB_senhaNova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}