using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class SenhaMap : EntityTypeConfiguration<Senha>
    {
        public SenhaMap()
        {
            //Chave Primária
            HasKey(s => s.IDSenha);

            HasRequired<TipoSenha>(ts => ts.TipoSenha).WithMany(s => s.Senhas)
                .HasForeignKey(s => s.IDTipoSenha).WillCascadeOnDelete();

            /*
            //Chave Estrangeira
            HasRequired(s => s.EstadoSenha).WithRequiredDependent();*/

            //Chave Estrangeira de Usuario
            HasRequired<Usuario>(s => s.Usuario).WithMany(s => s.Senhas)
                .HasForeignKey(s => s.IDUsuario).WillCascadeOnDelete();

            //Chave Estrangeira
            HasRequired<EstadoSenha>(s => s.EstadoSenha).WithMany(s => s.Senhas)
                .HasForeignKey(s => s.IDEstadoSenha).WillCascadeOnDelete();
        }
    }
}
