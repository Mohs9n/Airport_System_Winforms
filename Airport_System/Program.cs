using Airport_System.Entities;
using System.Text;
using System.Text.Unicode;

namespace Airport_System
{
    internal static class Program
    {
        public static Data data = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}