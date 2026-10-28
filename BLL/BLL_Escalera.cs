using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Escalera : BLL_Categoria
    {
        public override bool SePuede(List<BE.Dado> dados)
        {
            int[] cantidades = new int[7];

            foreach (BE.Dado d in dados)
            {
                cantidades[d.Valor]++;
            }

            bool esMenor = cantidades[1] == 1 && cantidades[2] == 1 && cantidades[3] == 1 && cantidades[4] == 1 && cantidades[5] == 1;
            bool esMayor = cantidades[2] == 1 && cantidades[3] == 1 && cantidades[4] == 1 && cantidades[5] == 1 && cantidades[6] == 1;

            return esMenor || esMayor;
        }

        public override int calcularPuntos(List<BE.Dado> dados)
        {
            int total = 0;
            if (SePuede(dados))
            {
                total = 25;
            }
            return total;
        }
    }
}
