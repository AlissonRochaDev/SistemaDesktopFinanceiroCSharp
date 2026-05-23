namespace SistemaFinanceiroDesktop
{
    partial class frmConsultarMovimento
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
            this.grpConsultar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoMov = new System.Windows.Forms.ComboBox();
            this.grpResultadoConsulta = new System.Windows.Forms.GroupBox();
            this.gridConsultarMovimento = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.grpConsultar.SuspendLayout();
            this.grpResultadoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultarMovimento)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultar
            // 
            this.grpConsultar.Controls.Add(this.btnPesquisar);
            this.grpConsultar.Controls.Add(this.label3);
            this.grpConsultar.Controls.Add(this.label1);
            this.grpConsultar.Controls.Add(this.label2);
            this.grpConsultar.Controls.Add(this.dtFinal);
            this.grpConsultar.Controls.Add(this.dtInicio);
            this.grpConsultar.Controls.Add(this.cmbTipoMov);
            this.grpConsultar.Location = new System.Drawing.Point(10, 12);
            this.grpConsultar.Name = "grpConsultar";
            this.grpConsultar.Size = new System.Drawing.Size(917, 130);
            this.grpConsultar.TabIndex = 7;
            this.grpConsultar.TabStop = false;
            this.grpConsultar.Text = "Filtrar Movimento Financeiro:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Navy;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(672, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(239, 40);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo do Movimento:";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(462, 66);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(147, 26);
            this.dtFinal.TabIndex = 3;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(240, 66);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(147, 26);
            this.dtInicio.TabIndex = 2;
            // 
            // cmbTipoMov
            // 
            this.cmbTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMov.FormattingEnabled = true;
            this.cmbTipoMov.Items.AddRange(new object[] {
            "Entrada",
            "Saída",
            "Todos"});
            this.cmbTipoMov.Location = new System.Drawing.Point(26, 68);
            this.cmbTipoMov.Name = "cmbTipoMov";
            this.cmbTipoMov.Size = new System.Drawing.Size(147, 28);
            this.cmbTipoMov.TabIndex = 1;
            // 
            // grpResultadoConsulta
            // 
            this.grpResultadoConsulta.Controls.Add(this.gridConsultarMovimento);
            this.grpResultadoConsulta.Location = new System.Drawing.Point(10, 148);
            this.grpResultadoConsulta.Name = "grpResultadoConsulta";
            this.grpResultadoConsulta.Size = new System.Drawing.Size(920, 232);
            this.grpResultadoConsulta.TabIndex = 6;
            this.grpResultadoConsulta.TabStop = false;
            this.grpResultadoConsulta.Text = "Consultar Movimentos Financeiros:";
            // 
            // gridConsultarMovimento
            // 
            this.gridConsultarMovimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultarMovimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultarMovimento.Location = new System.Drawing.Point(3, 22);
            this.gridConsultarMovimento.Name = "gridConsultarMovimento";
            this.gridConsultarMovimento.Size = new System.Drawing.Size(914, 207);
            this.gridConsultarMovimento.TabIndex = 5;
            this.gridConsultarMovimento.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultarMovimento_CellContentDoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(729, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.Location = new System.Drawing.Point(789, 403);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(49, 20);
            this.lblTotalValor.TabIndex = 8;
            this.lblTotalValor.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ATENÇÂO: Para EXCLUIR clique na linha 2x no registro desejado!";
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.BackColor = System.Drawing.Color.Green;
            this.btnGerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGerarPDF.Location = new System.Drawing.Point(591, 394);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(132, 39);
            this.btnGerarPDF.TabIndex = 10;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = false;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // frmConsultarMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 444);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpResultadoConsulta);
            this.Controls.Add(this.grpConsultar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultarMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Financeiro - Consultar Movimento Financeiro";
            this.Load += new System.EventHandler(this.frmConsultarMovimento_Load);
            this.grpConsultar.ResumeLayout(false);
            this.grpConsultar.PerformLayout();
            this.grpResultadoConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultarMovimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoMov;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox grpResultadoConsulta;
        private System.Windows.Forms.DataGridView gridConsultarMovimento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGerarPDF;
    }
}