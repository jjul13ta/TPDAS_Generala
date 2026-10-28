using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_PARTIDA
    {
            public void Insertar(Partida p)
            {
                Acceso acceso = new Acceso();
                try
                {
                    acceso.Abrir();
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(acceso.CrearParametro("@jug1", p.Jugador1.ID));
                    parametros.Add(acceso.CrearParametro("@jug2", p.Jugador2.ID));

                    if (p.Ganador == null)
                        parametros.Add(acceso.CrearParametroNulo("@ganador"));
                    else
                        parametros.Add(acceso.CrearParametro("@ganador", p.Ganador.ID));

                    parametros.Add(acceso.CrearParametro("@inicio", p.FechaInicio));
                    parametros.Add(acceso.CrearParametro("@fin", p.FechaFin));
                    acceso.Escribir("PARTIDA_INSERTAR", parametros);
                }
                finally { acceso.Cerrar(); }
            }

            // Partidas donde participó el usuario
            public List<Partida> ListarPorUsuario(int idUsuario)
            {
                Acceso acceso = new Acceso();
                List<Partida> lista = new List<Partida>();
                try
                {
                    acceso.Abrir();
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(acceso.CrearParametro("@usu", idUsuario));

                    using (SqlDataReader reader = acceso.Leer("PARTIDA_LISTAR_USUARIO", parametros))
                    {
                        while (reader.Read())
                        {
                            Partida p = new Partida();
                            p.ID = reader.GetInt32(0);

                            p.Jugador1 = new Usuario();
                            p.Jugador1.ID = reader.GetInt32(1);

                            p.Jugador2 = new Usuario();
                            p.Jugador2.ID = reader.GetInt32(2);

                            if (reader.IsDBNull(3))
                            {
                                p.Ganador = null; // empate
                            }
                            else
                            {
                                p.Ganador = new Usuario();
                                p.Ganador.ID = reader.GetInt32(3);
                            }

                            p.FechaInicio = reader.GetDateTime(4);
                            p.FechaFin = reader.GetDateTime(5);
                            lista.Add(p);
                        }
                    }
                }
                finally { acceso.Cerrar(); }
                return lista;
            }
        }
    }
