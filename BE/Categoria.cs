using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria
    {
        public Categoria()
        {
        }

        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int puntos;
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        private bool marcada;
        public bool Marcada
        {
            get { return marcada; }
            set { marcada = value; }
        }

    }
}
