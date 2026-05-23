using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.VO;
using DAO;
using SistemaFinanceiroDesktop.ClassDAO;
using Microsoft.Reporting.WinForms;

namespace SistemaFinanceiroDesktop
{
    public partial class frmRelatorioMovimento : Form
    {
        DateTime dtInicial, dtFInal;
        int tipo;

        public frmRelatorioMovimento(int pTipo, DateTime pDataInicial, DateTime pDataFinal)
        {
            tipo = pTipo;
            dtInicial = pDataInicial;
            dtFInal = pDataFinal;

            InitializeComponent();
        }

        private void frmRelatorioMovimento_Load(object sender, EventArgs e)
        {

            // this.reportViewerMovimento.RefreshReport();
            CarregarDados();
        }

        private void CarregarDados()
        {
            string caminhoRDLC = "RDLC/Movimento.rdlc";

            List<MovimentoVO> lstConsulta = new MovimentoDAO().FiltrarMovimentoDAO(Util.CodigoLogado, tipo, dtInicial, dtFInal).ToList();

            // Limpar os dados anteriores da Tabela do ReportView!
            reportViewerMovimento.LocalReport.DataSources.Clear();

            // Adicionar uma nova Lista ao meu ReportView no Movimento!
            ReportDataSource rds = new ReportDataSource("DataSetMovimento", lstConsulta);

            // Passamos a Lista!
            reportViewerMovimento.LocalReport.DataSources.Add(rds);

            // Apontamos qual o Arquivo que esta configurado!
            reportViewerMovimento.LocalReport.ReportPath = caminhoRDLC;

            // Titulo Dinâmico para o Relatório!
            string titulo = $"Movimentos realizados entre {dtInicial.ToShortDateString()} até {dtFInal.ToShortDateString()}";

            List<ReportParameter> parametros = new List<ReportParameter>();

            parametros.Add(new ReportParameter("Titulo", titulo));

            reportViewerMovimento.LocalReport.SetParameters(parametros);

            reportViewerMovimento.RefreshReport();
        }
    }
}
