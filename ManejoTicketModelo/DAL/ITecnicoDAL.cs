using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public interface ITecnicoDAL
    {
        void agregarTecnico(Tecnico t);
        void eliminarTecnico(Tecnico t);
        List<Tecnico> mostrarTecnicos();

        bool encontrarTecnico(List<Tecnico> tecnicos, String rut);

        string encontrarTecnicoId(List<Tecnico> tecnicos, int id);
    }
}
