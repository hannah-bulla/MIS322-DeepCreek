using Microsoft.Data.SqlClient;
using System.IO;

namespace DeepCreekLLC.Database
{
    public static class DbReset
    {
        public static void ResetDatabase()
        {
            // Establishes master connection string
            string masterConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection sqlConnection = new SqlConnection(masterConnectionString))
            {
                sqlConnection.Open();

                string rollbackCommand = @"ALTER DATABASE DeepCreekDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                using (SqlCommand cmd = new SqlCommand(rollbackCommand, sqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }

                string dropCommand = @"DROP DATABASE DeepCreekDB";
                using (SqlCommand cmd = new SqlCommand(dropCommand, sqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            //Locates the setup SQL initialization script
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ResetDb.sql");

            if (!File.Exists(scriptPath))
                throw new FileNotFoundException($"Reset script not found at:\n{scriptPath}");

            string fullScript = File.ReadAllText(scriptPath);

            // Splits the script safely by SQL Server 'GO' batch parameters
            string[] batches = fullScript.Split(
                new[] { "\r\nGO\r\n", "\nGO\n", "\r\ngo\r\n", "\ngo\n", "\r\nGO", "\nGO" },
                StringSplitOptions.RemoveEmptyEntries);

            // 3. Connect back to Master to run the creation script (Script must contain "CREATE DATABASE DeepCreekDB")
            using (SqlConnection conn = new SqlConnection(masterConnectionString))
            {
                conn.Open();
                foreach (var batch in batches)
                {
                    string trimmed = batch.Trim();
                    if (string.IsNullOrWhiteSpace(trimmed)) continue;

                    using (SqlCommand cmd = new SqlCommand(trimmed, conn))
                    {
                        cmd.CommandTimeout = 60;
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }
    }
}