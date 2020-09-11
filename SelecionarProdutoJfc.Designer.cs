namespace NoClipper
{
    partial class SelecionarProdutoJfc
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DG_CodigoJfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGv_descricaoJFc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_CodigoJfc,
            this.DGv_descricaoJFc});
            this.DataGrid.Location = new System.Drawing.Point(182, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(483, 366);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentDoubleClick);
            this.DataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DG_CodigoJfc
            // 
            this.DG_CodigoJfc.HeaderText = "CodigoJFC";
            this.DG_CodigoJfc.Name = "DG_CodigoJfc";
            this.DG_CodigoJfc.ReadOnly = true;
            // 
            // DGv_descricaoJFc
            // 
            this.DGv_descricaoJFc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGv_descricaoJFc.HeaderText = "descricao";
            this.DGv_descricaoJFc.Name = "DGv_descricaoJFc";
            this.DGv_descricaoJFc.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "filtro";
            // 
            // SelecionarProdutoJfc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGrid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 405);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(681, 405);
            this.Name = "SelecionarProdutoJfc";
            this.Text = "SelecionarProdutoJfc";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_CodigoJfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGv_descricaoJFc;
        private System.Windows.Forms.Label label1;
    }
}