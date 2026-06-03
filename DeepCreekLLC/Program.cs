using DeepCreekLLC.Database;

namespace DeepCreekLLC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

#if DEBUG
            // Reset the database every time the app runs in Debug mode
            try
            {
                DbReset.ResetDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB reset failed:\n{ex.Message}",
                    "Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
#endif

            Application.Run(new MainMenu());
        }
    }
}