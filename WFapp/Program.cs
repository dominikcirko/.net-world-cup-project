using DataLayer.Utils.Implementation;
using System.Globalization;
using WFapp.UserControls;

namespace WFapp
{
    internal static class Program
    {
        //dodati factory pattern umjesto da radim objekte ovdje
        private static readonly SelectGenderLanguageUtils genderLanguageDependency = new();
        private static readonly ChampionshipUtils championshipUtilsDependency = new(genderLanguageDependency);
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