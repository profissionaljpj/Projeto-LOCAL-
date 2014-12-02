using DatabasePocketQueue.DAO.Entidades;
using System.Collections.Generic;

namespace DatabasePocketQueue.DAO.Database.IRepositorio
{
    public interface IRepositorioSenha
    {
        bool RemoverSenha(Senha senha);
        bool InserirSenha(Senha senha);
        List<Senha> ListarSenha();
        bool AlterarSenha(Senha senha);
        Senha ChamarSenha();
        Senha MostarProximaSenha();
        Senha BuscarSenha(Senha senha);
    }
}
