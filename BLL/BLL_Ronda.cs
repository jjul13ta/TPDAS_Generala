using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Ronda
    {
        public BE.Ronda NuevaRonda(BE.Partida partida)
        {
            BE.Ronda ronda = new BE.Ronda();

            ronda.TurnoJugador1 = new BE.Turno();
            ronda.TurnoJugador1.Usuario = partida.Jugador1;

            ronda.TurnoJugador2 = new BE.Turno();
            ronda.TurnoJugador2.Usuario = partida.Jugador2;

            partida.Rondas.Add(ronda);
            return ronda;
        }

        // Devuelve el turno que le toca jugar, o null si la ronda ya terminó
        public BE.Turno TurnoActual(BE.Ronda ronda)
        {
            BE.Turno actual = null;

            if (ronda.TurnoJugador1.CategoriaAnotada == null)
            {
                actual = ronda.TurnoJugador1;
            }
            else if (ronda.TurnoJugador2.CategoriaAnotada == null)
            {
                actual = ronda.TurnoJugador2;
            }

            return actual;
        }
    }
}
