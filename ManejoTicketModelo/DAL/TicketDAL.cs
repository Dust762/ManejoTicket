using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public class TicketDAL : ITicketDAL
    {
        private static List<Ticket> tickets = new List<Ticket>();

        public static readonly Estado EnProgreso = new Estado()
        {
            estadoNombre = "En progreso",
            codEstado = 1

        };
        public static readonly Estado Pendiente = new Estado()
        {
            estadoNombre = "Pendiente",
            codEstado = 2

        };

        public static readonly Estado Bloqueado = new Estado()
        {
            estadoNombre = "Bloqueado",
            codEstado = 3

        };

        public static readonly Estado Cerrado = new Estado()
        {
            estadoNombre = "Cerrado",
            codEstado = 4

        };
        public static readonly Estado Terminado = new Estado()
        {
            estadoNombre = "Terminado",
            codEstado = 5

        };

        public static readonly Prioridad Emergencia = new Prioridad()
        {
            Nombre = "Emergencia",
            codPrioridad = 1

        };

        public static readonly Prioridad Necesaria = new Prioridad()
        {
            Nombre = "Necesaria",
            codPrioridad = 2

        };

        public static readonly Prioridad Opcional = new Prioridad()
        {
            Nombre = "Opcional",
            codPrioridad = 3
        };
        public void actualizarTicket(Ticket t, string cambio, string option)
        {
            switch (option)
            {
                case "1":
                    t.NombreUsuario = cambio;
                    break;
                case "2":
                    t.NombreTecnico = cambio;
                    break;
                case "3":
                    t.Descripcion = cambio;
                    break;
                case "4":
                    t.Categoria = cambio;
                    break;
            }
        }

        public void agregarTicket(Ticket t)
        {
            tickets.Add(t);
        }

        public void eliminarTicket(Ticket t)
        {
            tickets.Remove(t);
        }

        public List<Ticket> mostrarTicket()
        {
            return tickets;
        }

        public bool ticketDisp(List<Ticket> tickets,int id)
        {
            Ticket temp = tickets.Find(tic => tic.IdTicket == id);
            if (temp.NombreTecnico.Equals(""))
            {
                return true;
            }
            return false;
        }

        public Ticket selTic(List<Ticket> tickets, int id)
        {
            Ticket t = tickets.Find(tic => tic.IdTicket == id);
            return t;
        }
    }
}
