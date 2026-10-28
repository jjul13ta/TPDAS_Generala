using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Numero : BLL_Categoria
    {
        private int valor;
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public BLL_Numero(int valor)
        {
            this.valor = valor;
        }

        public override bool SePuede(List<Dado> dados)
        {
            return true; // ya que eso lo verifica la planilla
        }


        public override int calcularPuntos(List<BE.Dado> dados)
        {
            int total = 0;

            foreach (BE.Dado d in dados)
            {
                if (d.Valor == valor)
                {
                    total = total + d.Valor;
                }
            }

            return total;
        }
    }
}
