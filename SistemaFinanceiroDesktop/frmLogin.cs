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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarCampos())
                {
                    tb_usuario objUser = new UsuarioDAO().ValidarLoginDAO(txtEmail.Text, txtSenha.Text);

                    if(objUser == null)
                    {
                        MessageBox.Show(Util.MSG_USUARIO_NAO_ENCONTRADO, Util.TITULO_PESQUISA, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Util.CodigoLogado = objUser.id_usuario;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frm = new frmCadastro();
            frm.ShowDialog();
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            string campos = string.Empty;

            if(txtEmail.Text.Trim() == string.Empty)
            {
                flag = false;
                campos = "\n- E-mail";
            }

            if (txtSenha.Text.Trim() == string.Empty)
            {
                flag = false;
                // campos = campos +  "\n- Senha";
                campos += "\n- Senha";
            }

            if (!flag)
            {
                MessageBox.Show(Util.MSG_OBRIGATORIO + campos, Util.TITULO_ATENCAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }
    }
}
