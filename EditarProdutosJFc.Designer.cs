namespace NoClipper
{
    partial class EditarProdutosJFc
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
            this.TB_Codigo = new System.Windows.Forms.TextBox();
            this.TB_Descricao = new System.Windows.Forms.TextBox();
            this.TB_Kilagem = new System.Windows.Forms.TextBox();
            this.BT_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_codigo = new System.Windows.Forms.Label();
            this.Lb_Descricao = new System.Windows.Forms.Label();
            this.LB_Kilagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Codigo
            // 
            this.TB_Codigo.Location = new System.Drawing.Point(32, 48);
            this.TB_Codigo.MaxLength = 3;
            this.TB_Codigo.Name = "TB_Codigo";
            this.TB_Codigo.Size = new System.Drawing.Size(37, 20);
            this.TB_Codigo.TabIndex = 0;
            this.TB_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Codigo_KeyPress);
            // 
            // TB_Descricao
            // 
            this.TB_Descricao.Location = new System.Drawing.Point(75, 48);
            this.TB_Descricao.Name = "TB_Descricao";
            this.TB_Descricao.Size = new System.Drawing.Size(100, 20);
            this.TB_Descricao.TabIndex = 1;
            // 
            // TB_Kilagem
            // 
            this.TB_Kilagem.Location = new System.Drawing.Point(181, 48);
            this.TB_Kilagem.MaxLength = 5;
            this.TB_Kilagem.Name = "TB_Kilagem";
            this.TB_Kilagem.Size = new System.Drawing.Size(37, 20);
            this.TB_Kilagem.TabIndex = 2;
            this.TB_Kilagem.TextChanged += new System.EventHandler(this.TB_Kilagem_TextChanged);
            this.TB_Kilagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Kilagem_KeyPress);
            // 
            // BT_salvar
            // 
            this.BT_salvar.Location = new System.Drawing.Point(224, 47);
            this.BT_salvar.Name = "BT_salvar";
            this.BT_salvar.Size = new System.Drawing.Size(75, 20);
            this.BT_salvar.TabIndex = 3;
            this.BT_salvar.Text = "Salvar";
            this.BT_salvar.UseVisualStyleBackColor = true;
            this.BT_salvar.Click += new System.EventHandler(this.BT_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kilagem";
            // 
            // Lb_codigo
            // 
            this.Lb_codigo.AutoSize = true;
            this.Lb_codigo.Location = new System.Drawing.Point(29, 32);
            this.Lb_codigo.Name = "Lb_codigo";
            this.Lb_codigo.Size = new System.Drawing.Size(55, 13);
            this.Lb_codigo.TabIndex = 7;
            this.Lb_codigo.Text = "Descricao";
            // 
            // Lb_Descricao
            // 
            this.Lb_Descricao.AutoSize = true;
            this.Lb_Descricao.Location = new System.Drawing.Point(90, 32);
            this.Lb_Descricao.Name = "Lb_Descricao";
            this.Lb_Descricao.Size = new System.Drawing.Size(72, 13);
            this.Lb_Descricao.TabIndex = 8;
            this.Lb_Descricao.Text = "LB_descricao";
            // 
            // LB_Kilagem
            // 
            this.LB_Kilagem.AutoSize = true;
            this.LB_Kilagem.Location = new System.Drawing.Point(178, 32);
            this.LB_Kilagem.Name = "LB_Kilagem";
            this.LB_Kilagem.Size = new System.Drawing.Size(55, 13);
            this.LB_Kilagem.TabIndex = 9;
            this.LB_Kilagem.Text = "Descricao";
            // 
            // EditarProdutosJFc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 80);
            this.Controls.Add(this.LB_Kilagem);
            this.Controls.Add(this.Lb_Descricao);
            this.Controls.Add(this.Lb_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_salvar);
            this.Controls.Add(this.TB_Kilagem);
            this.Controls.Add(this.TB_Descricao);
            this.Controls.Add(this.TB_Codigo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 119);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(356, 119);
            this.Name = "EditarProdutosJFc";
            this.Text = "EditarProdutosJFc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Codigo;
        private System.Windows.Forms.TextBox TB_Descricao;
        private System.Windows.Forms.TextBox TB_Kilagem;
        private System.Windows.Forms.Button BT_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lb_codigo;
        private System.Windows.Forms.Label Lb_Descricao;
        private System.Windows.Forms.Label LB_Kilagem;
    }
}