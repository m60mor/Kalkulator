using System.Globalization;

namespace Kalkulator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            CultureInfo culture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentCulture = culture;
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}