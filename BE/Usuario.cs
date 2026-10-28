using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BE
{
    public class Usuario
    {
        private int tiempoJugadoTotal;

        private Planilla planilla;

        public Planilla Planilla
        {
            get { return planilla; }
            set { planilla = value; }
        }
        private int tiempojugado;


        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
