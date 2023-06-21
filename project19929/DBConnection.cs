using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project19929
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pogi0\OneDrive\Desktop\project19929\MenuDB.mdf;Integrated Security=True;Connect Timeout=30";
            return new SqlConnection(connectionString);
        }
    }
}
