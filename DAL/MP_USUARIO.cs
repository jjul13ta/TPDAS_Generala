using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_USUARIO
    {
        public List<Usuario> Listar()
        {
            Acceso acceso = new Acceso();
            List<Usuario> lista = new List<Usuario>();
            try
            {
                acceso.Abrir();
                using (SqlDataReader reader = acceso.Leer("USUARIO_LISTAR"))
                {
                    while (reader.Read())
                    {
                        Usuario u = new Usuario();
                        u.ID = reader.GetInt32(0);
                        u.UserName = reader.GetString(1);
                        u.Password = reader.GetString(2);
                        lista.Add(u);
                    }
                }
            }
            finally { acceso.Cerrar(); }
            return lista;
        }

        // Devuelve el Usuario si existe, o null si no coincide
        public Usuario Login(string nombre, string contraseña)
        {
            Acceso acceso = new Acceso();
            Usuario u = null;
            try
            {
                acceso.Abrir();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("@usu", nombre));
                parametros.Add(acceso.CrearParametro("@pass", contraseña));

                using (SqlDataReader reader = acceso.Leer("USUARIO_LOGIN", parametros))
                {
                    if (reader.Read())
                    {
                        u = new Usuario();
                        u.ID = reader.GetInt32(0);
                        u.UserName = reader.GetString(1);
                        u.Password = reader.GetString(2);
                    }
                }
            }
            finally { acceso.Cerrar(); }
            return u;
        }

        public void Insertar(Usuario u)
        {
            Acceso acceso = new Acceso();
            try
            {
                acceso.Abrir();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("@usu", u.UserName));
                parametros.Add(acceso.CrearParametro("@pass", u.Password));
                acceso.Escribir("USUARIO_INSERTAR", parametros);
            }
            finally { acceso.Cerrar(); }
        }
    }
}

