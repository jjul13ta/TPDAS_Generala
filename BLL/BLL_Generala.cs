using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Generala : BLL_Categoria
    {
        public override bool SePuede(List<BE.Dado> dados)
        {
            int[] cantidades = new int[7];

            foreach (Dado d in dados)
            {
                cantidades[d.Valor]++;
            }

            bool hayCinco = false;

            for (int i = 1; i <= 6; i++)
            {
                if (cantidades[i] == 5)
                {
                    hayCinco = true;
                }
            }

            return hayCinco;
        }


        public override int calcularPuntos(List<Dado> dados)
        {
            int total = 0;
            if (SePuede(dados))
            {
                total = 50;
            }

            return total;
        }
    }
}
