using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Partida
    {
            private int id;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            private Usuario ganador;
            public Usuario Ganador
            {
                get { return ganador; }
                set { ganador = value; }
            }

            private List<Ronda> rondas;
            public List<Ronda> Rondas
            {
                get { return rondas; }
                set { rondas = value; }
            }

            private Usuario jugador1;
            public Usuario Jugador1
            {
                get { return jugador1; }
                set { jugador1 = value; }
            }

            private Usuario jugador2;
            public Usuario Jugador2
            {
                get { return jugador2; }
                set { jugador2 = value; }
            }

            private DateTime fechaInicio;
            public DateTime FechaInicio
            {
                get { return fechaInicio; }
                set { fechaInicio = value; }
            }

            private DateTime fechaFin;
            public DateTime FechaFin
            {
                get { return fechaFin; }
                set { fechaFin = value; }
            }
        }

    
}
