namespace SistemaFinanceiroDesktop
{
    partial class frmRelatorioMovimento
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
            this.reportViewerMovimento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerMovimento
            // 
            this.reportViewerMovimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerMovimento.LocalReport.ReportEmbeddedResource = "SistemaFinanceiroDesktop.RDLC.Movimento.rdlc";
            this.reportViewerMovimento.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMovimento.Name = "reportViewerMovimento";
            this.reportViewerMovimento.ServerReport.BearerToken = null;
            this.reportViewerMovimento.Size = new System.Drawing.Size(800, 450);
            this.reportViewerMovimento.TabIndex = 0;
            // 
            // frmRelatorioMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerMovimento);
            this.Name = "frmRelatorioMovimento";
            this.Text = "Relatório de Movimentações Financeiras";
            this.Load += new System.EventHandler(this.frmRelatorioMovimento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMovimento;
    }
}