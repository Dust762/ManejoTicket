using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public interface IUsuarioDAL
    {
        void agregarUsuario(Usuario u);
        List<Usuario> mostrarUsuarios();
        void eliminarUsuario(Usuario u);
    }
}
