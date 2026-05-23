using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFinanceiroDesktop.ClassDAO;
using DAO;

namespace SistemaFinanceiroDesktop
{
    public partial class frmRealizarMovimento : Form
    {
        public frmRealizarMovimento()
        {
            InitializeComponent();
        }

        private void frmRealizarMovimento_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarEmpresa();
            CarregarConta();
            LimparCampos();
        }

        private void btnConfirmarMov_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RealizarMovimento();
                LimparCampos();
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (cmbTipoMov.SelectedIndex == -1)
            {
                flag = false;
                campos = "- Nome do Banco";
            }

            if (txtValor.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "- Valor (R$)";
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                flag = false;
                campos += "- Categoria Financeira";
            }

            if (cmbEmpresa.SelectedIndex == -1)
            {
                flag = false;
                campos += "- Empresa";
            }

            if (cmbConta.SelectedIndex == -1)
            {
                flag = false;
                campos += "- Conta Bancária";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private void LimparCampos()
        {
            dtMovimento.Value = DateTime.Now;
            cmbTipoMov.SelectedIndex = -1;
            txtValor.Clear();
            txtObservacao.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;
            cmbConta.SelectedIndex = -1;
            dtMovimento.Focus();
        }

        // Consulta os dados já cadastrados na Tabela Categoria!
        private void CarregarCategoria()
        {
            cmbCategoria.DisplayMember = "nome_categoria";
            cmbCategoria.ValueMember = "id_categoria";

            cmbCategoria.DataSource = new CategoriaDAO().ConsultarCategoriaDAO(Util.CodigoLogado);
        }

        // Consulta os dados já cadastrados na Tabela Empresa!
        private void CarregarEmpresa()
        {
            cmbEmpresa.DisplayMember = "nome_empresa";
            cmbEmpresa.ValueMember = "id_empresa";

            cmbEmpresa.DataSource = new EmpresaDAO().ConsultarEmpresaDAO(Util.CodigoLogado);
        }

        // Consulta os dados já cadastrados na Tabela Conta!
        private void CarregarConta()
        {
            List<tb_conta> lstContas = new ContaDAO().ConsultarContaDAO(Util.CodigoLogado);

            for(int i = 0; i < lstContas.Count; i++)
            {
                lstContas[i].banco_conta += "Número: " + lstContas[i].numero_conta + " / Agência: "
                                            + lstContas[i].agencia_conta + " - " + lstContas[i].numero_conta
                                            + " / Saldo (R$): " + lstContas[i].saldo_conta.ToString("C2");
            }

            cmbConta.DisplayMember = "banco_conta";
            cmbConta.ValueMember = "id_conta";

            cmbConta.DataSource = lstContas;
        }

        private void RealizarMovimento()
        {
            try
            {
                new MovimentoDAO().RealizarMovimentoDAO(new tb_movimento
                {
                    data_movimento = dtMovimento.Value.Date,
                    id_categoria = (int)cmbCategoria.SelectedValue,
                    id_empresa = (int)cmbEmpresa.SelectedValue,
                    id_conta = (int)cmbConta.SelectedValue,
                    id_usuario = Util.CodigoLogado,
                    obs_movimento = txtObservacao.Text,
                    tipo_movimento = (short)cmbTipoMov.SelectedIndex,
                    valor_movimento = Convert.ToDecimal(txtValor.Text)
                });

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarConta();
                LimparCampos();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
