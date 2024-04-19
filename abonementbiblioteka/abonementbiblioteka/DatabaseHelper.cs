using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace abonementbiblioteka
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Data Source =DESKTOP-N4PCSV6; Initial Catalog = biblioteka; Integrated Security = True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Other methods for working with the database, such as executing queries or updates
    }

}
