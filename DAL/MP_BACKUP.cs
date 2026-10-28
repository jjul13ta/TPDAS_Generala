using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_BACKUP
    {
        public void Backup(string ruta)
        {
            Acceso acceso = new Acceso();
            try
            {
                acceso.Abrir();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("@ruta", ruta));
                acceso.Escribir("BACKUP DATABASE GENERALA TO DISK = @ruta WITH INIT", parametros, false);
            }
            finally { acceso.Cerrar(); }
        }

        public void Restore(string ruta)
        {
            Acceso acceso = new Acceso();
            try
            {
                acceso.AbrirMaster();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("@ruta", ruta));

                string sql = "ALTER DATABASE GENERALA SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                             "RESTORE DATABASE GENERALA FROM DISK = @ruta WITH REPLACE; " +
                             "ALTER DATABASE GENERALA SET MULTI_USER;";
                acceso.Escribir(sql, parametros, false);
            }
            finally { acceso.Cerrar(); }

            SqlConnection.ClearAllPools();
        }
    }

}
