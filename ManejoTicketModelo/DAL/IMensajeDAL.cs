using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public interface IMensajeDAL
    {
        void crearMensaje(Mensaje m);
        void eliminarMensaje(Mensaje m);
        List<Mensaje> mostrarMensajes();
    }
}
