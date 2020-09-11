namespace NoClipper
{
    partial class CadastroDeClientesRapido
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
            this.Bt_salvar = new System.Windows.Forms.Button();
            this.TB_cnpj = new System.Windows.Forms.TextBox();
            this.TB_CodJfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_salvar
            // 
            this.Bt_salvar.Location = new System.Drawing.Point(80, 105);
            this.Bt_salvar.Name = "Bt_salvar";
            this.Bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.Bt_salvar.TabIndex = 1;
            this.Bt_salvar.Text = "Salvar";
            this.Bt_salvar.UseVisualStyleBackColor = true;
            this.Bt_salvar.Click += new System.EventHandler(this.Bt_salvar_Click);
            // 
            // TB_cnpj
            // 
            this.TB_cnpj.Location = new System.Drawing.Point(17, 79);
            this.TB_cnpj.Name = "TB_cnpj";
            this.TB_cnpj.ReadOnly = true;
            this.TB_cnpj.Size = new System.Drawing.Size(100, 20);
            this.TB_cnpj.TabIndex = 3;
            // 
            // TB_CodJfc
            // 
            this.TB_CodJfc.Location = new System.Drawing.Point(123, 79);
            this.TB_CodJfc.MaxLength = 6;
            this.TB_CodJfc.Name = "TB_CodJfc";
            this.TB_CodJfc.Size = new System.Drawing.Size(100, 20);
            this.TB_CodJfc.TabIndex = 4;
            this.TB_CodJfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CodigoJfc";
            // 
            // CadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CodJfc);
            this.Controls.Add(this.TB_cnpj);
            this.Controls.Add(this.Bt_salvar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(272, 244);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(272, 244);
            this.Name = "CadastroDeClientes";
            this.Text = "CadastroDeClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bt_salvar;
        private System.Windows.Forms.TextBox TB_cnpj;
        private System.Windows.Forms.TextBox TB_CodJfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}