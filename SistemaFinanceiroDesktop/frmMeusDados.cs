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
    public partial class frmMeusDados : Form
    {
        public frmMeusDados()
        {
            InitializeComponent();
        }

        // Loading do Formulário!
        private void frmMeusDados_Load(object sender, EventArgs e)
        {
            LiberarCamposSenha(GrupoInformacao.VerificarSenha);
            CarregarMeusDados();
        }

        // Para carregar a Senha Atual, jogar os dados nessa Variável!
        string senhaAtual = string.Empty;

        private enum GrupoInformacao
        {
            Edicao,
            MudarSenha,
            VerificarSenha
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(GrupoInformacao.Edicao))
            {
                AlterarMeusDados();
            }
        }

        private void btnSenhaSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(GrupoInformacao.MudarSenha))
            {
                AlterarSenha();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(GrupoInformacao.VerificarSenha))
            {

            }
        }

        private void LiberarCamposSenha(GrupoInformacao grupo)
        {
            switch (grupo)
            {
                case GrupoInformacao.VerificarSenha:
                    txtSenhaAtual.Enabled = true;
                    txtSenhaNova.Enabled = false;
                    txtRepSenha.Enabled = false;

                    btnVerificar.Enabled = true;
                    btnSenhaSalvar.Enabled = false;
                    break;

                case GrupoInformacao.MudarSenha:
                    txtSenhaAtual.Enabled = false;
                    txtSenhaNova.Enabled = true;
                    txtRepSenha.Enabled = true;

                    btnVerificar.Enabled = false;
                    btnSenhaSalvar.Enabled = true;
                    break;
            }
        }

        private bool ValidarCampos(GrupoInformacao grupo)
        {
            bool flag = true;
            string campos = string.Empty;

            switch (grupo)
            {
                case GrupoInformacao.Edicao:
                    if(txtNome.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        campos = "\n- Nome";
                    }

                    if(txtEmail.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        campos += "\n- E-mail";
                    }
                    else if (!Util.IsValidEmail(txtEmail.Text.Trim()))
                    {
                        flag = false;
                        campos += "\n- O E-MAIL esta incorreto!";
                    }
                    else if(!new UsuarioDAO().VerificarEmailDuplicado(txtEmail.Text.Trim(), Util.CodigoLogado))
                    {
                        flag = false;
                        campos += "\n- O E-MAIL já está cadastrado!";
                    }
                    break;

                case GrupoInformacao.VerificarSenha:
                    if(txtSenhaAtual.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        campos = "\n- Senha Atual";
                    }
                    else if(txtSenhaAtual.Text.Trim() != senhaAtual)
                    {
                        flag = false;
                        campos = "\n- Senha Atual está incorreta!";
                    }
                    else
                    {
                        LiberarCamposSenha(GrupoInformacao.MudarSenha);
                    }
                    break;

                case GrupoInformacao.MudarSenha:
                    if (txtSenhaNova.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        campos = "\n- Senha";
                    }
                    else if (txtSenhaNova.Text.Trim().Length < 6 || txtSenhaNova.Text.Trim().Length > 8)
                    {
                        flag = false;
                        campos = "\n- A SENHA deverá conter entre 6 e 8 caracteres!";
                    }
                    else if (txtSenhaNova.Text.Trim() != txtRepSenha.Text.Trim())
                    {
                        flag = false;
                        campos = "\n- As SENHAS não são iguais!";
                    }
                    break;
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        // Limpa os Capmos das Senhas após a utilização!
        private void LimparCampos()
        {
            txtSenhaNova.Clear();
            txtRepSenha.Clear();
            txtSenhaAtual.Clear();
        }

        // Carregar os dados do Usuário no Formulário!
        private void CarregarMeusDados()
        {
            UsuarioDAO objDAO = new UsuarioDAO();

            tb_usuario objUsuario = objDAO.CarregarMeusDados(Util.CodigoLogado);

            txtNome.Text = objUsuario.nome_usuario;
            txtEmail.Text = objUsuario.email_usuario;

            // Carregar a Senha no Load do Formulário!
            senhaAtual = objUsuario.senha_usuario;
        }

        // Alterar os dados cadastrados do Usuário!
        private void AlterarMeusDados()
        {
            UsuarioDAO objDAO = new UsuarioDAO();
            tb_usuario objUsuario = new tb_usuario();

            try
            {
                objUsuario.nome_usuario = txtNome.Text;
                objUsuario.email_usuario = txtEmail.Text;
                objUsuario.id_usuario = Util.CodigoLogado;

                objDAO.AlterarMeusDados(objUsuario);
                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Alterar a Senha do Usuário!
        private void AlterarSenha()
        {
            UsuarioDAO objDAO = new UsuarioDAO();
            tb_usuario objUsuario = new tb_usuario();

            try
            {
                objUsuario.senha_usuario = txtSenhaNova.Text;
                objUsuario.id_usuario = Util.CodigoLogado;

                objDAO.AlterarSenha(objUsuario);
                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chamar novamente a gestão de campos no Formulário!
                LiberarCamposSenha(GrupoInformacao.VerificarSenha);

                // Passar a Nova Senha para a Variável Global!
                senhaAtual = txtSenhaNova.Text;

                // Limpa todos os campos utilizados para a redefinição de Senha!
                LimparCampos();
            }
            catch
            {
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
