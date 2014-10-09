using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using PocketQueue.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketQueue.Services
{
    public class EmissaoSenhasService
    {
        private IRepositorioSenha repSenha = new RepositorioSenha();
        public Senha UltimaSenha { get; set; }

        public Boolean IsSenhaAtual()
        {
            Senha temp = UltimaSenhaChamada();
            if ((UltimaSenha != null && temp != null) &&
                UltimaSenha.IDSenha == temp.IDSenha)
                return true;
            else
                UltimaSenha = temp;
            return false;
        }

        public Senha CriarSenha(ETipoSenha tipoSenha)
        {
            Senha senha = new Senha();

            senha.TipoSenha = ((int)tipoSenha == 1) ?
                new TipoSenha("Normal") :
                new TipoSenha("Preferencial");
            repSenha.InserirSenha(senha);

            return senha;
        }

        public Senha UltimaSenhaChamada()
        {
            return repSenha.ChamarSenha();
        }

        public String CaminhoAudio(String complemento)
        {
            String[] caminho = Directory.GetCurrentDirectory().Split('\\');
            String retorno = caminho[0];
            for (int i = 1; i < caminho.Length - 2; i++)
            {
                retorno += "\\" + caminho[i];
            }
            return retorno + complemento;
        }
    }
}
