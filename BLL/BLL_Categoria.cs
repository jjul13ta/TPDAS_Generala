using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Categoria
    {
        public virtual bool SePuede(List<BE.Dado> dados)
        {
            bool sepuede = true;
            return sepuede;
        }

        public virtual int calcularPuntos(List<BE.Dado> dados)
        {
            return 0;
        }
    }
}
