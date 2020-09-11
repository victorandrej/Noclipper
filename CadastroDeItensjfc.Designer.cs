namespace NoClipper
{
    partial class CadastroDeItensjfc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelecionarPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.BT_excluir = new System.Windows.Forms.Button();
            this.BT_Editar = new System.Windows.Forms.Button();
            this.TB_codigo = new System.Windows.Forms.TextBox();
            this.TB_Descricao = new System.Windows.Forms.TextBox();
            this.TB_kilagem = new System.Windows.Forms.TextBox();
            this.BT_maiscadastros = new System.Windows.Forms.Button();
            this.Bt_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_ProdutosCadastrados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProdutosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // SelecionarPasta
            // 
            this.SelecionarPasta.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // BT_excluir
            // 
            this.BT_excluir.Location = new System.Drawing.Point(173, 12);
            this.BT_excluir.Name = "BT_excluir";
            this.BT_excluir.Size = new System.Drawing.Size(75, 23);
            this.BT_excluir.TabIndex = 3;
            this.BT_excluir.Text = "Excluir";
            this.BT_excluir.UseVisualStyleBackColor = true;
            this.BT_excluir.Click += new System.EventHandler(this.BT_excluir_Click);
            // 
            // BT_Editar
            // 
            this.BT_Editar.Location = new System.Drawing.Point(92, 12);
            this.BT_Editar.Name = "BT_Editar";
            this.BT_Editar.Size = new System.Drawing.Size(75, 23);
            this.BT_Editar.TabIndex = 4;
            this.BT_Editar.Text = "Editar";
            this.BT_Editar.UseVisualStyleBackColor = true;
            this.BT_Editar.Click += new System.EventHandler(this.BT_Editar_Click);
            // 
            // TB_codigo
            // 
            this.TB_codigo.Location = new System.Drawing.Point(15, 63);
            this.TB_codigo.MaxLength = 3;
            this.TB_codigo.Name = "TB_codigo";
            this.TB_codigo.Size = new System.Drawing.Size(37, 20);
            this.TB_codigo.TabIndex = 6;
            this.TB_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCodigo_KeyPress);
            // 
            // TB_Descricao
            // 
            this.TB_Descricao.Location = new System.Drawing.Point(58, 63);
            this.TB_Descricao.Name = "TB_Descricao";
            this.TB_Descricao.Size = new System.Drawing.Size(100, 20);
            this.TB_Descricao.TabIndex = 7;
            // 
            // TB_kilagem
            // 
            this.TB_kilagem.Location = new System.Drawing.Point(164, 63);
            this.TB_kilagem.MaxLength = 5;
            this.TB_kilagem.Name = "TB_kilagem";
            this.TB_kilagem.Size = new System.Drawing.Size(37, 20);
            this.TB_kilagem.TabIndex = 8;
            this.TB_kilagem.TextChanged += new System.EventHandler(this.TB_kilagem_TextChanged);
            this.TB_kilagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_kilagem_KeyPress);
            // 
            // BT_maiscadastros
            // 
            this.BT_maiscadastros.Location = new System.Drawing.Point(207, 62);
            this.BT_maiscadastros.Name = "BT_maiscadastros";
            this.BT_maiscadastros.Size = new System.Drawing.Size(31, 23);
            this.BT_maiscadastros.TabIndex = 9;
            this.BT_maiscadastros.Text = "+";
            this.BT_maiscadastros.UseVisualStyleBackColor = true;
            this.BT_maiscadastros.Click += new System.EventHandler(this.BT_maiscadastros_Click);
            // 
            // Bt_salvar
            // 
            this.Bt_salvar.Location = new System.Drawing.Point(69, 89);
            this.Bt_salvar.Name = "Bt_salvar";
            this.Bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.Bt_salvar.TabIndex = 10;
            this.Bt_salvar.Text = "Salvar";
            this.Bt_salvar.UseVisualStyleBackColor = true;
            this.Bt_salvar.Click += new System.EventHandler(this.Bt_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kilagem";
            // 
            // DGV_ProdutosCadastrados
            // 
            this.DGV_ProdutosCadastrados.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DGV_ProdutosCadastrados.AllowUserToAddRows = false;
            this.DGV_ProdutosCadastrados.AllowUserToDeleteRows = false;
            this.DGV_ProdutosCadastrados.AllowUserToResizeRows = false;
            this.DGV_ProdutosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ProdutosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ProdutosCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Kilagem});
            this.DGV_ProdutosCadastrados.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_ProdutosCadastrados.Location = new System.Drawing.Point(254, 0);
            this.DGV_ProdutosCadastrados.MultiSelect = false;
            this.DGV_ProdutosCadastrados.Name = "DGV_ProdutosCadastrados";
            this.DGV_ProdutosCadastrados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ProdutosCadastrados.RowHeadersVisible = false;
            this.DGV_ProdutosCadastrados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_ProdutosCadastrados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_ProdutosCadastrados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_ProdutosCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ProdutosCadastrados.Size = new System.Drawing.Size(471, 449);
            this.DGV_ProdutosCadastrados.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Kilagem
            // 
            this.Kilagem.HeaderText = "Kilagem";
            this.Kilagem.Name = "Kilagem";
            this.Kilagem.ReadOnly = true;
            // 
            // CadastroDeItensjfc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.DGV_ProdutosCadastrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_salvar);
            this.Controls.Add(this.BT_maiscadastros);
            this.Controls.Add(this.TB_kilagem);
            this.Controls.Add(this.TB_Descricao);
            this.Controls.Add(this.TB_codigo);
            this.Controls.Add(this.BT_Editar);
            this.Controls.Add(this.BT_excluir);
            this.MinimumSize = new System.Drawing.Size(741, 489);
            this.Name = "CadastroDeItensjfc";
            this.Text = "CadastroDeItens";
            this.Load += new System.EventHandler(this.CadastroDeItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProdutosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog SelecionarPasta;
        private System.Windows.Forms.Button BT_excluir;
        private System.Windows.Forms.Button BT_Editar;
        private System.Windows.Forms.TextBox TB_codigo;
        private System.Windows.Forms.TextBox TB_Descricao;
        private System.Windows.Forms.TextBox TB_kilagem;
        private System.Windows.Forms.Button BT_maiscadastros;
        private System.Windows.Forms.Button Bt_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_ProdutosCadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilagem;
    }
}

