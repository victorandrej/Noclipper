namespace NoClipper
{
    partial class FormularioPrincipal
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
            this.TP_Conversor = new System.Windows.Forms.TabControl();
            this.TB_Conversor = new System.Windows.Forms.TabPage();
            this.BT_Importar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbData = new System.Windows.Forms.TextBox();
            this.TxbCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_ProdutosNota = new System.Windows.Forms.ListBox();
            this.LB_ClienteNota = new System.Windows.Forms.ListBox();
            this.BT_Selecionar = new System.Windows.Forms.Button();
            this.TB_Erro = new System.Windows.Forms.TabPage();
            this.BT_cadastrarErro = new System.Windows.Forms.Button();
            this.LB_ErroProduto = new System.Windows.Forms.ListBox();
            this.LB_ErroNotas = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.configuracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosJFCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosDasMatrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TP_Conversor.SuspendLayout();
            this.TB_Conversor.SuspendLayout();
            this.TB_Erro.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TP_Conversor
            // 
            this.TP_Conversor.Controls.Add(this.TB_Conversor);
            this.TP_Conversor.Controls.Add(this.TB_Erro);
            this.TP_Conversor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TP_Conversor.Location = new System.Drawing.Point(0, 24);
            this.TP_Conversor.Name = "TP_Conversor";
            this.TP_Conversor.SelectedIndex = 0;
            this.TP_Conversor.Size = new System.Drawing.Size(747, 309);
            this.TP_Conversor.TabIndex = 0;
            this.TP_Conversor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TP_Conversor_MouseClick);
            // 
            // TB_Conversor
            // 
            this.TB_Conversor.BackColor = System.Drawing.Color.Transparent;
            this.TB_Conversor.Controls.Add(this.BT_Importar);
            this.TB_Conversor.Controls.Add(this.label3);
            this.TB_Conversor.Controls.Add(this.TxbData);
            this.TB_Conversor.Controls.Add(this.TxbCnpj);
            this.TB_Conversor.Controls.Add(this.label2);
            this.TB_Conversor.Controls.Add(this.label1);
            this.TB_Conversor.Controls.Add(this.Lb_ProdutosNota);
            this.TB_Conversor.Controls.Add(this.LB_ClienteNota);
            this.TB_Conversor.Controls.Add(this.BT_Selecionar);
            this.TB_Conversor.Location = new System.Drawing.Point(4, 22);
            this.TB_Conversor.Name = "TB_Conversor";
            this.TB_Conversor.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Conversor.Size = new System.Drawing.Size(739, 283);
            this.TB_Conversor.TabIndex = 0;
            this.TB_Conversor.Text = "Conversor";
            this.TB_Conversor.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // BT_Importar
            // 
            this.BT_Importar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Importar.Location = new System.Drawing.Point(569, 29);
            this.BT_Importar.Name = "BT_Importar";
            this.BT_Importar.Size = new System.Drawing.Size(75, 23);
            this.BT_Importar.TabIndex = 8;
            this.BT_Importar.Text = "Importar";
            this.BT_Importar.UseVisualStyleBackColor = true;
            this.BT_Importar.Click += new System.EventHandler(this.BT_converter);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produtos";
            // 
            // TxbData
            // 
            this.TxbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbData.Location = new System.Drawing.Point(394, 31);
            this.TxbData.Name = "TxbData";
            this.TxbData.ReadOnly = true;
            this.TxbData.Size = new System.Drawing.Size(169, 20);
            this.TxbData.TabIndex = 6;
            // 
            // TxbCnpj
            // 
            this.TxbCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbCnpj.Location = new System.Drawing.Point(394, 6);
            this.TxbCnpj.Name = "TxbCnpj";
            this.TxbCnpj.ReadOnly = true;
            this.TxbCnpj.Size = new System.Drawing.Size(169, 20);
            this.TxbCnpj.TabIndex = 5;
            this.TxbCnpj.TextChanged += new System.EventHandler(this.TxbCnpj_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cnpj :";
            // 
            // Lb_ProdutosNota
            // 
            this.Lb_ProdutosNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_ProdutosNota.FormattingEnabled = true;
            this.Lb_ProdutosNota.Location = new System.Drawing.Point(349, 74);
            this.Lb_ProdutosNota.Name = "Lb_ProdutosNota";
            this.Lb_ProdutosNota.ScrollAlwaysVisible = true;
            this.Lb_ProdutosNota.Size = new System.Drawing.Size(382, 199);
            this.Lb_ProdutosNota.TabIndex = 2;
            // 
            // LB_ClienteNota
            // 
            this.LB_ClienteNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_ClienteNota.FormattingEnabled = true;
            this.LB_ClienteNota.Location = new System.Drawing.Point(0, 0);
            this.LB_ClienteNota.Name = "LB_ClienteNota";
            this.LB_ClienteNota.ScrollAlwaysVisible = true;
            this.LB_ClienteNota.Size = new System.Drawing.Size(337, 277);
            this.LB_ClienteNota.TabIndex = 1;
            this.LB_ClienteNota.SelectedIndexChanged += new System.EventHandler(this.LB_ClienteNota_SelectedIndexChanged);
            // 
            // BT_Selecionar
            // 
            this.BT_Selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Selecionar.Location = new System.Drawing.Point(569, 6);
            this.BT_Selecionar.Name = "BT_Selecionar";
            this.BT_Selecionar.Size = new System.Drawing.Size(75, 23);
            this.BT_Selecionar.TabIndex = 0;
            this.BT_Selecionar.Text = "Selecionar";
            this.BT_Selecionar.UseVisualStyleBackColor = true;
            this.BT_Selecionar.Click += new System.EventHandler(this.BT_Selecionar_Click);
            // 
            // TB_Erro
            // 
            this.TB_Erro.BackColor = System.Drawing.Color.Transparent;
            this.TB_Erro.Controls.Add(this.BT_cadastrarErro);
            this.TB_Erro.Controls.Add(this.LB_ErroProduto);
            this.TB_Erro.Controls.Add(this.LB_ErroNotas);
            this.TB_Erro.Location = new System.Drawing.Point(4, 22);
            this.TB_Erro.Name = "TB_Erro";
            this.TB_Erro.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Erro.Size = new System.Drawing.Size(739, 283);
            this.TB_Erro.TabIndex = 1;
            this.TB_Erro.Text = "Erro";
            // 
            // BT_cadastrarErro
            // 
            this.BT_cadastrarErro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_cadastrarErro.Location = new System.Drawing.Point(324, 6);
            this.BT_cadastrarErro.Name = "BT_cadastrarErro";
            this.BT_cadastrarErro.Size = new System.Drawing.Size(130, 54);
            this.BT_cadastrarErro.TabIndex = 2;
            this.BT_cadastrarErro.Text = "Cadastrar";
            this.BT_cadastrarErro.UseVisualStyleBackColor = true;
            this.BT_cadastrarErro.Click += new System.EventHandler(this.BT_cadastrarErro_Click);
            // 
            // LB_ErroProduto
            // 
            this.LB_ErroProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ErroProduto.FormattingEnabled = true;
            this.LB_ErroProduto.Location = new System.Drawing.Point(162, 0);
            this.LB_ErroProduto.Name = "LB_ErroProduto";
            this.LB_ErroProduto.ScrollAlwaysVisible = true;
            this.LB_ErroProduto.Size = new System.Drawing.Size(156, 277);
            this.LB_ErroProduto.TabIndex = 1;
            // 
            // LB_ErroNotas
            // 
            this.LB_ErroNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_ErroNotas.FormattingEnabled = true;
            this.LB_ErroNotas.Location = new System.Drawing.Point(0, 0);
            this.LB_ErroNotas.Name = "LB_ErroNotas";
            this.LB_ErroNotas.ScrollAlwaysVisible = true;
            this.LB_ErroNotas.Size = new System.Drawing.Size(156, 277);
            this.LB_ErroNotas.TabIndex = 0;
            this.LB_ErroNotas.SelectedIndexChanged += new System.EventHandler(this.LB_ErroNotas_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracaoToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(747, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // configuracaoToolStripMenuItem
            // 
            this.configuracaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.servidorToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem});
            this.configuracaoToolStripMenuItem.Name = "configuracaoToolStripMenuItem";
            this.configuracaoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuracaoToolStripMenuItem.Text = "Configuração";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosJFCToolStripMenuItem,
            this.produtosDasMatrizesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosJFCToolStripMenuItem
            // 
            this.produtosJFCToolStripMenuItem.Name = "produtosJFCToolStripMenuItem";
            this.produtosJFCToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.produtosJFCToolStripMenuItem.Text = "Produtos JFC";
            this.produtosJFCToolStripMenuItem.Click += new System.EventHandler(this.produtosJFCToolStripMenuItem_Click);
            // 
            // produtosDasMatrizesToolStripMenuItem
            // 
            this.produtosDasMatrizesToolStripMenuItem.Name = "produtosDasMatrizesToolStripMenuItem";
            this.produtosDasMatrizesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.produtosDasMatrizesToolStripMenuItem.Text = "Produtos das Matrizes";
            this.produtosDasMatrizesToolStripMenuItem.Click += new System.EventHandler(this.produtosDasMatrizesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarServidorToolStripMenuItem});
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.servidorToolStripMenuItem.Text = "Servidor";
            this.servidorToolStripMenuItem.Click += new System.EventHandler(this.servidorToolStripMenuItem_Click);
            // 
            // modificarServidorToolStripMenuItem
            // 
            this.modificarServidorToolStripMenuItem.Name = "modificarServidorToolStripMenuItem";
            this.modificarServidorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modificarServidorToolStripMenuItem.Text = "Modificar Servidor";
            this.modificarServidorToolStripMenuItem.Click += new System.EventHandler(this.modificarServidorToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 333);
            this.Controls.Add(this.TP_Conversor);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(763, 372);
            this.Name = "FormularioPrincipal";
            this.Text = "Form2";
            this.TP_Conversor.ResumeLayout(false);
            this.TB_Conversor.ResumeLayout(false);
            this.TB_Conversor.PerformLayout();
            this.TB_Erro.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TP_Conversor;
        private System.Windows.Forms.TabPage TB_Conversor;
        private System.Windows.Forms.TabPage TB_Erro;
        private System.Windows.Forms.TextBox TxbCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lb_ProdutosNota;
        private System.Windows.Forms.ListBox LB_ClienteNota;
        private System.Windows.Forms.Button BT_Selecionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbData;
        private System.Windows.Forms.ListBox LB_ErroProduto;
        private System.Windows.Forms.ListBox LB_ErroNotas;
        private System.Windows.Forms.Button BT_Importar;
        private System.Windows.Forms.Button BT_cadastrarErro;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem configuracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosJFCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosDasMatrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarServidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}