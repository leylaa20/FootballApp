namespace FootballApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());

            }
            catch (Exception) { MessageBox.Show("Progma gel"); }
        }
    }
}