using DatabasePocketQueue.DAO.Database.Factory;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;

namespace DatabasePocketQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            bool debug = true;

            if (debug)
            {
                /*

                TipoSenha TS = new TipoSenha();
                RepositorioTipoSenha rs = new RepositorioTipoSenha();
                rs.InserirTipoSenha(TS);
                RepositorioSenha s = new RepositorioSenha();
                Senha p = new Senha(TS.IDTipoSenha);
                p.IDUsuario = B.IDUsuario;
                s.InserirSenha(p);
                Senha senha = new Senha();

                List<Usuario> u = R.ListarUsuariosCompleto();
                u.Add(null);

                //TipoUsuario
                TipoUsuario gerente, atendente, recepcionista, administrador;

                recepcionista = new TipoUsuario("Recepcionista");
                atendente = new TipoUsuario("Atendente");
                gerente = new TipoUsuario("Gerente");
                administrador = new TipoUsuario("Administrador");

                IRepositorioTipoUsuario iRTU = new RepositorioTipoUsuario();

                iRTU.InserirTipoUsuario(recepcionista);
                iRTU.InserirTipoUsuario(atendente);
                iRTU.InserirTipoUsuario(gerente);
                iRTU.InserirTipoUsuario(administrador);

                //EstadoSenha
                EstadoSenha nova, chamada, emAtendimento, fechada;

                nova = new EstadoSenha("Nova");
                chamada = new EstadoSenha("Chamada");
                emAtendimento = new EstadoSenha("Em Atendimento");
                fechada = new EstadoSenha("Fechada");

                IRepositorioEstadoSenha iRES = new RepositorioEstadoSenha();

                iRES.InserirEstadoSenha(nova);
                iRES.InserirEstadoSenha(chamada);
                iRES.InserirEstadoSenha(emAtendimento);
                iRES.InserirEstadoSenha(fechada);
                */
                //Teste Usuario
                RepositorioUsuario R = new RepositorioUsuario();
                Usuario A = new Usuario();
                Senha S = new Senha();

                A = R.ListarUsuarios()[0];

                RepositorioSenha RS = new RepositorioSenha();
                S.Atendido = DateTime.Now;
                S.Resolvido = null;
                S.Guiche = 1;
                S.EstadoSenha = "C";
                S.IDUsuario = 1;
                S.IDSenha = 1;
                RS.AlterarSenha(S);

                /*
                Senha S = new Senha();
                S.Atendido = DateTime.Now;
                S.EstadoSenha = "Nova";
                S.ListaUsuario = new List<Usuario>();
                S.ListaUsuario.Add(A);
                S.TipoSenha = "Preferencial";
                RepositorioSenha RS = new RepositorioSenha();
                RS.InserirSenha(S);
                */
                //Usuario B = new Usuario("B", "B", "B", "B", "B", "B", "B", "B", "B", "B", T.IDTipoUsuario);
                //R.InserirUsuario(B);

                //EndTesteUsuario
                
            }
        }
    }
}