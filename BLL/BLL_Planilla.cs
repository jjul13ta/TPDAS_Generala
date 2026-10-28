using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLL_Planilla
    {
        private BLL_Categoria ObtenerGestor(BE.Categoria categoria)
        {
            BLL_Categoria gestor = null;

            switch (categoria.Nombre)
            {
                case "Numero":
                    Numero num = null;
                    gestor = new BLL_Numero(num.Valor); // esto capaz explota
                    break;
                case "Escalera":
                    gestor = new BLL_Escalera();
                    break;
                case "Full":
                    gestor = new BLL_Full();
                    break;
                case "Poker":
                    gestor = new BLL_Poker();
                    break;
                case "Generala":
                    gestor = new BLL_Generala();
                    break;
            }

            return gestor;
        }

        public bool Anotar(BE.Planilla planilla, BE.Categoria categoria, List<BE.Dado> dados)
        {
            bool seAnoto = true;
            foreach (BE.Categoria c in planilla.Categorias)
            {
                if (c == categoria)
                {
                    if (c.Marcada == true)
                    {
                        seAnoto = false;
                    }
                    else

                    {
                        BLL_Categoria gestorCategoria = ObtenerGestor(c);
                        c.Puntos = gestorCategoria.calcularPuntos(dados);
                        c.Marcada = true;
                    }
                }
            }
            return seAnoto;
        }

        public int PuntajeTotal(BE.Planilla planilla)
        {
            int total = 0;

            foreach (BE.Categoria c in planilla.Categorias)
            {
                total = total + c.Puntos;
            }

            return total;
        }

        public List<BE.Categoria> CategoriasDisponibles(BE.Planilla planilla)
        {
            List<BE.Categoria> disponibles = new List<BE.Categoria>();
            foreach (BE.Categoria c in planilla.Categorias)
            {
                if (c.Marcada == false)
                {
                    disponibles.Add(c);
                }
            }
            return disponibles;
        }

        public bool PlanillaCompleta(BE.Planilla planilla)
        {
            bool completa = true;
            foreach (BE.Categoria c in planilla.Categorias)
            {
                if (c.Marcada == false)
                {
                    completa = false;
                }
            }
            return completa;
        }
    }
}
