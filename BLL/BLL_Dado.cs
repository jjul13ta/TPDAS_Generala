using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLL_Dado
    {
        private static Random rnd = new Random();
        public void Tirar(BE.Dado dado)
        {
            dado.Valor = rnd.Next(1, 7);
        }
    }
}
