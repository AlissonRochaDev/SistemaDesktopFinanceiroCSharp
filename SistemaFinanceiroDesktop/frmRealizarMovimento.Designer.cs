namespace SistemaFinanceiroDesktop
{
    partial class frmRealizarMovimento
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
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoMov = new System.Windows.Forms.ComboBox();
            this.grpMovimento = new System.Windows.Forms.GroupBox();
            this.btnConfirmarMov = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConta = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.grpMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMovimento
            // 
            this.dtMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(192, 64);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(147, 24);
            this.dtMovimento.TabIndex = 1;
            // 
            // cmbTipoMov
            // 
            this.cmbTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMov.FormattingEnabled = true;
            this.cmbTipoMov.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cmbTipoMov.Location = new System.Drawing.Point(24, 62);
            this.cmbTipoMov.Name = "cmbTipoMov";
            this.cmbTipoMov.Size = new System.Drawing.Size(147, 26);
            this.cmbTipoMov.TabIndex = 2;
            // 
            // grpMovimento
            // 
            this.grpMovimento.Controls.Add(this.btnConfirmarMov);
            this.grpMovimento.Controls.Add(this.txtObservacao);
            this.grpMovimento.Controls.Add(this.label7);
            this.grpMovimento.Controls.Add(this.txtValor);
            this.grpMovimento.Controls.Add(this.label3);
            this.grpMovimento.Controls.Add(this.label6);
            this.grpMovimento.Controls.Add(this.label5);
            this.grpMovimento.Controls.Add(this.label4);
            this.grpMovimento.Controls.Add(this.label2);
            this.grpMovimento.Controls.Add(this.label1);
            this.grpMovimento.Controls.Add(this.cmbConta);
            this.grpMovimento.Controls.Add(this.cmbEmpresa);
            this.grpMovimento.Controls.Add(this.cmbCategoria);
            this.grpMovimento.Controls.Add(this.cmbTipoMov);
            this.grpMovimento.Controls.Add(this.dtMovimento);
            this.grpMovimento.Location = new System.Drawing.Point(11, 12);
            this.grpMovimento.Name = "grpMovimento";
            this.grpMovimento.Size = new System.Drawing.Size(536, 423);
            this.grpMovimento.TabIndex = 9;
            this.grpMovimento.TabStop = false;
            this.grpMovimento.Text = "Realize sua Movimentação Financeira:";
            // 
            // btnConfirmarMov
            // 
            this.btnConfirmarMov.BackColor = System.Drawing.Color.Navy;
            this.btnConfirmarMov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarMov.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarMov.Location = new System.Drawing.Point(299, 365);
            this.btnConfirmarMov.Name = "btnConfirmarMov";
            this.btnConfirmarMov.Size = new System.Drawing.Size(212, 52);
            this.btnConfirmarMov.TabIndex = 8;
            this.btnConfirmarMov.Text = "Realizar Movimento";
            this.btnConfirmarMov.UseVisualStyleBackColor = false;
            this.btnConfirmarMov.Click += new System.EventHandler(this.btnConfirmarMov_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(24, 268);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(488, 91);
            this.txtObservacao.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Observação (Opcional):";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(366, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(146, 24);
            this.txtValor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor (R$):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Empresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo do Movimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data do Movimento:";
            // 
            // cmbConta
            // 
            this.cmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConta.FormattingEnabled = true;
            this.cmbConta.Location = new System.Drawing.Point(24, 199);
            this.cmbConta.Name = "cmbConta";
            this.cmbConta.Size = new System.Drawing.Size(487, 26);
            this.cmbConta.TabIndex = 6;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(292, 128);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(220, 26);
            this.cmbEmpresa.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(24, 128);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(221, 26);
            this.cmbCategoria.TabIndex = 4;
            // 
            // frmRealizarMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 438);
            this.Controls.Add(this.grpMovimento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRealizarMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Financeiro - Realizar Movimento Financeiro";
            this.Load += new System.EventHandler(this.frmRealizarMovimento_Load);
            this.grpMovimento.ResumeLayout(false);
            this.grpMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMovimento;
        private System.Windows.Forms.ComboBox cmbTipoMov;
        private System.Windows.Forms.GroupBox grpMovimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbConta;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmarMov;
    }
}