namespace NoClipper
{
    partial class Login
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
            this.TxbUsuario = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.BtLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxbUsuario
            // 
            this.TxbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxbUsuario.Location = new System.Drawing.Point(91, 55);
            this.TxbUsuario.Name = "TxbUsuario";
            this.TxbUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxbUsuario.TabIndex = 0;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxbSenha.Location = new System.Drawing.Point(91, 81);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(100, 20);
            this.TxbSenha.TabIndex = 1;
            this.TxbSenha.UseSystemPasswordChar = true;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(34, 55);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Senha
            // 
            this.Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(34, 88);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha";
            // 
            // BtLogar
            // 
            this.BtLogar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtLogar.Location = new System.Drawing.Point(78, 122);
            this.BtLogar.Name = "BtLogar";
            this.BtLogar.Size = new System.Drawing.Size(75, 23);
            this.BtLogar.TabIndex = 4;
            this.BtLogar.Text = "Logar";
            this.BtLogar.UseVisualStyleBackColor = true;
            this.BtLogar.Click += new System.EventHandler(this.BtLogar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 176);
            this.Controls.Add(this.BtLogar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(247, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(247, 215);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbUsuario;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Button BtLogar;
    }
}