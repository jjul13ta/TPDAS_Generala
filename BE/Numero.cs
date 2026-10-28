using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Numero : Categoria
    {
        private int valor;
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

            public Numero(int valor) : base("Numero " + valor)
            {
                this.valor = valor;
            }
        }
    
}
