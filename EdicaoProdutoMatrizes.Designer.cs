namespace NoClipper
{
    partial class EdicaoProdutoMatrizes
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
            this.DTGV_SemModificacao = new System.Windows.Forms.DataGridView();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoJFc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricaojfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTgv_ComModificacao = new System.Windows.Forms.DataGridView();
            this.DGV_Coluna_Edicao_CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Coluna_Edicao_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Coluna_Edicao_CodigoJfc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DGV_EDItadoDescricaoJfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Coluna_Edicao_Matriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_MoverParaEdicao = new System.Windows.Forms.Button();
            this.BT_removerDaEdicao = new System.Windows.Forms.Button();
            this.BT_Editar = new System.Windows.Forms.Button();
            this.BT_Apagar = new System.Windows.Forms.Button();
            this.TXB_Filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_SemModificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTgv_ComModificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_SemModificacao
            // 
            this.DTGV_SemModificacao.AllowUserToAddRows = false;
            this.DTGV_SemModificacao.AllowUserToDeleteRows = false;
            this.DTGV_SemModificacao.AllowUserToResizeRows = false;
            this.DTGV_SemModificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DTGV_SemModificacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGV_SemModificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_SemModificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCliente,
            this.Descricao,
            this.CodigoJFc,
            this.Descricaojfc,
            this.Matriz});
            this.DTGV_SemModificacao.Location = new System.Drawing.Point(0, 0);
            this.DTGV_SemModificacao.MultiSelect = false;
            this.DTGV_SemModificacao.Name = "DTGV_SemModificacao";
            this.DTGV_SemModificacao.ReadOnly = true;
            this.DTGV_SemModificacao.RowHeadersVisible = false;
            this.DTGV_SemModificacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGV_SemModificacao.Size = new System.Drawing.Size(526, 311);
            this.DTGV_SemModificacao.TabIndex = 0;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.FillWeight = 99.61929F;
            this.CodigoCliente.HeaderText = "CodigoCliente";
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.FillWeight = 99.61929F;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // CodigoJFc
            // 
            this.CodigoJFc.FillWeight = 101.5228F;
            this.CodigoJFc.HeaderText = "CodigoJFc";
            this.CodigoJFc.Name = "CodigoJFc";
            this.CodigoJFc.ReadOnly = true;
            this.CodigoJFc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodigoJFc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descricaojfc
            // 
            this.Descricaojfc.FillWeight = 99.61929F;
            this.Descricaojfc.HeaderText = "Descricaojfc";
            this.Descricaojfc.Name = "Descricaojfc";
            this.Descricaojfc.ReadOnly = true;
            // 
            // Matriz
            // 
            this.Matriz.FillWeight = 99.61929F;
            this.Matriz.HeaderText = "Matriz";
            this.Matriz.Name = "Matriz";
            this.Matriz.ReadOnly = true;
            // 
            // DTgv_ComModificacao
            // 
            this.DTgv_ComModificacao.AllowUserToAddRows = false;
            this.DTgv_ComModificacao.AllowUserToDeleteRows = false;
            this.DTgv_ComModificacao.AllowUserToResizeRows = false;
            this.DTgv_ComModificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DTgv_ComModificacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTgv_ComModificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Coluna_Edicao_CodigoCliente,
            this.DGV_Coluna_Edicao_Descricao,
            this.DGV_Coluna_Edicao_CodigoJfc,
            this.DGV_EDItadoDescricaoJfc,
            this.DGV_Coluna_Edicao_Matriz});
            this.DTgv_ComModificacao.Location = new System.Drawing.Point(610, 0);
            this.DTgv_ComModificacao.MultiSelect = false;
            this.DTgv_ComModificacao.Name = "DTgv_ComModificacao";
            this.DTgv_ComModificacao.RowHeadersVisible = false;
            this.DTgv_ComModificacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTgv_ComModificacao.Size = new System.Drawing.Size(526, 311);
            this.DTgv_ComModificacao.TabIndex = 1;
            this.DTgv_ComModificacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTgv_ComModificacao_CellClick);
            this.DTgv_ComModificacao.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DTgv_ComModificacao_CellMouseClick);
            // 
            // DGV_Coluna_Edicao_CodigoCliente
            // 
            this.DGV_Coluna_Edicao_CodigoCliente.HeaderText = "CodigoCliente";
            this.DGV_Coluna_Edicao_CodigoCliente.Name = "DGV_Coluna_Edicao_CodigoCliente";
            this.DGV_Coluna_Edicao_CodigoCliente.ReadOnly = true;
            // 
            // DGV_Coluna_Edicao_Descricao
            // 
            this.DGV_Coluna_Edicao_Descricao.HeaderText = "Descricao";
            this.DGV_Coluna_Edicao_Descricao.Name = "DGV_Coluna_Edicao_Descricao";
            this.DGV_Coluna_Edicao_Descricao.ReadOnly = true;
            // 
            // DGV_Coluna_Edicao_CodigoJfc
            // 
            this.DGV_Coluna_Edicao_CodigoJfc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.DGV_Coluna_Edicao_CodigoJfc.HeaderText = "Produto Jfc";
            this.DGV_Coluna_Edicao_CodigoJfc.Name = "DGV_Coluna_Edicao_CodigoJfc";
            this.DGV_Coluna_Edicao_CodigoJfc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Coluna_Edicao_CodigoJfc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DGV_EDItadoDescricaoJfc
            // 
            this.DGV_EDItadoDescricaoJfc.HeaderText = "DescricaoJfc";
            this.DGV_EDItadoDescricaoJfc.Name = "DGV_EDItadoDescricaoJfc";
            this.DGV_EDItadoDescricaoJfc.ReadOnly = true;
            // 
            // DGV_Coluna_Edicao_Matriz
            // 
            this.DGV_Coluna_Edicao_Matriz.HeaderText = "Matriz";
            this.DGV_Coluna_Edicao_Matriz.Name = "DGV_Coluna_Edicao_Matriz";
            this.DGV_Coluna_Edicao_Matriz.ReadOnly = true;
            // 
            // BT_MoverParaEdicao
            // 
            this.BT_MoverParaEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MoverParaEdicao.Location = new System.Drawing.Point(532, 125);
            this.BT_MoverParaEdicao.Name = "BT_MoverParaEdicao";
            this.BT_MoverParaEdicao.Size = new System.Drawing.Size(72, 23);
            this.BT_MoverParaEdicao.TabIndex = 2;
            this.BT_MoverParaEdicao.Text = "-->";
            this.BT_MoverParaEdicao.UseVisualStyleBackColor = true;
            this.BT_MoverParaEdicao.Click += new System.EventHandler(this.BT_MoverParaEdicao_Click);
            // 
            // BT_removerDaEdicao
            // 
            this.BT_removerDaEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_removerDaEdicao.Location = new System.Drawing.Point(532, 154);
            this.BT_removerDaEdicao.Name = "BT_removerDaEdicao";
            this.BT_removerDaEdicao.Size = new System.Drawing.Size(72, 23);
            this.BT_removerDaEdicao.TabIndex = 3;
            this.BT_removerDaEdicao.Text = "<--";
            this.BT_removerDaEdicao.UseVisualStyleBackColor = true;
            this.BT_removerDaEdicao.Click += new System.EventHandler(this.BT_removerDaEdicao_Click);
            // 
            // BT_Editar
            // 
            this.BT_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Editar.Location = new System.Drawing.Point(569, 317);
            this.BT_Editar.Name = "BT_Editar";
            this.BT_Editar.Size = new System.Drawing.Size(235, 130);
            this.BT_Editar.TabIndex = 4;
            this.BT_Editar.Text = "Editar";
            this.BT_Editar.UseVisualStyleBackColor = true;
            this.BT_Editar.Click += new System.EventHandler(this.BT_Editar_Click);
            // 
            // BT_Apagar
            // 
            this.BT_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Apagar.Location = new System.Drawing.Point(328, 317);
            this.BT_Apagar.Name = "BT_Apagar";
            this.BT_Apagar.Size = new System.Drawing.Size(235, 130);
            this.BT_Apagar.TabIndex = 5;
            this.BT_Apagar.Text = "Apagar";
            this.BT_Apagar.UseVisualStyleBackColor = true;
            this.BT_Apagar.Click += new System.EventHandler(this.BT_Apagar_Click);
            // 
            // TXB_Filtro
            // 
            this.TXB_Filtro.Location = new System.Drawing.Point(108, 338);
            this.TXB_Filtro.Name = "TXB_Filtro";
            this.TXB_Filtro.Size = new System.Drawing.Size(100, 20);
            this.TXB_Filtro.TabIndex = 6;
            this.TXB_Filtro.TextChanged += new System.EventHandler(this.TXB_Filtro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro";
            // 
            // EditarProdutoMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_Filtro);
            this.Controls.Add(this.BT_Apagar);
            this.Controls.Add(this.BT_Editar);
            this.Controls.Add(this.BT_removerDaEdicao);
            this.Controls.Add(this.BT_MoverParaEdicao);
            this.Controls.Add(this.DTgv_ComModificacao);
            this.Controls.Add(this.DTGV_SemModificacao);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1159, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1159, 489);
            this.Name = "EditarProdutoMatrizes";
            this.Text = "EditarProdutoMatrizes";
            this.Load += new System.EventHandler(this.EditarProdutoMatrizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_SemModificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTgv_ComModificacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_SemModificacao;
        private System.Windows.Forms.DataGridView DTgv_ComModificacao;
        private System.Windows.Forms.Button BT_MoverParaEdicao;
        private System.Windows.Forms.Button BT_removerDaEdicao;
        private System.Windows.Forms.Button BT_Editar;
        private System.Windows.Forms.Button BT_Apagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoJFc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricaojfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Coluna_Edicao_CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Coluna_Edicao_Descricao;
        private System.Windows.Forms.DataGridViewComboBoxColumn DGV_Coluna_Edicao_CodigoJfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_EDItadoDescricaoJfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Coluna_Edicao_Matriz;
        private System.Windows.Forms.TextBox TXB_Filtro;
        private System.Windows.Forms.Label label1;
    }
}