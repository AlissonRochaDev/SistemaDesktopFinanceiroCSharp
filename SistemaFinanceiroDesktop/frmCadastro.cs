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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Segue com o processo...
                CadastrarUsuario();
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if (txtNome.Text.Trim() == string.Empty)
            {
                flag = false;
                campos = "\n- Nome";
            }

            if (txtEmail.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "\n- E-mail";
            }
            else if (!Util.IsValidEmail(txtEmail.Text.Trim()))
            {
                flag = false;
                campos += "\n- O E-MAIL esta incorreto!";
            }
            else if(!new UsuarioDAO().VerificarEmailDuplicado(txtEmail.Text.Trim()))
            {
                // ! - NEGAÇÃO.
                flag = false;
                campos += "\n- O E-MAIL já está Cadastrado!";
            }

            if (txtSenha.Text.Trim() == string.Empty)
            {
                flag = false;
                // campos = campos +  "\n- Senha";
                campos += "\n- Senha";
            }
            else if(txtSenha.Text.Trim().Length < 6 || txtSenha.Text.Trim().Length > 8)
            {
                flag = false;
                campos += "\n- A SENHA deverá conter entre 6 e 8 caracteres!";
            }
            else if(txtSenha.Text.Trim() != txtRepSenha.Text.Trim())
            {
                flag = false;
                campos += "\n- As SENHAS não são iguais!";
            }

            if (txtRepSenha.Text.Trim() == string.Empty)
            {
                flag = false;
                campos += "\n- Repetir Senha";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private void CadastrarUsuario()
        {
            // Vamos criar um Objeto para carregar todos os dados da Tabela Usuario.
            tb_usuario objUsuario = new tb_usuario();

            // Esse Objeto vai chamar todos os Métodos da Classe UsuarioDAO!
            UsuarioDAO objDAO = new UsuarioDAO();

            try
            {
                // Preencher os atributos do Objeto!
                objUsuario.nome_usuario = txtNome.Text;
                objUsuario.email_usuario = txtEmail.Text;
                objUsuario.senha_usuario = txtSenha.Text;
                objUsuario.data_cadastro = DateTime.Now;

                // Chamar o Método específico!
                objDAO.CadastrarUsuarioDAO(objUsuario);

                // Mensagem que vai ser apresentada para o Usuário na Tela, chamando as constantes da Classe Util!
                MessageBox.Show(Util.MSG_SUCESSO, Util.TITULO_SUCESSO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // A Tela principal é a Login, então após o Cadastro, a Tela se fecha e volta para o Login!
                this.Close();
            }
            catch
            {
                // Mensagem que vai ser apresentada para o Usuário na Tela, chamando as constantes da Classe Util!
                MessageBox.Show(Util.MSG_ERRO, Util.TITULO_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
