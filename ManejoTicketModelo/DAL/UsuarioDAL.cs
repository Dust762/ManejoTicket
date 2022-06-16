using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTicketModelo
{
    public class UsuarioDAL : IUsuarioDAL
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        public void agregarUsuario(Usuario u)
        {
            usuarios.Add(u);
        }

        public void eliminarUsuario(Usuario u)
        {
            usuarios.Remove(u);
        }

        public List<Usuario> mostrarUsuarios()
        {
            return usuarios;
        }
    }
}
