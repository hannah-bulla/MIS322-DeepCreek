using Microsoft.Data.SqlClient;
using System.IO;

namespace DeepCreekLLC.Database
{
    public static class DbReset
    {
        public static void ResetDatabase()
        {
            
        //    using (SqlConnection sqlConnection = new
        //        SqlConnection(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DeepCreekDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
        //    {
        //        sqlConnection.Open();
        //        sqlConnection.ChangeDatabase("master");

        //        string rollbackCommand = @"ALTER DATABASE DeepCreekDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
        //        SqlCommand deleteCommand = new SqlCommand(rollbackCommand, sqlConnection);
        //        deleteCommand.ExecuteNonQuery();

        //        string dropCommand = @"DROP DATABASE DeepCreekDB";
        //        deleteCommand = new SqlCommand(dropCommand, sqlConnection);
        //        deleteCommand.ExecuteNonQuery();

        //    }

            //    string scriptPath = Path.Combine(
            //        AppDomain.CurrentDomain.BaseDirectory, "ResetDb.sql");

            //if (!File.Exists(scriptPath))
            //    throw new FileNotFoundException($"Reset script not found at:\n{scriptPath}");

            //string fullScript = File.ReadAllText(scriptPath);
            //string[] batches = fullScript.Split(
            //    new[] { "\r\nGO", "\nGO", "\r\ngo", "\ngo" },
            //    StringSplitOptions.RemoveEmptyEntries);

            //using var conn = new SqlConnection(sqlConnection);
            //conn.Open();
            //foreach (var batch in batches)
            //{
            //    string trimmed = batch.Trim();
            //    if (string.IsNullOrWhiteSpace(trimmed)) continue;

            //    using var cmd = new SqlCommand(trimmed, conn);
            //    cmd.CommandTimeout = 60;
            //    cmd.ExecuteNonQuery();
            //}
        }
    }
}