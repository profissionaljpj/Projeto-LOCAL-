using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    public class Senha
    {
        public Senha()
        {
            this.Criacao = DateTime.Now;
            this.TipoSenha = "Nova";
        }

        public int IDSenha { get; set; }
        public DateTime? Criacao { get; set; }
        public DateTime? Atendido { get; set; }
        public DateTime? Resolvido { get; set; }
        public int Guiche { get; set; }

        public string TipoSenha { get; set; }
        public string EstadoSenha { get; set; }
        public int IDUsuario { get; set; }
    }
}
