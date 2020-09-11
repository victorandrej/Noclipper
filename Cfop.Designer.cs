namespace NoClipper
{
    partial class Cfop
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
            this.TB_CFOP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_apagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Descricao = new System.Windows.Forms.TextBox();
            this.BT_adicionar = new System.Windows.Forms.Button();
            this.Dg_cfops = new System.Windows.Forms.DataGridView();
            this.DG_Cfop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_cfops)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_CFOP
            // 
            this.TB_CFOP.Location = new System.Drawing.Point(32, 118);
            this.TB_CFOP.Name = "TB_CFOP";
            this.TB_CFOP.Size = new System.Drawing.Size(100, 20);
            this.TB_CFOP.TabIndex = 0;
            this.TB_CFOP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_CFOP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CFOP";
            // 
            // BT_apagar
            // 
            this.BT_apagar.Location = new System.Drawing.Point(192, 12);
            this.BT_apagar.Name = "BT_apagar";
            this.BT_apagar.Size = new System.Drawing.Size(75, 23);
            this.BT_apagar.TabIndex = 3;
            this.BT_apagar.Text = "Apagar";
            this.BT_apagar.UseVisualStyleBackColor = true;
            this.BT_apagar.Click += new System.EventHandler(this.BT_apagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descricao";
            // 
            // TB_Descricao
            // 
            this.TB_Descricao.Location = new System.Drawing.Point(138, 118);
            this.TB_Descricao.Name = "TB_Descricao";
            this.TB_Descricao.Size = new System.Drawing.Size(100, 20);
            this.TB_Descricao.TabIndex = 4;
            // 
            // BT_adicionar
            // 
            this.BT_adicionar.Location = new System.Drawing.Point(93, 144);
            this.BT_adicionar.Name = "BT_adicionar";
            this.BT_adicionar.Size = new System.Drawing.Size(75, 23);
            this.BT_adicionar.TabIndex = 6;
            this.BT_adicionar.Text = "Adicionar";
            this.BT_adicionar.UseVisualStyleBackColor = true;
            this.BT_adicionar.Click += new System.EventHandler(this.BT_adicionar_Click);
            // 
            // Dg_cfops
            // 
            this.Dg_cfops.AllowUserToAddRows = false;
            this.Dg_cfops.AllowUserToDeleteRows = false;
            this.Dg_cfops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_cfops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_Cfop,
            this.DG_descricao});
            this.Dg_cfops.Location = new System.Drawing.Point(273, 0);
            this.Dg_cfops.Name = "Dg_cfops";
            this.Dg_cfops.ReadOnly = true;
            this.Dg_cfops.RowHeadersVisible = false;
            this.Dg_cfops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_cfops.Size = new System.Drawing.Size(334, 316);
            this.Dg_cfops.TabIndex = 7;
            // 
            // DG_Cfop
            // 
            this.DG_Cfop.HeaderText = "Cfop";
            this.DG_Cfop.Name = "DG_Cfop";
            this.DG_Cfop.ReadOnly = true;
            // 
            // DG_descricao
            // 
            this.DG_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DG_descricao.HeaderText = "Descricao";
            this.DG_descricao.Name = "DG_descricao";
            this.DG_descricao.ReadOnly = true;
            // 
            // Cfop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 316);
            this.Controls.Add(this.Dg_cfops);
            this.Controls.Add(this.BT_adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Descricao);
            this.Controls.Add(this.BT_apagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CFOP);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(623, 355);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(623, 355);
            this.Name = "Cfop";
            this.Text = "Cfop";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_cfops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_CFOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_apagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Descricao;
        private System.Windows.Forms.Button BT_adicionar;
        private System.Windows.Forms.DataGridView Dg_cfops;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Cfop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_descricao;
    }
}