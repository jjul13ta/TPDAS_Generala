using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Poker : BLL_Categoria
    {
        public override bool SePuede(List<BE.Dado> dados)
        {
            int[] cantidades = new int[7]; // índice 0 sin usar, 1 a 6

            foreach (Dado d in dados)
            {
                cantidades[d.Valor]++;
            }

            bool hayCuadro = false;

            for (int i = 1; i <= 6; i++)
            {
                if (cantidades[i] == 4)
                {
                    hayCuadro = true;
                }
            }

            return hayCuadro;
        }

        public override int calcularPuntos(List<BE.Dado> dados)
        {
            int total = 0;
            if (SePuede(dados))
            {
                total = 40;
            }
            return total;
        }
    }
}
