using DataLayer;
using System.Globalization;

namespace WFapp
{
    internal static class Program
    {
        private static readonly SelectGenderLanguageUtils genderLanguageDependency = new();
        private static readonly ChampionshipUtils championshipUtilsDependency = new(new HttpClient());
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new InitialForm(genderLanguageDependency, championshipUtilsDependency));
        }
    }
}