using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.VO
{
    public class MovimentoVO
    {
        // ClasseVO = Classe Value Object!
        // Value Object: Camada onde ela trafega os dados entre toda a aplicação, mantendo sua integridade!
        public int Id { get; set; }

        public string Tipo { get; set; }

        public string Data { get; set; }

        public decimal Valor { get; set; }

        public string Categoria { get; set; }

        public string Empresa { get; set; }

        public string Conta { get; set; }

        public string OBS { get; set; }
    }
}
