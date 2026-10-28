using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Turno
    {
        private List<Dado> dados;
        public List<Dado> Dados
        {
            get { return dados; }
            set { dados = value; }
        }

        private List<Tirada> tiradas;
        public List<Tirada> Tiradas
        {
            get { return tiradas; }
            set { tiradas = value; }
        }

        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        // Categoría que anotó el jugador en este turno (null hasta que anota)
        private Categoria categoriaAnotada;
        public Categoria CategoriaAnotada
        {
            get { return categoriaAnotada; }
            set { categoriaAnotada = value; }
        }

        public Turno()
        {
            dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            tiradas = new List<Tirada>();
        }
    }
}
