using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLL_Turno
    {
        private BLL_Tirada gestorTirada = new BLL_Tirada();
        private BLL_Planilla gestorPlanilla = new BLL_Planilla();

        public bool SePuede(BE.Turno turno)
        {
            bool sepuede = true;
            if (turno.Numero >= 3 || turno.CategoriaAnotada != null || gestorPlanilla.PlanillaCompleta(turno.Usuario.Planilla))
            {
                sepuede = false;
            }
            return sepuede;
        }

        public void Tirar(BE.Turno turno, List<int> indices = null)
        {
            if (SePuede(turno))
            {
                BE.Tirada tirada = new BE.Tirada();
                tirada.Dados = turno.Dados;

                if (indices == null || indices.Count == 0)
                    gestorTirada.TirarTodos(tirada);
                else
                    gestorTirada.TirarSeleccionados(tirada, indices);

                // guardo una copia de los valores de esta tirada
                List<BE.Dado> copia = new List<BE.Dado>();
                foreach (BE.Dado d in turno.Dados)
                {
                    BE.Dado nuevo = new BE.Dado();
                    nuevo.Valor = d.Valor;
                    copia.Add(nuevo);
                }
                tirada.Dados = copia;

                turno.Tiradas.Add(tirada);
                turno.Numero++;
            }
        }

        // Devuelve false si todavía no tiró, si el turno ya terminó o si la categoría ya estaba marcada
        public bool Anotar(BE.Turno turno, BE.Categoria categoria)
        {
            bool seAnoto = false;

            if (turno.Numero > 0 && turno.CategoriaAnotada == null)
            {
                seAnoto = gestorPlanilla.Anotar(turno.Usuario.Planilla, categoria, turno.Dados);

                if (seAnoto)
                {
                    turno.CategoriaAnotada = categoria;
                }
            }

            return seAnoto;
        
    }
    }
}
