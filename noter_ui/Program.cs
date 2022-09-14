namespace noter_ui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string directory = Directory.GetCurrentDirectory() + "/notes";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            Directory.SetCurrentDirectory(directory);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Mode());
        }
    }
}