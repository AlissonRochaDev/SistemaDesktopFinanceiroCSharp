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
using DAO.VO;

namespace SistemaFinanceiroDesktop
{
    public partial class frmConsultarMovimento : Form
    {
        public frmConsultarMovimento()
        {
            InitializeComponent();
        }

        private void frmConsultarMovimento_Load(object sender, EventArgs e)
        {
            cmbTipoMov.SelectedIndex = 0;
            Util.ConfigurarGrid(gridConsultarMovimento);
            MostrarLabelsTotal(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                FiltrarMovimento();
                // LimparCampos();
            }
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            new frmRelatorioMovimento(cmbTipoMov.SelectedIndex, dtInicio.Value.Date, dtFinal.Value.Date).ShowDialog();
        }

        private void gridConsultarMovimento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show(Util.MSG_EXCLUSAO, Util.TITULO_CONFIRMACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                MovimentoVO objLinhaClicada = (MovimentoVO)gridConsultarMovimento.CurrentRow.DataBoundItem;

                ExcluirMovimento(objLinhaClicada.Id);
                FiltrarMovimento();
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (cmbTipoMov.SelectedIndex == -1)
            {
                flag = false;
                campos = "- Tipo do Movimento";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private void LimparCampos()
        {
            cmbTipoMov.SelectedIndex = -1;
            dtInicio.Value = DateTime.Now;
            dtFinal.Value = DateTime.Now;
        }

        private void FiltrarMovimento()
        {
            List<MovimentoVO> lstResultado = new MovimentoDAO().FiltrarMovimentoDAO(
                                                Util.CodigoLogado,
                                                cmbTipoMov.SelectedIndex,
                                                dtInicio.Value.Date,
                                                dtFinal.Value.Date);

            if(lstResultado.Count > 0)
            {
                gridConsultarMovimento.DataSource = lstResultado;
                gridConsultarMovimento.Columns["Id"].Visible = false;

                decimal total = 0;

                for(int i = 0; i < lstResultado.Count; i++)
                {
                    if (lstResultado[i].Tipo == "Entrada")
                    {
                        total += lstResultado[i].Valor;
                    }
                    else
                    {
                        total -= lstResultado[i].Valor;
                    }
                }

                MostrarLabelsTotal(true);
                MostrarTotal(total);
            }
            else
            {
                gridConsultarMovimento.DataSource = null;
                MostrarLabelsTotal(false);
                MessageBox.Show(Util.MSG_NAO_ENCONTRADO, Util.TITULO_PESQUISA, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExcluirMovimento(int idMovimento)
        {
            try
            {
                new MovimentoDAO().ExcluirMovimentoDAO(idMovimento);
                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTotal(decimal total)
        {
            if(total < 0)
            {
                lblTotalValor.ForeColor = Color.Red;
            }
            else
            {
                lblTotalValor.ForeColor = Color.DarkGreen;
            }

            // Lembrando: C2 para formatação de valor monetário! (Real)!
            lblTotalValor.Text = total.ToString("C2");
        }

        private void MostrarLabelsTotal(bool mostrar)
        {
            if (mostrar)
            {
                lblTotal.Visible = true;
                lblTotalValor.Visible = true;
                btnGerarPDF.Visible = true;
            }
            else
            {
                lblTotal.Visible = false;
                lblTotalValor.Visible = false;
                btnGerarPDF.Visible = false;
            }
        }
    }
}
