using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using SistemaFinanceiroDesktop.ClassDAO;

namespace SistemaFinanceiroDesktop
{
    public partial class frmContaBancaria : Form
    {
        public frmContaBancaria()
        {
            InitializeComponent();
        }

        int idRegistro = 0;

        private void frmContaBancaria_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            Util.ConfigurarGrid(gridContasBancarias);
            ConsultarConta();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                CadastrarConta();
                LimparCampos();
                ConsultarConta();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AlterarConta();
                LimparCampos();
                ConsultarConta();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Util.MSG_EXCLUSAO, Util.TITULO_CONFIRMACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExcluirConta();
                LimparCampos();
                ConsultarConta();
            }
        }

        private void gridContasBancarias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gridContasBancarias.RowCount > 0)
            {
                tb_conta objLinhaClicada = (tb_conta)gridContasBancarias.CurrentRow.DataBoundItem;

                txtNomeBanco.Text = objLinhaClicada.banco_conta;
                txtNumAgencia.Text = objLinhaClicada.agencia_conta;
                txtNumConta.Text = objLinhaClicada.numero_conta;
                txtSaldo.Text = objLinhaClicada.saldo_conta.ToString();

                idRegistro = objLinhaClicada.id_conta;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (txtNomeBanco.Text.Trim() == string.Empty)
            {
                flag = false;
                campos = "- Nome do Banco";
            }

            if (txtNumAgencia.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "- Numéro da Agência";
            }

            if (txtNumConta.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "- Numéro da Conta";
            }

            if (txtSaldo.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "- Saldo (R$)";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private void LimparCampos()
        {
            txtNomeBanco.Clear();
            txtNumAgencia.Clear();
            txtNumConta.Clear();
            txtSaldo.Clear();
            txtNomeBanco.Focus();
            idRegistro = 0;
        }

        private void CadastrarConta()
        {
            try
            {
                new ContaDAO().CadastrarContaDAO(new tb_conta
                {
                    banco_conta = txtNomeBanco.Text,
                    agencia_conta = txtNumAgencia.Text,
                    numero_conta = txtNumConta.Text,
                    saldo_conta = Convert.ToDecimal(txtSaldo.Text),
                    id_usuario = Util.CodigoLogado
                });

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                ConsultarConta();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarConta()
        {
            gridContasBancarias.DataSource = new ContaDAO().ConsultarContaDAO(Util.CodigoLogado);

            // Ocultar Colunas na DataGridView.
            gridContasBancarias.Columns["id_conta"].Visible = false;
            gridContasBancarias.Columns["id_usuario"].Visible = false;
            gridContasBancarias.Columns["tb_usuario"].Visible = false;
            gridContasBancarias.Columns["tb_movimento"].Visible = false;

            // Alterar os Nomes das Colunas!
            gridContasBancarias.Columns["banco_conta"].HeaderText = "Nome do Banco";
            gridContasBancarias.Columns["agencia_conta"].HeaderText = "Agência";
            gridContasBancarias.Columns["numero_conta"].HeaderText = "N. Conta";
            gridContasBancarias.Columns["saldo_conta"].HeaderText = "Saldo";
        }

        private void AlterarConta()
        {
            try
            {
                new ContaDAO().AlterarContaDAO(new tb_conta
                {
                    banco_conta = txtNomeBanco.Text,
                    agencia_conta = txtNumAgencia.Text,
                    numero_conta = txtNumConta.Text,
                    saldo_conta = Convert.ToDecimal(txtSaldo.Text),
                    id_usuario = Util.CodigoLogado,
                    id_conta = idRegistro
                });

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LimparCampos();
                ConsultarConta();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirConta()
        {
            try
            {
                new ContaDAO().ExcluirContaDAO(idRegistro);

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}