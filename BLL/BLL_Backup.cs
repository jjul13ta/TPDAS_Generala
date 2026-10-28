using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Backup
    {
        private MP_BACKUP mapper = new MP_BACKUP();

        // Devuelve false si la ruta está vacía
        public bool Backup(string ruta)
        {
            if (ruta.Trim() == "")
                return false;

            mapper.Backup(ruta);
            return true;
        }

        public bool Restore(string ruta)
        {
            if (ruta.Trim() == "")
                return false;

            mapper.Restore(ruta);
            return true;
        }
    }
}
