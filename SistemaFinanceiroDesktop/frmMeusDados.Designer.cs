namespace SistemaFinanceiroDesktop
{
    partial class frmMeusDados
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
            this.grpEditDados = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEditSenha = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSenhaSalvar = new System.Windows.Forms.Button();
            this.txtRepSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpEditDados.SuspendLayout();
            this.grpEditSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditDados
            // 
            this.grpEditDados.Controls.Add(this.btnSalvar);
            this.grpEditDados.Controls.Add(this.txtEmail);
            this.grpEditDados.Controls.Add(this.label1);
            this.grpEditDados.Controls.Add(this.txtNome);
            this.grpEditDados.Controls.Add(this.label2);
            this.grpEditDados.Location = new System.Drawing.Point(14, 9);
            this.grpEditDados.Name = "grpEditDados";
            this.grpEditDados.Size = new System.Drawing.Size(305, 207);
            this.grpEditDados.TabIndex = 9;
            this.grpEditDados.TabStop = false;
            this.grpEditDados.Text = "Edite seus Dados:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(189, 148);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 43);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 107);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 48);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // grpEditSenha
            // 
            this.grpEditSenha.Controls.Add(this.btnVerificar);
            this.grpEditSenha.Controls.Add(this.btnSenhaSalvar);
            this.grpEditSenha.Controls.Add(this.txtRepSenha);
            this.grpEditSenha.Controls.Add(this.label5);
            this.grpEditSenha.Controls.Add(this.txtSenhaNova);
            this.grpEditSenha.Controls.Add(this.label4);
            this.grpEditSenha.Controls.Add(this.txtSenhaAtual);
            this.grpEditSenha.Controls.Add(this.label3);
            this.grpEditSenha.Location = new System.Drawing.Point(14, 222);
            this.grpEditSenha.Name = "grpEditSenha";
            this.grpEditSenha.Size = new System.Drawing.Size(305, 224);
            this.grpEditSenha.TabIndex = 10;
            this.grpEditSenha.TabStop = false;
            this.grpEditSenha.Text = "Altere sua Senha:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(189, 46);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(99, 34);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSenhaSalvar
            // 
            this.btnSenhaSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSenhaSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSenhaSalvar.Location = new System.Drawing.Point(189, 175);
            this.btnSenhaSalvar.Name = "btnSenhaSalvar";
            this.btnSenhaSalvar.Size = new System.Drawing.Size(99, 34);
            this.btnSenhaSalvar.TabIndex = 8;
            this.btnSenhaSalvar.Text = "Salvar";
            this.btnSenhaSalvar.UseVisualStyleBackColor = false;
            this.btnSenhaSalvar.Click += new System.EventHandler(this.btnSenhaSalvar_Click);
            // 
            // txtRepSenha
            // 
            this.txtRepSenha.Location = new System.Drawing.Point(14, 179);
            this.txtRepSenha.MaxLength = 8;
            this.txtRepSenha.Name = "txtRepSenha";
            this.txtRepSenha.Size = new System.Drawing.Size(134, 26);
            this.txtRepSenha.TabIndex = 7;
            this.txtRepSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Repetir Senha:";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(14, 113);
            this.txtSenhaNova.MaxLength = 8;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(134, 26);
            this.txtSenhaNova.TabIndex = 6;
            this.txtSenhaNova.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nova Senha:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(14, 50);
            this.txtSenhaAtual.MaxLength = 8;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(134, 26);
            this.txtSenhaAtual.TabIndex = 4;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha Atual:";
            // 
            // frmMeusDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 452);
            this.Controls.Add(this.grpEditSenha);
            this.Controls.Add(this.grpEditDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeusDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Financeiro - Meus Dados";
            this.Load += new System.EventHandler(this.frmMeusDados_Load);
            this.grpEditDados.ResumeLayout(false);
            this.grpEditDados.PerformLayout();
            this.grpEditSenha.ResumeLayout(false);
            this.grpEditSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditDados;
        private System.Windows.Forms.GroupBox grpEditSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRepSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSenhaSalvar;
    }
}