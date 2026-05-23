using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO
    {
        // Recurso restrito para o construtor da Camada DAO!
        private readonly db_financeiro_sab_08 objBanco;

        // Construtor para carregar os dados que os Métodos vão utilizar, com os recursos do Banco de Dados!
        public CategoriaDAO()
        {
            objBanco = new db_financeiro_sab_08();
        }

        // Método para Cadastrar itens no Banco de Dados!
        public void CadastrarCategoriaDAO(tb_categoria objCategoria)
        {
            objBanco.tb_categoria.Add(objCategoria);
            objBanco.SaveChanges();
        }

        // Método para Consultar itens no Banco de Dados!
        public List<tb_categoria> ConsultarCategoriaDAO(int idLogado)
        {
            List<tb_categoria> lstCategorias = objBanco.tb_categoria.Where(categoria => categoria.id_usuario == idLogado).ToList();

            return lstCategorias;
        }

        // Método para Alterar itens no Banco de Dados!
        public void AlterarCategoriaDAO(tb_categoria objCategoria)
        {
            tb_categoria objUpdate = objBanco.tb_categoria.Where(categoria => categoria.id_categoria == objCategoria.id_categoria).FirstOrDefault();

            objUpdate.nome_categoria = objCategoria.nome_categoria;

            objBanco.SaveChanges();
        }

        // Método para Deletar itens no Banco de Dados!
        public void ExcluirCategoriaDAO(int idRegistro)
        {
            tb_categoria objDelete = objBanco.tb_categoria.Where(categoria => categoria.id_categoria == idRegistro).FirstOrDefault();

            objBanco.tb_categoria.Remove(objDelete);

            objBanco.SaveChanges();
        }
    }
}
