using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinanceiroDesktop.ClassDAO
{
    public static class Util
    {
        public const string MSG_USUARIO_NAO_ENCONTRADO = "Usuário não foi encontrado!";

        public const string MSG_OBRIGATORIO = "Revise o(s) campo(s): ";
        public const string TITULO_ATENCAO = "Atenção";

        public const string MSG_SUCESSO = "Ação realizada com sucesso!";
        public const string TITULO_SUCESSO = "Sucesso";

        public const string MSG_EXCLUSAO = "Deseja EXCLUIR esse Registro?";
        public const string TITULO_CONFIRMACAO = "";

        public const string MSG_ERRO = "Houve uma falha na operação, tente novamente mais tarde!";
        public const string TITULO_ERRO = "Erro";

        public const string MSG_NAO_ENCONTRADO = "Não foi encontrado nenhum REGISTRO!";
        public const string TITULO_PESQUISA = "Resultado";

        public const string MSG_ERRO_EXCLUIR = "Não foi possível excluir o REGISTRO< pois o mesmo está em uso!";

        // Essa linha de comando vai simular o acesso do Usuário de ID1 do Banco de Dados!
        // public const int CodigoLogado = 1;
        public static int CodigoLogado;

        public enum EstadoTela
        {
            Novo,
            Edicao
        }

        // Método para configurar o GridDataView dos Formulário do Sistema!
        public static void ConfigurarGrid(DataGridView grd)
        {
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd.ReadOnly = true;
            grd.MultiSelect = false;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            } 

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static void ConfigurarEstadoTela(EstadoTela estado, Button btnCadastrar, Button btnAlterar, Button btnExcluir)
        {
            switch (estado)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;

                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
            }
        }
    }
}
