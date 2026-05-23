using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinanceiroDesktop
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeusDados frm = new frmMeusDados();
            frm.ShowDialog();
        }

        private void categoriaFinanceiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaFinanceira frm = new frmCategoriaFinanceira();
            frm.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.ShowDialog();
        }

        private void contaBancáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContaBancaria frm = new frmContaBancaria();
            frm.ShowDialog();
        }

        private void realizarMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRealizarMovimento frm = new frmRealizarMovimento();
            frm.ShowDialog();
        }

        private void consultarMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarMovimento frm = new frmConsultarMovimento();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
