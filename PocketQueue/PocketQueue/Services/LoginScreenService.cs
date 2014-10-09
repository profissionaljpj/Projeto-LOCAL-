using PocketQueue.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;

namespace PocketQueue.Services
{
    class LoginScreenService
    {
        public Usuario ValidarLogin(string usuario, string senha)
        {
            IRepositorioUsuario repUsuario = new RepositorioUsuario();
            List<Usuario> usuarioList = repUsuario.ListarUsuarios();

            foreach(Usuario u in usuarioList) {
                if (u.Login.Equals(usuario) && u.Senha.Equals(senha)){
                    return u;
                }
            }

            return null;
        }
    }
}
