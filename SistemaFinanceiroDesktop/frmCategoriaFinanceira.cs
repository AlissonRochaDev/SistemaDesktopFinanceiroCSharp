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
    public partial class frmCategoriaFinanceira : Form
    {
        public frmCategoriaFinanceira()
        {
            InitializeComponent();
        }

        // Precisamos de uma Variável Global para manipular o ID que sera Alterado ou Excluido!
        int idRegistro = 0;

        private void frmCategoriaFinanceira_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            Util.ConfigurarGrid(gridCategorias);
            ConsultarCategoria();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                CadastrarCategoria();
                LimparCampos();
                ConsultarCategoria();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AlterarCategoria();
                LimparCampos();
                ConsultarCategoria();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Util.MSG_EXCLUSAO, Util.TITULO_CONFIRMACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExcluirCategoria();
                LimparCampos();
                ConsultarCategoria();
            }
        }

        private void gridCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vamos verificar se existe linhas dentro da Consulta!
            if(gridCategorias.RowCount > 0)
            {
                tb_categoria objLinhaClicada = (tb_categoria)gridCategorias.CurrentRow.DataBoundItem;

                // Papular o Campo do Formulário!
                txtNomeCategoria.Text = objLinhaClicada.nome_categoria;
                idRegistro = objLinhaClicada.id_categoria;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (txtNomeCategoria.Text.Trim() == string.Empty)
            {
                flag = false;
                campos = "- Nome da Categoria Financeira";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private void LimparCampos()
        {
            txtNomeCategoria.Clear();
            txtNomeCategoria.Focus();
            idRegistro = 0;
        }

        private void CadastrarCategoria()
        {
            tb_categoria objCategoria = new tb_categoria();
            CategoriaDAO objDAO = new CategoriaDAO();

            try
            {
                objCategoria.nome_categoria = txtNomeCategoria.Text;
                objCategoria.id_usuario = Util.CodigoLogado;

                objDAO.CadastrarCategoriaDAO(objCategoria);

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                ConsultarCategoria();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarCategoria()
        {
            CategoriaDAO objDAO = new CategoriaDAO();
            List<tb_categoria> lstCategorias = objDAO.ConsultarCategoriaDAO(Util.CodigoLogado);

            gridCategorias.DataSource = lstCategorias;

            // Vamos esconder as colunas nativa do Banco de Dados, mantendo apenas as colunas necessárias!
            gridCategorias.Columns["id_categoria"].Visible = false;
            gridCategorias.Columns["id_usuario"].Visible = false;
            gridCategorias.Columns["tb_usuario"].Visible = false;
            gridCategorias.Columns["tb_movimento"].Visible = false;

            // Vamos configurar a Coluna que sera apresentada na Consulta!
            gridCategorias.Columns["nome_categoria"].HeaderText = "Nome da Categoria";
        }

        private void AlterarCategoria()
        {
            tb_categoria objCategoria = new tb_categoria();
            CategoriaDAO objDAO = new CategoriaDAO();

            try
            {
                objCategoria.id_categoria = idRegistro;
                objCategoria.nome_categoria = txtNomeCategoria.Text;
                objCategoria.id_usuario = Util.CodigoLogado;

                objDAO.AlterarCategoriaDAO(objCategoria);

                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                ConsultarCategoria();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirCategoria()
        {
            CategoriaDAO objDAO = new CategoriaDAO();

            try
            {
                objDAO.ExcluirCategoriaDAO(idRegistro);
                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
