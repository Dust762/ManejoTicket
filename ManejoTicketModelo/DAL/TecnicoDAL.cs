using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public class TecnicoDAL : ITecnicoDAL
    {
        private static List<Tecnico> tecnicos = new List<Tecnico>();
        public void agregarTecnico(Tecnico t)
        {
            tecnicos.Add(t);
        }

        public void eliminarTecnico(Tecnico t)
        {
            tecnicos.Remove(t);
        }

        public List<Tecnico> mostrarTecnicos()
        {
            return tecnicos;
        }
    }
}
