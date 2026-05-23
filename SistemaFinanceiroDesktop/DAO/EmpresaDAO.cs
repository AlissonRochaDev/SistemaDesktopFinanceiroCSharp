using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmpresaDAO
    {
        
        private readonly db_financeiro_sab_08 objBanco;

        public EmpresaDAO()
        {
            objBanco = new db_financeiro_sab_08();
        }

        public void CadastrarEmpresaDAO(tb_empresa objEmpresa)
        {
            objBanco.tb_empresa.Add(objEmpresa);
            objBanco.SaveChanges();
        }

        public List<tb_empresa> ConsultarEmpresaDAO(int idLogado)
        {
            List<tb_empresa> lstEmpresas = objBanco.tb_empresa.Where(empresa => empresa.id_usuario == idLogado).ToList();

            return lstEmpresas;
        }

        public void AlterarEmpresaDAO(tb_empresa objEmpresa)
        {
            tb_empresa objUpdate = objBanco.tb_empresa.Where(empresa => empresa.id_empresa == objEmpresa.id_empresa).FirstOrDefault();

            objUpdate.nome_empresa = objEmpresa.nome_empresa;
            objUpdate.telefone_empresa = objEmpresa.telefone_empresa;
            objUpdate.endereco_empresa = objEmpresa.endereco_empresa;

            objBanco.SaveChanges();
        }

        public void ExcluirEmpresaDAO(int idRegistro)
        {
            tb_empresa objDelete = objBanco.tb_empresa.Where(empresa => empresa.id_empresa == idRegistro).FirstOrDefault();

            objBanco.tb_empresa.Remove(objDelete);

            objBanco.SaveChanges();
        }
    }
}