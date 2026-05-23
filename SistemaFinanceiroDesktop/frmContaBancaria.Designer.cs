namespace SistemaFinanceiroDesktop
{
    partial class frmContaBancaria
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
            this.grpContaBancaria = new System.Windows.Forms.GroupBox();
            this.gridContasBancarias = new System.Windows.Forms.DataGridView();
            this.grpConta = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNumAgencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpContaBancaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContasBancarias)).BeginInit();
            this.grpConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpContaBancaria
            // 
            this.grpContaBancaria.Controls.Add(this.gridContasBancarias);
            this.grpContaBancaria.Location = new System.Drawing.Point(12, 266);
            this.grpContaBancaria.Name = "grpContaBancaria";
            this.grpContaBancaria.Size = new System.Drawing.Size(408, 273);
            this.grpContaBancaria.TabIndex = 11;
            this.grpContaBancaria.TabStop = false;
            this.grpContaBancaria.Text = "Consultar Contas Bancárias Cadastradas:";
            // 
            // gridContasBancarias
            // 
            this.gridContasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContasBancarias.Location = new System.Drawing.Point(0, 25);
            this.gridContasBancarias.Name = "gridContasBancarias";
            this.gridContasBancarias.Size = new System.Drawing.Size(408, 242);
            this.gridContasBancarias.TabIndex = 0;
            this.gridContasBancarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContasBancarias_CellContentClick_1);
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.btnExcluir);
            this.grpConta.Controls.Add(this.btnCancelar);
            this.grpConta.Controls.Add(this.btnAlterar);
            this.grpConta.Controls.Add(this.btnCadastrar);
            this.grpConta.Controls.Add(this.txtNumConta);
            this.grpConta.Controls.Add(this.txtSaldo);
            this.grpConta.Controls.Add(this.txtNumAgencia);
            this.grpConta.Controls.Add(this.label4);
            this.grpConta.Controls.Add(this.label3);
            this.grpConta.Controls.Add(this.txtNomeBanco);
            this.grpConta.Controls.Add(this.label1);
            this.grpConta.Controls.Add(this.label2);
            this.grpConta.Location = new System.Drawing.Point(12, 12);
            this.grpConta.Name = "grpConta";
            this.grpConta.Size = new System.Drawing.Size(408, 248);
            this.grpConta.TabIndex = 10;
            this.grpConta.TabStop = false;
            this.grpConta.Text = "Informações da Conta Bancária:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(11, 197);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 35);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Blue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(108, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(207, 197);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 35);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(306, 197);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(93, 35);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(229, 102);
            this.txtNumConta.MaxLength = 20;
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(170, 26);
            this.txtNumConta.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(11, 161);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(218, 26);
            this.txtSaldo.TabIndex = 4;
            // 
            // txtNumAgencia
            // 
            this.txtNumAgencia.Location = new System.Drawing.Point(11, 102);
            this.txtNumAgencia.MaxLength = 10;
            this.txtNumAgencia.Name = "txtNumAgencia";
            this.txtNumAgencia.Size = new System.Drawing.Size(135, 26);
            this.txtNumAgencia.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "N. da Conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saldo (R$):";
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(11, 49);
            this.txtNomeBanco.MaxLength = 10;
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(388, 26);
            this.txtNomeBanco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "N. Agência:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome do Banco:";
            // 
            // frmContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 551);
            this.Controls.Add(this.grpContaBancaria);
            this.Controls.Add(this.grpConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Financeiro - Gerenciar Conta Bancária";
            this.Load += new System.EventHandler(this.frmContaBancaria_Load);
            this.grpContaBancaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContasBancarias)).EndInit();
            this.grpConta.ResumeLayout(false);
            this.grpConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContaBancaria;
        private System.Windows.Forms.GroupBox grpConta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNumAgencia;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridContasBancarias;
    }
}