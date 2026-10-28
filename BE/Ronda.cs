using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ronda
    {

        private Turno turnoJugador1;
        public Turno TurnoJugador1
        {
            get { return turnoJugador1; }
            set { turnoJugador1 = value; }
        }

        private Turno turnoJugador2;

        public Turno TurnoJugador2
        {
            get { return turnoJugador2; }
            set { turnoJugador2 = value; }
        }

    }
}
