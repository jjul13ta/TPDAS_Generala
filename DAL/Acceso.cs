using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Acceso
    {
        private const string CadenaConexion =
            "Data Source=.;Initial Catalog=GENERALA;Integrated Security=True";
        private const string CadenaMaster =
    "Data Source=.;Initial Catalog=master;Integrated Security=True";

        private SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
        }

        public void Cerrar()
        {
            if (conexion != null && conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
                conexion.Dispose();
            }
            conexion = null;
        }

        // ---------- Creación de parámetros (sobrecarga: mismo nombre, distinta firma) ----------

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = (object)valor ?? DBNull.Value;   // null => no obligatorio
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = valor;
            p.DbType = DbType.Int32;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, bool valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = valor;
            p.DbType = DbType.Boolean;
            return p;
        }

        // ---------- Comando ----------

        // Por defecto ejecuta procedimientos almacenados.
        // Pasar esProcedimiento = false para ejecutar una consulta SQL como texto.
        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null, bool esProcedimiento = true)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = esProcedimiento ? CommandType.StoredProcedure : CommandType.Text;
            cmd.Connection = conexion;

            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }

            return cmd;
        }

        // ---------- Lectura (SELECT) ----------
        // Importante: la conexión debe seguir abierta mientras se usa el reader.
        public SqlDataReader Leer(string sql, List<SqlParameter> parametros = null, bool esProcedimiento = true)
        {
            SqlCommand cmd = CrearComando(sql, parametros, esProcedimiento);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        // ---------- Escritura (INSERT / UPDATE / DELETE) ----------
        // Devuelve la cantidad de filas afectadas.
        public int Escribir(string sql, List<SqlParameter> parametros = null, bool esProcedimiento = true)
        {
            SqlCommand cmd = CrearComando(sql, parametros, esProcedimiento);
            return cmd.ExecuteNonQuery();

        }

        public void AbrirMaster()
        {
            conexion = new SqlConnection(CadenaMaster);
            conexion.Open();
        }

        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = valor;
            p.DbType = DbType.DateTime;
            return p;
        }

        // Parámetro con valor NULL (para el ganador cuando hay empate)
        public SqlParameter CrearParametroNulo(string nombre)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = DBNull.Value;
            return p;
        }
    }
}
