using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {
        public tb_usuario ValidarLoginDAO(string email, string senha)
        {
            tb_usuario objUser = new db_financeiro_sab_08().tb_usuario.Where(user => user.senha_usuario == senha && user.email_usuario == email).FirstOrDefault();

            return objUser;
        }

        public void CadastrarUsuarioDAO(tb_usuario objUsuario)
        {
            // 1º Passo: Esse Objeto vai carregar todos os recursos do Banco de Dados!
            db_financeiro_sab_08 objBanco = new db_financeiro_sab_08();

            // 2º Passo: Esse comando vai adicionar todos os recursos da Tabela que sera utilizada!
            objBanco.tb_usuario.Add(objUsuario);

            // 3º Passo: Salvar os dados identificados!
            objBanco.SaveChanges();
        }

        // Validação de E-mail duplicado da Tela Cadastro!
        public bool VerificarEmailDuplicado(string email)
        {
            db_financeiro_sab_08 objBanco = new db_financeiro_sab_08();

            int contar = objBanco.tb_usuario.Where(user => user.email_usuario == email).Count();

            // Ternário para verificar o que enviar para a Tela!
            // ? = ENTÃO.
            // : CASO CONTRÁRIO.
            return contar > 0 ? false : true;
        }

        // Sobre carga de Método para Trafegar os dados diferentes de acordo a camada, não importa se o nome é o mesmo!
        // Validação de E-mail duplicado da Tela Meus Dados!
        public bool VerificarEmailDuplicado(string email, int idLogado)
        {
            db_financeiro_sab_08 objBanco = new db_financeiro_sab_08();

            int contar = objBanco.tb_usuario.Where(user => user.email_usuario == email && user.id_usuario != idLogado).Count();

            return contar > 0 ? false : true;
        }

        // Ações de Ajustes da Tela Meus Dados, alteração dos dados cadastrados pelo Usuário!
        public void AlterarMeusDados(tb_usuario objUsuario)
        {
            db_financeiro_sab_08 objBanco = new db_financeiro_sab_08();

            // Resgata o registro dos dados do Usuário!
            tb_usuario objUpdate = objBanco.tb_usuario.Where(user => user.id_usuario == objUsuario.id_usuario).FirstOrDefault();

            // Atualiza os dados do Usuário!
            objUpdate.nome_usuario = objUsuario.nome_usuario;
            objUpdate.email_usuario = objUsuario.email_usuario;

            // Salvando os novos registros na Tabela do Banco de Dados!
            objBanco.SaveChanges();
        }

        // Consulta os dados do Usuário para carregar na Tela!
        public tb_usuario CarregarMeusDados(int idLogado)
        {
            db_financeiro_sab_08 objBanco = new db_financeiro_sab_08();

            tb_usuario objUsuario = objBanco.tb_usuario.Where(user => user.id_usuario == idLogado).FirstOrDefault();

            return objUsuario;
        }

        // Alteração de Senha do Usuário!
        public void AlterarSenha(tb_usuario objUsuario)
        {
            db_financeiro_sab_08 objBanco = new db_financeiro_sab_08();

            tb_usuario objUpdate = objBanco.tb_usuario.Where(user => user.id_usuario == objUsuario.id_usuario).FirstOrDefault();

            objUpdate.senha_usuario = objUsuario.senha_usuario;

            objBanco.SaveChanges();
        }
    }
}