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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        int idRegistro = 0;

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            Util.ConfigurarGrid(gridEmpresas);
            ConsultarEmpresa();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                CadastrarEmpresa();
                LimparCampos();
                ConsultarEmpresa();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AlterarEmpresa();
                LimparCampos();
                ConsultarEmpresa();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Util.MSG_EXCLUSAO, Util.TITULO_CONFIRMACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExcluirEmpresa();
                LimparCampos();
                ConsultarEmpresa();
            }
        }

        private void gridEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridEmpresas.RowCount > 0)
            {
                tb_empresa objLinhaClicada = (tb_empresa)gridEmpresas.CurrentRow.DataBoundItem;

                txtNomeEmpresa.Text = objLinhaClicada.nome_empresa;
                txtTelefone.Text = objLinhaClicada.telefone_empresa;
                txtEndereco.Text = objLinhaClicada.endereco_empresa;

                idRegistro = objLinhaClicada.id_empresa;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if(txtNomeEmpresa.Text.Trim() == string.Empty)
            {
                flag = false;
                campos = "- Nome da Empresa";
            }

            if (txtTelefone.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "- Telefone";
            }

            if (txtEndereco.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "- Endereço";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private void LimparCampos()
        {
            txtNomeEmpresa.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtNomeEmpresa.Focus();
            idRegistro = 0;
        }

        private void CadastrarEmpresa()
        {
            tb_empresa objEmpresa = new tb_empresa();
            EmpresaDAO objDAO = new EmpresaDAO();

            try
            {
                objEmpresa.nome_empresa = txtNomeEmpresa.Text;
                objEmpresa.telefone_empresa = txtTelefone.Text;
                objEmpresa.endereco_empresa = txtEndereco.Text;
                objEmpresa.id_usuario = Util.CodigoLogado;

                objDAO.CadastrarEmpresaDAO(objEmpresa);

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                ConsultarEmpresa();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarEmpresa()
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            List<tb_empresa> lstEmpresas = objDAO.ConsultarEmpresaDAO(Util.CodigoLogado);

            gridEmpresas.DataSource = lstEmpresas;

            // Ocultar Colunas na DataGridView.
            gridEmpresas.Columns["id_empresa"].Visible = false;
            gridEmpresas.Columns["id_usuario"].Visible = false;
            gridEmpresas.Columns["tb_movimento"].Visible = false;
            gridEmpresas.Columns["tb_usuario"].Visible = false;

            // Alterar os Nomes das Colunas!
            gridEmpresas.Columns["nome_empresa"].HeaderText = "Nome da Empresa";
            gridEmpresas.Columns["telefone_empresa"].HeaderText = "Telefone";
            gridEmpresas.Columns["endereco_empresa"].HeaderText = "Endereço";
        }

        private void AlterarEmpresa()
        {
            tb_empresa objEmpresa = new tb_empresa();
            EmpresaDAO objDAO = new EmpresaDAO();

            try
            {
                objEmpresa.id_empresa = idRegistro;
                objEmpresa.nome_empresa = txtNomeEmpresa.Text;
                objEmpresa.telefone_empresa = txtTelefone.Text;
                objEmpresa.endereco_empresa = txtEndereco.Text;
                objEmpresa.id_usuario = Util.CodigoLogado;

                objDAO.AlterarEmpresaDAO(objEmpresa);

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                ConsultarEmpresa();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirEmpresa()
        {
            EmpresaDAO objDAO = new EmpresaDAO();

            try
            {
                objDAO.ExcluirEmpresaDAO(idRegistro);

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}