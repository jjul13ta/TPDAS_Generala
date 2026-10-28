using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Bitacora
    {
        private MP_BITACORA mapper = new MP_BITACORA();

        public void Registrar(Usuario usuario, string evento)
        {
            Bitacora b = new Bitacora();
            b.Usuario = usuario;
            b.Fecha = DateTime.Now;
            b.Evento = evento;
            mapper.Insertar(b);
        }

        public List<Bitacora> Listar()
        {
            return mapper.Listar();
        }
    
}
}
