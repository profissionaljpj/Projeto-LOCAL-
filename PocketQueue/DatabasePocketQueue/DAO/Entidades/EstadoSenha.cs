using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    public class EstadoSenha
    {
        public EstadoSenha() { }
        public EstadoSenha(int idEstadoSenha, String estado)
        {
            this.IDEstadoSenha = idEstadoSenha;
            this.Estado = estado;
        }
        public String Estado { get; set; }
        public int IDEstadoSenha { get; set; }
        public virtual ICollection<Senha> Senhas { get; set; }
    }
}
