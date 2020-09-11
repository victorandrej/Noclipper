namespace NoClipper
{
    partial class CadastroDeProdutosDoCliente
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
            this.BT_salvar = new System.Windows.Forms.Button();
            this.DGV_Itens = new System.Windows.Forms.DataGridView();
            this.DGV_parceiro = new System.Windows.Forms.DataGridView();
            this.NomeParceiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoJfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Itens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_salvar
            // 
            this.BT_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_salvar.Location = new System.Drawing.Point(573, 273);
            this.BT_salvar.Name = "BT_salvar";
            this.BT_salvar.Size = new System.Drawing.Size(215, 88);
            this.BT_salvar.TabIndex = 0;
            this.BT_salvar.Text = "Salvar";
            this.BT_salvar.UseVisualStyleBackColor = true;
            this.BT_salvar.Click += new System.EventHandler(this.BT_salvar_Click);
            // 
            // DGV_Itens
            // 
            this.DGV_Itens.AllowUserToAddRows = false;
            this.DGV_Itens.AllowUserToDeleteRows = false;
            this.DGV_Itens.AllowUserToResizeRows = false;
            this.DGV_Itens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Itens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.CodigoJfc});
            this.DGV_Itens.Location = new System.Drawing.Point(369, 1);
            this.DGV_Itens.Name = "DGV_Itens";
            this.DGV_Itens.ReadOnly = true;
            this.DGV_Itens.RowHeadersVisible = false;
            this.DGV_Itens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Itens.Size = new System.Drawing.Size(431, 266);
            this.DGV_Itens.TabIndex = 1;
            this.DGV_Itens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Itens_CellClick);
            this.DGV_Itens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Itens_CellDoubleClick);
            this.DGV_Itens.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Itens_CellValidated);
            this.DGV_Itens.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_Itens_CellValidating);
            this.DGV_Itens.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Itens_CellValueChanged);
            this.DGV_Itens.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_Itens_EditingControlShowing);
            // 
            // DGV_parceiro
            // 
            this.DGV_parceiro.AllowUserToAddRows = false;
            this.DGV_parceiro.AllowUserToDeleteRows = false;
            this.DGV_parceiro.AllowUserToResizeRows = false;
            this.DGV_parceiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_parceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_parceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeParceiro,
            this.Matriz});
            this.DGV_parceiro.Location = new System.Drawing.Point(0, 1);
            this.DGV_parceiro.Name = "DGV_parceiro";
            this.DGV_parceiro.ReadOnly = true;
            this.DGV_parceiro.RowHeadersVisible = false;
            this.DGV_parceiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_parceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_parceiro.Size = new System.Drawing.Size(363, 266);
            this.DGV_parceiro.TabIndex = 2;
            this.DGV_parceiro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_parceiro_CellContentClick);
            this.DGV_parceiro.SelectionChanged += new System.EventHandler(this.DGV_parceiro_SelectionChanged);
            // 
            // NomeParceiro
            // 
            this.NomeParceiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeParceiro.HeaderText = "Parceiro";
            this.NomeParceiro.MinimumWidth = 50;
            this.NomeParceiro.Name = "NomeParceiro";
            this.NomeParceiro.ReadOnly = true;
            // 
            // Matriz
            // 
            this.Matriz.HeaderText = "Matriz";
            this.Matriz.MinimumWidth = 50;
            this.Matriz.Name = "Matriz";
            this.Matriz.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // CodigoJfc
            // 
            this.CodigoJfc.HeaderText = "CodigoJfc";
            this.CodigoJfc.Name = "CodigoJfc";
            this.CodigoJfc.ReadOnly = true;
            this.CodigoJfc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodigoJfc.Width = 200;
            // 
            // CadastroDeProdutosDoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_parceiro);
            this.Controls.Add(this.DGV_Itens);
            this.Controls.Add(this.BT_salvar);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CadastroDeProdutosDoCliente";
            this.Text = "CadastroDeProdutosDoCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroDeProdutosDoCliente_FormClosed);
            this.Load += new System.EventHandler(this.CadastroDeProdutosDoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Itens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_parceiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_salvar;
        private System.Windows.Forms.DataGridView DGV_Itens;
        private System.Windows.Forms.DataGridView DGV_parceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoJfc;
    }
}