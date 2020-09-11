namespace NoClipper
{
    partial class ErroCadastroClientes
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
            this.LB_CnpjNaoCadastrado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LB_CnpjNaoCadastrado
            // 
            this.LB_CnpjNaoCadastrado.FormattingEnabled = true;
            this.LB_CnpjNaoCadastrado.Items.AddRange(new object[] {
            "CNPJ NÃO CADASTRADOS"});
            this.LB_CnpjNaoCadastrado.Location = new System.Drawing.Point(0, 0);
            this.LB_CnpjNaoCadastrado.Name = "LB_CnpjNaoCadastrado";
            this.LB_CnpjNaoCadastrado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_CnpjNaoCadastrado.Size = new System.Drawing.Size(482, 303);
            this.LB_CnpjNaoCadastrado.TabIndex = 0;
            // 
            // ErroCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.LB_CnpjNaoCadastrado);
            this.MaximumSize = new System.Drawing.Size(498, 342);
            this.MinimumSize = new System.Drawing.Size(498, 342);
            this.Name = "ErroCadastroClientes";
            this.Text = "ErroCadastroClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_CnpjNaoCadastrado;
    }
}