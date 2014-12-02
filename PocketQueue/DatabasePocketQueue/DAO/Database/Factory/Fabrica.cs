using System;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DatabasePocketQueue.DAO.Database.Factory
{
    static class Fabrica
    {

        private static string ConnectionString = "Server=192.168.25.50;Database=PocketQueue;User Id=SQLAdmin;Password=123456;";
        public static SqlConnection NewConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
