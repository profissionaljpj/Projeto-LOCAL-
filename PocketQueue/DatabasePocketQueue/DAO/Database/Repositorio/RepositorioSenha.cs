using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabasePocketQueue.DAO.Database.Factory;
using System.Data.SqlClient;

namespace DatabasePocketQueue.DAO.Database.Repositorio
{
    public class RepositorioSenha : IRepositorioSenha
    {
        public bool RemoverSenha(Senha senha)
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "delete from Senha where idSenha = " + senha.IDSenha;
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
        public bool InserirSenha(Senha senha)
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "insert into Senha(Criacao, Atendido, Resolvido, Guiche, TipoSenha, EstadoSenha, IDUsuario) values" +
                    " ('" + DateTime.Now + "', null, null, 0, '" + senha.TipoSenha + "', 'Nova', " + senha.IDUsuario + ")";
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
        public List<Senha> ListarSenha()
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "select * from Senha";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Senha> senhaList = new List<Senha>();
                Senha senha;

                while (reader.Read())
                {
                    senha = new Senha();

                    if (!reader["Atendido"].ToString().Equals(""))
                    {
                        senha.Atendido = DateTime.Parse(reader["Atendido"].ToString());
                    }
                    if (!reader["Criacao"].ToString().Equals(""))
                    {
                        senha.Criacao = DateTime.Parse(reader["Criacao"].ToString());
                    }
                    if (!reader["Resolvido"].ToString().Equals(""))
                    {
                        senha.Resolvido = DateTime.Parse(reader["Resolvido"].ToString());
                    }

                    senha.EstadoSenha = (String)reader["EstadoSenha"];
                    senha.Guiche = (Int32)reader["Guiche"];
                    senha.IDSenha = (Int32)reader["IDSenha"];
                    senha.TipoSenha = (String)reader["TipoSenha"];
                    senha.IDUsuario = (Int32)reader["IDUsuario"];
                    senhaList.Add(senha);
                }

                return senhaList;
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
        public bool AlterarSenha(Senha senha)
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "update Senha set Atendido = '" + senha.Atendido + "', Resolvido = '" + senha.Resolvido +
                    "', Guiche = " + senha.Guiche + ", EstadoSenha = '" + senha.EstadoSenha + "', IDUsuario = " + senha.IDUsuario +
                    " where IDSenha = " + senha.IDSenha;
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
        public Senha ChamarSenha()
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "if (select count(*) from Senha where EstadoSenha = 'Nova' and TipoSenha = 'Preferencial')>0"+
                    "select top 1 * from Senha where EstadoSenha = 'Nova' and TipoSenha = 'Preferencial';" +
                    "else select top 1 * from Senha where EstadoSenha = 'Nova';";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Senha> senhaList = new List<Senha>();
                Senha senha;

                while (reader.Read())
                {
                    senha = new Senha();

                    if (!reader["Atendido"].ToString().Equals("")){
                        senha.Atendido = DateTime.Parse(reader["Atendido"].ToString());
                    }
                    if (!reader["Criacao"].ToString().Equals(""))
                    {
                        senha.Criacao = DateTime.Parse(reader["Criacao"].ToString());
                    }
                    if (!reader["Resolvido"].ToString().Equals(""))
                    {
                        senha.Resolvido = DateTime.Parse(reader["Resolvido"].ToString());
                    }
                    
                    senha.Criacao = (DateTime)reader["Criacao"];
                    senha.EstadoSenha = (String)reader["EstadoSenha"];
                    senha.Guiche = (Int32)reader["Guiche"];
                    senha.IDSenha = (Int32)reader["IDSenha"];
                    senha.TipoSenha = (String)reader["TipoSenha"];
                    senha.IDUsuario = (Int32)reader["IDUsuario"];
                    senhaList.Add(senha);
                }

                return senhaList[0];
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
        public Senha MostarProximaSenha()
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "select top 1 * from Senha where EstadoSenha = 'Em Atendimento'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Senha> senhaList = new List<Senha>();
                Senha senha;

                while (reader.Read())
                {
                    senha = new Senha();

                    if (!reader["Atendido"].ToString().Equals(""))
                    {
                        senha.Atendido = DateTime.Parse(reader["Atendido"].ToString());
                    }
                    if (!reader["Criacao"].ToString().Equals(""))
                    {
                        senha.Criacao = DateTime.Parse(reader["Criacao"].ToString());
                    }
                    if (!reader["Resolvido"].ToString().Equals(""))
                    {
                        senha.Resolvido = DateTime.Parse(reader["Resolvido"].ToString());
                    }

                    senha.Criacao = (DateTime)reader["Criacao"];
                    senha.EstadoSenha = (String)reader["EstadoSenha"];
                    senha.Guiche = (Int32)reader["Guiche"];
                    senha.IDSenha = (Int32)reader["IDSenha"];
                    senha.TipoSenha = (String)reader["TipoSenha"];
                    senha.IDUsuario = (Int32)reader["IDUsuario"];
                    senhaList.Add(senha);
                }

                return senhaList[0];
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
        public Senha BuscarSenha(Senha senha)
        {
            SqlConnection connection = null;
            try
            {
                connection = Fabrica.NewConnection();
                connection.Open();
                String query = "select top 1 * from Senha where EstadoSenha = 'Nova' order by IDSenha desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    senha = new Senha();

                    if (!reader["Atendido"].ToString().Equals(""))
                    {
                        senha.Atendido = DateTime.Parse(reader["Atendido"].ToString());
                    }
                    if (!reader["Criacao"].ToString().Equals(""))
                    {
                        senha.Criacao = DateTime.Parse(reader["Criacao"].ToString());
                    }
                    if (!reader["Resolvido"].ToString().Equals(""))
                    {
                        senha.Resolvido = DateTime.Parse(reader["Resolvido"].ToString());
                    }

                    senha.EstadoSenha = (String)reader["EstadoSenha"];
                    senha.Guiche = (Int32)reader["Guiche"];
                    senha.IDSenha = (Int32)reader["IDSenha"];
                    senha.TipoSenha = (String)reader["TipoSenha"];
                    senha.IDUsuario = (Int32)reader["IDUsuario"];
                }

                return senha;
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
    }
}
