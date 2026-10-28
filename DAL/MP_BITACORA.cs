using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_BITACORA
    {
        public void Insertar(Bitacora b)
        {
            Acceso acceso = new Acceso();
            try
            {
                acceso.Abrir();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("@usu", b.Usuario.ID));
                parametros.Add(acceso.CrearParametro("@fecha", b.Fecha));
                parametros.Add(acceso.CrearParametro("@evento", b.Evento));
                acceso.Escribir("BITACORA_INSERTAR", parametros);
            }
            finally { acceso.Cerrar(); }
        }

        public List<Bitacora> Listar()
        {
            Acceso acceso = new Acceso();
            List<Bitacora> lista = new List<Bitacora>();
            try
            {
                acceso.Abrir();
                using (SqlDataReader reader = acceso.Leer("BITACORA_LISTAR"))
                {
                    while (reader.Read())
                    {
                        Bitacora b = new Bitacora();
                        b.ID = reader.GetInt32(0);

                        b.Usuario = new Usuario();
                        b.Usuario.ID = reader.GetInt32(1);
                        b.Usuario.UserName = reader.GetString(2);

                        b.Fecha = reader.GetDateTime(3);
                        b.Evento = reader.GetString(4);
                        lista.Add(b);
                    }
                }
            }
            finally { acceso.Cerrar(); }
            return lista;
        }
    }
}
