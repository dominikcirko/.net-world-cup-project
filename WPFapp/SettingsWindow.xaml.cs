using DataLayer.Utils.Implementation;
using System.Windows;

namespace WPFapp
{
    public partial class SettingsWindow : Window
    {
        private readonly SelectGenderLanguageUtils _genderLanguageUtils;
        private readonly ChampionshipUtils _championshipUtils;
        private readonly NationalTeamUtils _nationalTeamUtils;
        public SettingsWindow(SelectGenderLanguageUtils genderLanguageUtils, ChampionshipUtils championshipUtils, NationalTeamUtils nationalTeamUtils)
        {
            InitializeComponent();
            _genderLanguageUtils = genderLanguageUtils;
            _championshipUtils = championshipUtils;
            _nationalTeamUtils = nationalTeamUtils;
        }

        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            string selectedResolution = GetSelectedResolution();

            WpfAppSettings.Default.Resolution = selectedResolution;
            WpfAppSettings.Default.Save(); 

            ApplyResolution(selectedResolution);
            this.Close();
        }

        private string GetSelectedResolution()
        {
            if (rb1024x768.IsChecked == true)
                return "1024x768";
            if (rb1280x720.IsChecked == true)
                return "1280x720";
            if (rb1920x1080.IsChecked == true)
                return "1920x1080";
            if (rbDefault.IsChecked == true)
                return "Fullscreen";

            return "1280x720";
        }

        private void ApplyResolution(string resolution)
        {
            InitialSettings mainWindow = new(_genderLanguageUtils, _championshipUtils, _nationalTeamUtils);
            switch (resolution)
            {
                case "1024x768":
                    mainWindow.Width = 1024;
                    mainWindow.Height = 768;
                    mainWindow.WindowState = WindowState.Normal;
                    break;
                case "1280x720":
                    mainWindow.Width = 1280;
                    mainWindow.Height = 720;
                    mainWindow.WindowState = WindowState.Normal;
                    break;
                case "1920x1080":
                    mainWindow.Width = 1920;
                    mainWindow.Height = 1080;
                    mainWindow.WindowState = WindowState.Normal;
                    break;
            }

            mainWindow.Show();
        }
    }
}
