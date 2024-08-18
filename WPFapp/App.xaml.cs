using DataLayer.Utils.Implementation;
using System.Windows;

namespace WPFapp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Check if the necessary settings are already saved
            string savedResolution = WpfAppSettings.Default.Resolution;
                // Settings are not configured, show the SettingsWindow
            ShowSettingsWindow();

        }

        private void ShowSettingsWindow()
        {
            var genderLanguageUtils = new SelectGenderLanguageUtils();
            var championshipUtils = new ChampionshipUtils(genderLanguageUtils);
            var nationalTeamUtils = new NationalTeamUtils();

            var settingsWindow = new SettingsWindow(genderLanguageUtils, championshipUtils, nationalTeamUtils);
            settingsWindow.Show();
        }


    }
}