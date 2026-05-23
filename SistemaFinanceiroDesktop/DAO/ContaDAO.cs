using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ContaDAO
    {
        private readonly db_financeiro_sab_08 objBanco;

        public ContaDAO()
        {
            objBanco = new db_financeiro_sab_08();
        }

        public void CadastrarContaDAO(tb_conta objConta)
        {
            objBanco.tb_conta.Add(objConta);
            objBanco.SaveChanges();
        }

        public List<tb_conta> ConsultarContaDAO(int idLogado)
        {
            List<tb_conta> lstContas = objBanco.tb_conta.Where(conta => conta.id_usuario == idLogado).ToList();

            return lstContas;
        }

        public void AlterarContaDAO(tb_conta objConta)
        {
            tb_conta objUpdate = objBanco.tb_conta.Where(conta => conta.id_conta == objConta.id_conta).FirstOrDefault();

            objUpdate.banco_conta = objConta.banco_conta;
            objUpdate.agencia_conta = objConta.agencia_conta;
            objUpdate.numero_conta = objConta.numero_conta;
            objUpdate.saldo_conta = objConta.saldo_conta;

            objBanco.SaveChanges();
        }

        public void ExcluirContaDAO(int idRegistro)
        {
            tb_conta objDelete = objBanco.tb_conta.Where(conta => conta.id_conta == idRegistro).FirstOrDefault();

            objBanco.tb_conta.Remove(objDelete);

            objBanco.SaveChanges();
        }
    }
}
