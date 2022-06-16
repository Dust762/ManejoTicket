using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public interface ITicketDAL
    {
        void agregarTicket(Ticket t);
        List<Ticket> mostrarTicket();

        void eliminarTicket(Ticket t);
        void actualizarTicket(Ticket t, String cambio, string option);
    }
}
