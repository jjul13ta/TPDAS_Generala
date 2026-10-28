using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Partida
    {
        private BLL_Planilla gestorPlanilla = new BLL_Planilla();
        private BLL_Ronda gestorRonda = new BLL_Ronda();
        private BLL_Bitacora gestorBitacora = new BLL_Bitacora();
        private MP_PARTIDA mapper = new MP_PARTIDA();

        // Devuelve false si falta un jugador o si es el mismo usuario en los dos lugares
        public bool IniciarPartida(BE.Partida partida)
        {
            if (partida.Jugador1 == null || partida.Jugador2 == null)
                return false;

            if (partida.Jugador1.ID == partida.Jugador2.ID)
                return false;

            partida.Rondas = new List<BE.Ronda>();
            partida.Ganador = null;
            partida.FechaInicio = DateTime.Now;

            partida.Jugador1.Planilla = new BE.Planilla();
            partida.Jugador1.Planilla.Categorias = CrearCategorias();

            partida.Jugador2.Planilla = new BE.Planilla();
            partida.Jugador2.Planilla.Categorias = CrearCategorias();

            gestorBitacora.Registrar(partida.Jugador1, "Comienzo de partida");
            gestorBitacora.Registrar(partida.Jugador2, "Comienzo de partida");

            return true;
        }

        private List<BE.Categoria> CrearCategorias()
        {
            List<BE.Categoria> categorias = new List<BE.Categoria>();

            categorias.Add(new BE.Numero(1));
            categorias.Add(new BE.Numero(2));
            categorias.Add(new BE.Numero(3));
            categorias.Add(new BE.Numero(4));
            categorias.Add(new BE.Numero(5));
            categorias.Add(new BE.Numero(6));
            categorias.Add(new BE.Categoria("Escalera"));
            categorias.Add(new BE.Categoria("Full"));
            categorias.Add(new BE.Categoria("Poker"));
            categorias.Add(new BE.Categoria("Generala"));

            return categorias;
        }

        // Las dos planillas completas = se jugaron todas las rondas
        public bool PartidaTerminada(BE.Partida partida)
        {
            return gestorPlanilla.PlanillaCompleta(partida.Jugador1.Planilla)
                && gestorPlanilla.PlanillaCompleta(partida.Jugador2.Planilla);
        }

        // Devuelve el turno que le toca jugar ahora (crea la ronda siguiente si hace falta).
        // Devuelve null cuando la partida terminó.
        public BE.Turno TurnoActual(BE.Partida partida)
        {
            if (PartidaTerminada(partida))
                return null;

            BE.Turno turno = null;

            if (partida.Rondas.Count > 0)
            {
                turno = gestorRonda.TurnoActual(partida.Rondas[partida.Rondas.Count - 1]);
            }

            if (turno == null)
            {
                BE.Ronda nueva = gestorRonda.NuevaRonda(partida);
                turno = gestorRonda.TurnoActual(nueva);
            }

            return turno;
        }

        public void TerminarPartida(BE.Partida partida)
        {
            partida.FechaFin = DateTime.Now;

            int puntajeJugador1 = gestorPlanilla.PuntajeTotal(partida.Jugador1.Planilla);
            int puntajeJugador2 = gestorPlanilla.PuntajeTotal(partida.Jugador2.Planilla);

            if (puntajeJugador1 > puntajeJugador2)
            {
                partida.Ganador = partida.Jugador1;
            }
            else if (puntajeJugador2 > puntajeJugador1)
            {
                partida.Ganador = partida.Jugador2;
            }
            else
            {
                partida.Ganador = null; // empate
            }

            mapper.Insertar(partida);

            gestorBitacora.Registrar(partida.Jugador1, "Fin de partida");
            gestorBitacora.Registrar(partida.Jugador2, "Fin de partida");
        }

        // ---------- Estadísticas ----------

        public int Ganadas(BE.Usuario usuario)
        {
            int total = 0;
            foreach (BE.Partida p in mapper.ListarPorUsuario(usuario.ID))
            {
                if (p.Ganador != null && p.Ganador.ID == usuario.ID)
                {
                    total++;
                }
            }
            return total;
        }

        public int Perdidas(BE.Usuario usuario)
        {
            int total = 0;
            foreach (BE.Partida p in mapper.ListarPorUsuario(usuario.ID))
            {
                if (p.Ganador != null && p.Ganador.ID != usuario.ID)
                {
                    total++;
                }
            }
            return total;
        }

        public int Empatadas(BE.Usuario usuario)
        {
            int total = 0;
            foreach (BE.Partida p in mapper.ListarPorUsuario(usuario.ID))
            {
                if (p.Ganador == null)
                {
                    total++;
                }
            }
            return total;
        }

        // Devuelve el porcentaje de victorias (0 a 100)
        public double PromedioVictorias(BE.Usuario usuario)
        {
            int ganadas = Ganadas(usuario);
            int jugadas = mapper.ListarPorUsuario(usuario.ID).Count;

            double promedio = 0;
            if (jugadas > 0)
            {
                promedio = (double)ganadas * 100 / jugadas;
            }
            return promedio;
        }

        // Devuelve el total de tiempo jugado en segundos
        public int TiempoTotal(BE.Usuario usuario)
        {
            int segundos = 0;
            foreach (BE.Partida p in mapper.ListarPorUsuario(usuario.ID))
            {
                TimeSpan duracion = p.FechaFin - p.FechaInicio;
                segundos = segundos + (int)duracion.TotalSeconds;
            }
            return segundos;
        }
    }
}
