namespace SistemaFinanceiroDesktop
{
    partial class frmInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meusDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaFinanceiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaBancáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusDadosToolStripMenuItem,
            this.cadastrosDeDadosToolStripMenuItem,
            this.movimentoFinanceiroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meusDadosToolStripMenuItem
            // 
            this.meusDadosToolStripMenuItem.Name = "meusDadosToolStripMenuItem";
            this.meusDadosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.meusDadosToolStripMenuItem.Text = "Meus Dados";
            this.meusDadosToolStripMenuItem.Click += new System.EventHandler(this.meusDadosToolStripMenuItem_Click);
            // 
            // cadastrosDeDadosToolStripMenuItem
            // 
            this.cadastrosDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaFinanceiraToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.contaBancáriaToolStripMenuItem});
            this.cadastrosDeDadosToolStripMenuItem.Name = "cadastrosDeDadosToolStripMenuItem";
            this.cadastrosDeDadosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.cadastrosDeDadosToolStripMenuItem.Text = "Cadastros de Dados";
            // 
            // categoriaFinanceiraToolStripMenuItem
            // 
            this.categoriaFinanceiraToolStripMenuItem.Name = "categoriaFinanceiraToolStripMenuItem";
            this.categoriaFinanceiraToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.categoriaFinanceiraToolStripMenuItem.Text = "Categoria Financeira";
            this.categoriaFinanceiraToolStripMenuItem.Click += new System.EventHandler(this.categoriaFinanceiraToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // contaBancáriaToolStripMenuItem
            // 
            this.contaBancáriaToolStripMenuItem.Name = "contaBancáriaToolStripMenuItem";
            this.contaBancáriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contaBancáriaToolStripMenuItem.Text = "Conta Bancária";
            this.contaBancáriaToolStripMenuItem.Click += new System.EventHandler(this.contaBancáriaToolStripMenuItem_Click);
            // 
            // movimentoFinanceiroToolStripMenuItem
            // 
            this.movimentoFinanceiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarMovimentoToolStripMenuItem,
            this.consultarMovimentoToolStripMenuItem});
            this.movimentoFinanceiroToolStripMenuItem.Name = "movimentoFinanceiroToolStripMenuItem";
            this.movimentoFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.movimentoFinanceiroToolStripMenuItem.Text = "Movimento Financeiro";
            // 
            // realizarMovimentoToolStripMenuItem
            // 
            this.realizarMovimentoToolStripMenuItem.Name = "realizarMovimentoToolStripMenuItem";
            this.realizarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.realizarMovimentoToolStripMenuItem.Text = "Realizar Movimento";
            this.realizarMovimentoToolStripMenuItem.Click += new System.EventHandler(this.realizarMovimentoToolStripMenuItem_Click);
            // 
            // consultarMovimentoToolStripMenuItem
            // 
            this.consultarMovimentoToolStripMenuItem.Name = "consultarMovimentoToolStripMenuItem";
            this.consultarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultarMovimentoToolStripMenuItem.Text = "Consultar Movimento";
            this.consultarMovimentoToolStripMenuItem.Click += new System.EventHandler(this.consultarMovimentoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 448);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle Financeiro - Seja bem vindo(a)!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meusDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaFinanceiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaBancáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoFinanceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}