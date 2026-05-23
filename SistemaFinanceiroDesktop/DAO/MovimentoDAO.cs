using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAO.VO;

namespace DAO
{
    public class MovimentoDAO
    {

        private readonly db_financeiro_sab_08 objBanco;

        public MovimentoDAO()
        {
            objBanco = new db_financeiro_sab_08();
        }

        public void RealizarMovimentoDAO(tb_movimento objMovimeto)
        {
            using (TransactionScope tran = new TransactionScope())
            {
                // Insere os dados na Tabela Movimento do Banco de Dados!
                objBanco.tb_movimento.Add(objMovimeto);
                objBanco.SaveChanges();

                // Resgata os dados do Objeto Conta para atualizar a Tabela Conta!
                tb_conta objContaUpdate = objBanco.tb_conta.Where(conta => conta.id_conta == objMovimeto.id_conta).FirstOrDefault();

                // Verifica o Tipo do Movimento e determina de retira ou adiciona valores!
                // 0 - Entrada de Dinheiro!
                // 1 - Saída de Dinheiro!
                if(objMovimeto.tipo_movimento == 0)
                {
                    objContaUpdate.saldo_conta = objContaUpdate.saldo_conta + objMovimeto.valor_movimento;
                }
                else if(objMovimeto.tipo_movimento == 1)
                {
                    objContaUpdate.saldo_conta = objContaUpdate.saldo_conta - objMovimeto.valor_movimento;
                }

                // Atualiza o Saldo da Conta que foi passado o Valor do Movimento!
                objBanco.SaveChanges();

                // Confirma a realização da Transação Bancária!
                tran.Complete();
            }
        }

        
        public List<MovimentoVO> FiltrarMovimentoDAO(int idLogado, int tipo, DateTime dataInicial, DateTime dataFinal)
        {
            // Listagem que guardara a Consulta realizada!
            List<tb_movimento> lstConsultas = new List<tb_movimento>();

            // Lista o retorno da Consulta!
            List<MovimentoVO> lstRetorno = new List<MovimentoVO>();

            // Entrada = 0 Posição!
            // Saída = 1 Posição!
            // Todos = 2 Posição!
            if (tipo != 2)
            {
                // Consulta realizada no Banco de Dados de acordo o que foi selecionado (0 ou 1)!
                lstConsultas = objBanco.tb_movimento.Include("tb_categoria").Include("tb_empresa").Include("tb_conta")
                                                .Where(
                                                        mov => mov.id_usuario == idLogado &&
                                                                mov.data_movimento >= dataInicial &&
                                                                mov.data_movimento <= dataFinal &&
                                                                mov.tipo_movimento == tipo
                                                ).ToList();
            }
            else
            {
                // Consulta realizada no Banco de Dados de acordo o que foi selecionado (0 ou 1)!
                lstConsultas = objBanco.tb_movimento.Include("tb_categoria").Include("tb_empresa").Include("tb_conta")
                                                .Where(
                                                        mov => mov.id_usuario == idLogado &&
                                                                mov.data_movimento >= dataInicial &&
                                                                mov.data_movimento <= dataFinal
                                                ).ToList();
            }

            // Laço de Repetição que vai percorrer a Lista de Consulta para alimentar o Grid na Tela!
            for(int i = 0; i < lstConsultas.Count; i++)
            {
                MovimentoVO objVO = new MovimentoVO();

                objVO.Categoria = lstConsultas[i].tb_categoria.nome_categoria;
                objVO.Empresa = lstConsultas[i].tb_empresa.nome_empresa;
                objVO.Conta = lstConsultas[i].tb_conta.banco_conta + " - " + lstConsultas[i].tb_conta.agencia_conta + 
                                                " - " + lstConsultas[i].tb_conta.numero_conta;
                objVO.Data = lstConsultas[i].data_movimento.ToShortDateString();
                objVO.Id = lstConsultas[i].id_movimento;
                objVO.OBS = lstConsultas[i].obs_movimento;
                objVO.Tipo = lstConsultas[i].tipo_movimento == 0 ? "Entrada" : "Saída";
                objVO.Valor = lstConsultas[i].valor_movimento;

                // Adiciona todo os dados levantados na consulta, no processo anterior na Lista de Retorno!
                lstRetorno.Add(objVO);
            }

            return lstRetorno;
        }

        public void ExcluirMovimentoDAO(int idMovimento)
        {
            // Transaction: Monitora a ação, se deu certo valida e registra no Banco de Dados, caso não, volta tudo como estava!
            // Porque o utilizamos? Porque a Exclusão vai afetar mais de uma Tabela no Banco de Dados, no caso a Tabela Movimento e Conta!
            using (TransactionScope tran = new TransactionScope())
            {
                // Resgata o Movimento já cadastrado!
                tb_movimento objMovimento = objBanco.tb_movimento.Where(mov => mov.id_movimento == idMovimento).FirstOrDefault();

                // Resgata a Conta Bancária já utilizada no Movimento que sera excluido!
                tb_conta objConta = objBanco.tb_conta.Where(conta => conta.id_conta == objMovimento.id_conta).FirstOrDefault();

                // Vamos verificar se vai adicionar ou remover o valor na Tabela Conta!
                if(objMovimento.tipo_movimento == 0)
                {
                    // Entrada de Dinheiro - Remove do Saldo!
                    objConta.saldo_conta -= objMovimento.valor_movimento;
                }
                else
                {
                    // Saída de Dinheiro - Devolve ao Saldo!
                    objConta.saldo_conta += objMovimento.valor_movimento;
                }

                // Salva a ação, atualziado o Saldo na Tabela Conta!
                objBanco.SaveChanges();

                // Remove da Tabela Movimento!
                objBanco.tb_movimento.Remove(objMovimento);

                // Exclui o Movimento no Banco de Dados!
                objBanco.SaveChanges();

                // Confirma toda a ação e valida a Transação!
                tran.Complete();
            }
        }
    }
}
