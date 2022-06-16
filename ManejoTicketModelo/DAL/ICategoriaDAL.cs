using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public interface ICategoriaDAL
    {
        void agregarCategoria(Categoria c);
        void eliminarCategoria(Categoria c);
        List<Categoria> mostrarCategorias();
    }
}
