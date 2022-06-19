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

        public Categoria encontrarCat(int cod)
        {
            Categoria c = categorias.Find(cat => cat.CodCategoria == cod);
            return c;
        }

        public List<Categoria> mostrarCategorias()
        {
            return categorias;
        }
    }
}
