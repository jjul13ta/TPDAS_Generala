using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Tirada
    {
        private BLL_Dado gestorDado = new BLL_Dado();

        public void TirarTodos(BE.Tirada tirada)
        {
            foreach (BE.Dado dado in tirada.Dados)
                gestorDado.Tirar(dado);
        }

        public void TirarSeleccionados(BE.Tirada tirada, List<int> indices) 
        {
            foreach (var i in indices)
                gestorDado.Tirar(tirada.Dados[i]);
        }


    }
}
