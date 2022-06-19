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

        public bool encontrarTecnico(List<Tecnico> tecnicos, string rut)
        {
            for (int i = 0; i < tecnicos.Count; i++)
            {
                if (tecnicos[i].Rut.Equals(rut))
                {
                    return true;
                    
                }
            }
            return false;
        }

        public string encontrarTecnicoId(List<Tecnico> tecnicos, int id)
        {
            Tecnico temp = tecnicos.Find(tec => tec.IdTecnico == id);
            return temp.Nombre;
        }

        public List<Tecnico> mostrarTecnicos()
        {
            return tecnicos;
        }
    }
}
