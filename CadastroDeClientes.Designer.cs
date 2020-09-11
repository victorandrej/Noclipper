namespace NoClipper
{
    partial class CadastroDeClientes
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
            this.DGV_Cliente = new System.Windows.Forms.DataGridView();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODJFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_apagar = new System.Windows.Forms.Button();
            this.BT_salvar = new System.Windows.Forms.Button();
            this.TB_CNPJ = new System.Windows.Forms.TextBox();
            this.TB_CODJFc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelFiltro = new System.Windows.Forms.Label();
            this.TB_filtro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Cliente
            // 
            this.DGV_Cliente.AllowUserToAddRows = false;
            this.DGV_Cliente.AllowUserToDeleteRows = false;
            this.DGV_Cliente.AllowUserToResizeRows = false;
            this.DGV_Cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNPJ,
            this.CODJFC});
            this.DGV_Cliente.Location = new System.Drawing.Point(339, 1);
            this.DGV_Cliente.MultiSelect = false;
            this.DGV_Cliente.Name = "DGV_Cliente";
            this.DGV_Cliente.ReadOnly = true;
            this.DGV_Cliente.RowHeadersVisible = false;
            this.DGV_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Cliente.Size = new System.Drawing.Size(460, 379);
            this.DGV_Cliente.TabIndex = 0;
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // CODJFC
            // 
            this.CODJFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODJFC.HeaderText = "COD JFC";
            this.CODJFC.Name = "CODJFC";
            this.CODJFC.ReadOnly = true;
            // 
            // BT_apagar
            // 
            this.BT_apagar.Location = new System.Drawing.Point(258, 31);
            this.BT_apagar.Name = "BT_apagar";
            this.BT_apagar.Size = new System.Drawing.Size(75, 23);
            this.BT_apagar.TabIndex = 1;
            this.BT_apagar.Text = "Apagar";
            this.BT_apagar.UseVisualStyleBackColor = true;
            this.BT_apagar.Click += new System.EventHandler(this.BT_apagar_Click);
            // 
            // BT_salvar
            // 
            this.BT_salvar.Location = new System.Drawing.Point(125, 225);
            this.BT_salvar.Name = "BT_salvar";
            this.BT_salvar.Size = new System.Drawing.Size(75, 23);
            this.BT_salvar.TabIndex = 2;
            this.BT_salvar.Text = "Adicionar";
            this.BT_salvar.UseVisualStyleBackColor = true;
            this.BT_salvar.Click += new System.EventHandler(this.BT_salvar_Click);
            // 
            // TB_CNPJ
            // 
            this.TB_CNPJ.Location = new System.Drawing.Point(53, 199);
            this.TB_CNPJ.MaxLength = 14;
            this.TB_CNPJ.Name = "TB_CNPJ";
            this.TB_CNPJ.Size = new System.Drawing.Size(100, 20);
            this.TB_CNPJ.TabIndex = 3;
            this.TB_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_CNPJ_KeyPress);
            // 
            // TB_CODJFc
            // 
            this.TB_CODJFc.Location = new System.Drawing.Point(159, 199);
            this.TB_CODJFc.MaxLength = 6;
            this.TB_CODJFc.Name = "TB_CODJFc";
            this.TB_CODJFc.Size = new System.Drawing.Size(100, 20);
            this.TB_CODJFc.TabIndex = 4;
            this.TB_CODJFc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_CODJFc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CodJFC";
            // 
            // LabelFiltro
            // 
            this.LabelFiltro.AutoSize = true;
            this.LabelFiltro.Location = new System.Drawing.Point(162, 15);
            this.LabelFiltro.Name = "LabelFiltro";
            this.LabelFiltro.Size = new System.Drawing.Size(29, 13);
            this.LabelFiltro.TabIndex = 8;
            this.LabelFiltro.Text = "Filtro";
            // 
            // TB_filtro
            // 
            this.TB_filtro.Location = new System.Drawing.Point(133, 31);
            this.TB_filtro.MaxLength = 14;
            this.TB_filtro.Name = "TB_filtro";
            this.TB_filtro.Size = new System.Drawing.Size(100, 20);
            this.TB_filtro.TabIndex = 7;
            this.TB_filtro.TextChanged += new System.EventHandler(this.TB_filtro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apagar Cliente";
            // 
            // CadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelFiltro);
            this.Controls.Add(this.TB_filtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CODJFc);
            this.Controls.Add(this.TB_CNPJ);
            this.Controls.Add(this.BT_salvar);
            this.Controls.Add(this.BT_apagar);
            this.Controls.Add(this.DGV_Cliente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 420);
            this.Name = "CadastroDeClientes";
            this.Text = "CadastroDeClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Cliente;
        private System.Windows.Forms.Button BT_apagar;
        private System.Windows.Forms.Button BT_salvar;
        private System.Windows.Forms.TextBox TB_CNPJ;
        private System.Windows.Forms.TextBox TB_CODJFc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODJFC;
        private System.Windows.Forms.Label LabelFiltro;
        private System.Windows.Forms.TextBox TB_filtro;
        private System.Windows.Forms.Label label3;
    }
}