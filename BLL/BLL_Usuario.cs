using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Usuario
    {

            public static List<string> SesionesIniciadas = new List<string>();
            private MP_USUARIO mapper = new MP_USUARIO();
            private BLL_Bitacora gestorBitacora = new BLL_Bitacora();

            // Devuelve el Usuario logueado, o null si falló
            public Usuario Login(string nombre, string contraseña)
            {
                if (nombre.Trim() == "" || contraseña.Trim() == "")
                    return null;

                Usuario u = mapper.Login(nombre, contraseña);

                if (u != null)
                {
                    if (!SesionesIniciadas.Contains(u.UserName))
                        SesionesIniciadas.Add(u.UserName);

                    gestorBitacora.Registrar(u, "Inicio de sesión");
                }

                return u;
            }

            public void Logout(Usuario usuario)
            {
                SesionesIniciadas.Remove(usuario.UserName);
                gestorBitacora.Registrar(usuario, "Cierre de sesión");
            }

            // Devuelve false si hay campos vacíos o el nombre ya existe
            public bool Registrar(string nombre, string contraseña)
            {
                if (nombre.Trim() == "" || contraseña.Trim() == "")
                    return false;

                foreach (Usuario existente in mapper.Listar())
                {
                    if (existente.UserName == nombre)
                        return false;
                }

                Usuario nuevo = new Usuario();
                nuevo.UserName = nombre;
                nuevo.Password = contraseña;
                mapper.Insertar(nuevo);
                return true;
            }
        }  
}

