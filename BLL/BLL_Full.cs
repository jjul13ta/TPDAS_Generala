using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Full : BLL_Categoria
    {
        public override bool SePuede(List<Dado> dados)
        {
            int[] cantidades = new int[7]; // índice 0 sin usar, 1 a 6

            foreach (Dado d in dados)
            {
                cantidades[d.Valor]++;
            }

            bool hayTrio = false;
            bool hayPar = false;

            for (int i = 1; i <= 6; i++)
            {
                if (cantidades[i] == 3)
                {
                    hayTrio = true;
                }
                if (cantidades[i] == 2)
                {
                    hayPar = true;
                }
            }

            return hayTrio && hayPar;
        }

        public override int calcularPuntos(List<Dado> dados)
        {
            int valor = 0;
            if (SePuede(dados))
            {
                valor = 30;
            }
            return valor;

        }
    }
}
