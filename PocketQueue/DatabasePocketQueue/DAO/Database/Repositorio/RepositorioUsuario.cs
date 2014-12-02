using DatabasePocketQueue.DAO.Database.Factory;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using System.Linq;

namespace DatabasePocketQueue.DAO.Database.Repositorio
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public bool RemoverUsuario(Usuario usuario)
        {
            SqlConnection connection = null;

            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "delete from Usuario where Cpf = '" + usuario.Cpf + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool InserirUsuario(Usuario usuario)
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "insert into Usuario (Nome, Cpf, ULogin, USenha, TipoUsuario) values ('" +
                    usuario.Nome + "', '" + usuario.Cpf + "', '" + usuario.Login + "', '" +
                    usuario.Senha + "', '" + usuario.TipoUsuario + "')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Usuario> ListarUsuariosPorTipo(string tipoUsuario)
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "select * from Usuario where TipoUsuario = '" + tipoUsuario + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Usuario> usuarioList = new List<Usuario>();
                Usuario user;
                while (reader.Read())
                {
                    user = new Usuario();
                    user.IDUsuario = Int32.Parse(reader["IDUsuario"].ToString());
                    user.Nome = reader["Nome"].ToString();
                    user.Cpf = reader["Cpf"].ToString();
                    user.Login = reader["ULogin"].ToString();
                    user.Senha = reader["USenha"].ToString();
                    user.TipoUsuario = reader["TipoUsuario"].ToString();
                    usuarioList.Add(user);
                }

                return usuarioList;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Usuario> ListarUsuarios()
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "select * from Usuario";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Usuario> usuarioList = new List<Usuario>();
                Usuario user;
                while (reader.Read())
                {
                    user = new Usuario();
                    user.IDUsuario = Int32.Parse(reader["IDUsuario"].ToString());
                    user.Nome = reader["Nome"].ToString();
                    user.Cpf = reader["Cpf"].ToString();
                    user.Login = reader["ULogin"].ToString();
                    user.Senha = reader["USenha"].ToString();
                    user.TipoUsuario = reader["TipoUsuario"].ToString();
                    usuarioList.Add(user);
                }

                return usuarioList;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Usuario> ListarUsuariosCompleto()
        {
            throw new NotImplementedException();
        }
    }
}
