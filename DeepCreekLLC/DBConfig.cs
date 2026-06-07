using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCreekLLC.Database
{
    public static class DbConfig
    {
        // Change "localhost" to your actual server name from SSMS
        private const string ConnectionString =
            "Server=(MSI)\\NEWSQLSERVER;Database=DeepCreekDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}