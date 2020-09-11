namespace NoClipper
{
    partial class Exportar
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
            this.LB_notasParaExportar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LB_notasParaExportar
            // 
            this.LB_notasParaExportar.FormattingEnabled = true;
            this.LB_notasParaExportar.Location = new System.Drawing.Point(3, 0);
            this.LB_notasParaExportar.Name = "LB_notasParaExportar";
            this.LB_notasParaExportar.Size = new System.Drawing.Size(414, 173);
            this.LB_notasParaExportar.TabIndex = 0;
            // 
            // Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_notasParaExportar);
            this.Name = "Exportar";
            this.Text = "Exportar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_notasParaExportar;
    }
}