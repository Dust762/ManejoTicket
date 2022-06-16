using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public class MensajeDAL : IMensajeDAL
    {
        private static List<Mensaje> mensajes = new List<Mensaje>();
        public void crearMensaje(Mensaje m)
        {
            mensajes.Add(m);
        }

        public void eliminarMensaje(Mensaje m)
        {
            mensajes.Remove(m);
        }

        public List<Mensaje> mostrarMensajes()
        {
            return mensajes;
        }
    }
}
