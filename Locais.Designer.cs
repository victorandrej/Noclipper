namespace NoClipper
{
    partial class Locais
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
            this.Bt_Caminhoxml = new System.Windows.Forms.Button();
            this.Tb_CaminhoXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Ok = new System.Windows.Forms.Button();
            this.Sd_caminhotxt = new System.Windows.Forms.SaveFileDialog();
            this.FB_CaminhoXml = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Bt_Caminhoxml
            // 
            this.Bt_Caminhoxml.Location = new System.Drawing.Point(240, 3);
            this.Bt_Caminhoxml.Name = "Bt_Caminhoxml";
            this.Bt_Caminhoxml.Size = new System.Drawing.Size(75, 23);
            this.Bt_Caminhoxml.TabIndex = 0;
            this.Bt_Caminhoxml.Text = "Selecionar";
            this.Bt_Caminhoxml.UseVisualStyleBackColor = true;
            this.Bt_Caminhoxml.Click += new System.EventHandler(this.Bt_Caminhoxml_Click);
            // 
            // Tb_CaminhoXml
            // 
            this.Tb_CaminhoXml.Location = new System.Drawing.Point(134, 6);
            this.Tb_CaminhoXml.Name = "Tb_CaminhoXml";
            this.Tb_CaminhoXml.ReadOnly = true;
            this.Tb_CaminhoXml.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Tb_CaminhoXml.Size = new System.Drawing.Size(100, 20);
            this.Tb_CaminhoXml.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho os xmls :";
            // 
            // Bt_Ok
            // 
            this.Bt_Ok.Location = new System.Drawing.Point(123, 32);
            this.Bt_Ok.Name = "Bt_Ok";
            this.Bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.Bt_Ok.TabIndex = 6;
            this.Bt_Ok.Text = "OK";
            this.Bt_Ok.UseVisualStyleBackColor = true;
            this.Bt_Ok.Click += new System.EventHandler(this.Bt_Ok_Click);
            // 
            // Locais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 59);
            this.Controls.Add(this.Bt_Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_CaminhoXml);
            this.Controls.Add(this.Bt_Caminhoxml);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 98);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(334, 98);
            this.Name = "Locais";
            this.Text = "Locais";
            this.Load += new System.EventHandler(this.Locais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Caminhoxml;
        private System.Windows.Forms.TextBox Tb_CaminhoXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Ok;
        private System.Windows.Forms.SaveFileDialog Sd_caminhotxt;
        private System.Windows.Forms.FolderBrowserDialog FB_CaminhoXml;
    }
}