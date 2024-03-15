using DataLayer;

namespace WFapp
{
    internal static class Program
    {
        private static readonly SelectGenderLanguageUtils genderLanguageDependency = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new InitialForm(genderLanguageDependency));
        }
    }
}