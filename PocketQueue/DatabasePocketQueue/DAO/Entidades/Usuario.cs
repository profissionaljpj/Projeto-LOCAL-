using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    /// <summary>
    /// Classe que representa o usuário do sistema, com informações pessoais e credenciais do sistema.
    /// </summary>
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
        
        public List<Senha> Senhas { get; set; }
    }
}
