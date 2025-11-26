using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroprojetoti48
{
    public static class ConnBD
    {
        private static string connectionString = @"Server=.\BDSENAC;Database=AgendaDB;User Id=senaclivre;Password=senaclivre;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
