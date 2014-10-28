using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    /// <summary>
    /// Classe responsável pelas senhas que serão emitidas no sistema.
    /// </summary>
    public class Senha
    {
        public Senha()
        {
            this.Criacao = DateTime.Now;
        }
        public Senha(TipoSenha tipoSenha, EstadoSenha estadoSenha)
        {
            //DataCriacao
            this.Criacao = DateTime.Now;

            //TipoSenha
            this.TipoSenha = tipoSenha;

            //EstadoSenha
            this.EstadoSenha = estadoSenha;
        }

        /// <summary>
        /// ID da senha que será gerada automaticamente pelo banco.
        /// </summary>
        public int IDSenha { get; set; }
        /// <summary>
        /// Data em que a senha foi gerada.
        /// </summary>
        public DateTime? Criacao { get; set; }
        /// <summary>
        /// Data em que o cliente iniciou o atendimento.
        /// </summary>
        public DateTime? Atendido { get; set; }
        /// <summary>
        /// Data em que o cliente terminou o atendimento.
        /// </summary>
        public DateTime? Resolvido { get; set; }
        /// <summary>
        /// Guiche onde a senha foi atendida
        /// </summary>
        public int Guiche { get; set; }

        #region Chaves Estrangeiras
        /// <summary>
        /// Chave Estrangeira IDTipoSenha, Referencia TipoSenha.
        /// </summary>
        public int IDTipoSenha { get; set; }
        public virtual TipoSenha TipoSenha { get; set; }
        /// <summary>
        /// Usuário.
        /// </summary>
        public int IDUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        /// <summary>
        /// Estado da senha (atendido, nova)
        /// </summary>
        public int IDEstadoSenha { get; set; }
        public virtual EstadoSenha EstadoSenha { get; set; }
        #endregion

    }
}
