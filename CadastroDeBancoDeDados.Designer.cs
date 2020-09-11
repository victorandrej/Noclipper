namespace NoClipper
{
    partial class CadastroDeBancoDeDados
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
            this.TB_Endereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_salvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Porta = new System.Windows.Forms.TextBox();
            this.BT_limpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NomeDoBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_Endereco
            // 
            this.TB_Endereco.Location = new System.Drawing.Point(7, 65);
            this.TB_Endereco.Name = "TB_Endereco";
            this.TB_Endereco.Size = new System.Drawing.Size(100, 20);
            this.TB_Endereco.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereco";
            // 
            // BT_salvar
            // 
            this.BT_salvar.Location = new System.Drawing.Point(20, 131);
            this.BT_salvar.Name = "BT_salvar";
            this.BT_salvar.Size = new System.Drawing.Size(75, 23);
            this.BT_salvar.TabIndex = 2;
            this.BT_salvar.Text = "Salvar";
            this.BT_salvar.UseVisualStyleBackColor = true;
            this.BT_salvar.Click += new System.EventHandler(this.BT_salvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Location = new System.Drawing.Point(7, 105);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TB_Usuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // TB_Senha
            // 
            this.TB_Senha.Location = new System.Drawing.Point(113, 105);
            this.TB_Senha.Name = "TB_Senha";
            this.TB_Senha.PasswordChar = '*';
            this.TB_Senha.Size = new System.Drawing.Size(100, 20);
            this.TB_Senha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Porta";
            // 
            // TB_Porta
            // 
            this.TB_Porta.Location = new System.Drawing.Point(113, 65);
            this.TB_Porta.Name = "TB_Porta";
            this.TB_Porta.Size = new System.Drawing.Size(100, 20);
            this.TB_Porta.TabIndex = 7;
            // 
            // BT_limpar
            // 
            this.BT_limpar.Location = new System.Drawing.Point(121, 131);
            this.BT_limpar.Name = "BT_limpar";
            this.BT_limpar.Size = new System.Drawing.Size(75, 23);
            this.BT_limpar.TabIndex = 9;
            this.BT_limpar.Text = "Limpar";
            this.BT_limpar.UseVisualStyleBackColor = true;
            this.BT_limpar.Click += new System.EventHandler(this.BT_limpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome Do Banco";
            // 
            // TB_NomeDoBanco
            // 
            this.TB_NomeDoBanco.Location = new System.Drawing.Point(67, 26);
            this.TB_NomeDoBanco.Name = "TB_NomeDoBanco";
            this.TB_NomeDoBanco.Size = new System.Drawing.Size(100, 20);
            this.TB_NomeDoBanco.TabIndex = 10;
            // 
            // CadastroDeBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 168);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_NomeDoBanco);
            this.Controls.Add(this.BT_limpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Porta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Usuario);
            this.Controls.Add(this.BT_salvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Endereco);
            this.MaximumSize = new System.Drawing.Size(255, 207);
            this.MinimumSize = new System.Drawing.Size(255, 207);
            this.Name = "CadastroDeBancoDeDados";
            this.Text = "CadastroDeBancoDeDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Endereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_salvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Porta;
        private System.Windows.Forms.Button BT_limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NomeDoBanco;
    }
}