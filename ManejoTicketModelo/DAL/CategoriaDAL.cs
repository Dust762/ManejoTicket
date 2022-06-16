using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public class CategoriaDAL : ICategoriaDAL
    {
        private static List<Categoria> categorias = new List<Categoria>();
        public void agregarCategoria(Categoria c)
        {
            categorias.Add(c);
        }

        public void eliminarCategoria(Categoria c)
        {
            categorias.Remove(c);
        }

        public List<Categoria> mostrarCategorias()
        {
            return categorias;
        }
    }
}
