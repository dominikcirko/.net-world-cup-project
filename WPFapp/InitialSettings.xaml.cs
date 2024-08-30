using DataLayer;
using DataLayer.Constants;
using DataLayer.Utils.Implementation;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Resources;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace WPFapp
{
    public partial class InitialSettings : Window
    {
        private readonly SelectGenderLanguageUtils _genderLanguageUtils;
        private readonly ChampionshipUtils _championshipUtils;
        private readonly NationalTeamUtils _nationalTeamUtils;
        private bool _isFullscreen = false;

        public InitialSettings(SelectGenderLanguageUtils genderLanguageUtils, ChampionshipUtils championshipUtils, NationalTeamUtils nationalTeamUtils)
        {
            InitializeComponent();
            _genderLanguageUtils = genderLanguageUtils;
            _championshipUtils = championshipUtils;
            _nationalTeamUtils = nationalTeamUtils;
            cbChampionship.MaxDropDownHeight = 100;
            btnBack.IsEnabled = false;
            this.Loaded += InitialSettings_Loaded;
        }
        private void LoadPreviousSettings()
        {
            _genderLanguageUtils.FileReader();
            _championshipUtils.FileReader();
            btnBack.IsEnabled = false;
            btnCroatian.IsEnabled = false;
            btnEnglish.IsEnabled = false;
            cbChampionship.IsEnabled = false;
            btnMale.IsEnabled = false;
            btnFemale.IsEnabled = false;

            string previousSettings = $"Championship: {_genderLanguageUtils.Championship}\nLanguage: {_genderLanguageUtils.Language}\nNational team: {_championshipUtils.NationalTeam}";

            MessageBoxResult result = MessageBox.Show($"Do you want to load the previous configuration?\n\n{previousSettings}", "Use Previous Configuration", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var nationalTeamsWindow = new NationalTeamsWindow(_championshipUtils);
                nationalTeamsWindow.Show();
                this.Close();
            }
            else
            {
                btnBack.IsEnabled = true;
                btnCroatian.IsEnabled = true;
                btnEnglish.IsEnabled = true;
                cbChampionship.IsEnabled = true;
                btnMale.IsEnabled = true;
                btnFemale.IsEnabled = true;
            }
        }

        private void InitialSettings_Loaded(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.InvokeAsync(() => LoadPreviousSettings(), DispatcherPriority.ContextIdle);
        }

        private async void btnFemale_Click(object sender, RoutedEventArgs e)
        {
            await PopulateChampionshipComboBoxAsync(Constants.WORLD_CUP_WOMEN);
            _genderLanguageUtils.SelectedGenderItem = SelectGenderLanguageUtils.ComboBoxItems.female;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private async void btnMale_Click(object sender, RoutedEventArgs e)
        {
            await PopulateChampionshipComboBoxAsync(Constants.WORLD_CUP_MEN);
            _genderLanguageUtils.SelectedGenderItem = SelectGenderLanguageUtils.ComboBoxItems.male;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void btnEnglish_Click(object sender, RoutedEventArgs e)
        {
            GetLanguage("en", "WPFapp.Resources");
            _genderLanguageUtils.SelectedLanguageItem = SelectGenderLanguageUtils.ComboBoxItems.english;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void btnCroatian_Click(object sender, RoutedEventArgs e)
        {
            GetLanguage("hr-HR", "WPFapp.Resources");
            _genderLanguageUtils.SelectedLanguageItem = SelectGenderLanguageUtils.ComboBoxItems.croatian;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void GenderLanguageErrHandler(SelectGenderLanguageUtils sju)
        {
            try
            {
                sju.FileWriter();
            }
            catch (FileNotFoundException)
            {
                string culture = CultureInfo.CurrentCulture.ToString();
                switch (culture)
                {
                    case "en":
                        lblErrMsg.Content = "File doesn't exist. Enter championship and language again.";
                        break;
                    case "hr-HR":
                        lblErrMsg.Content = "Datoteka ne postoji. Ponovno unesite prvenstvo i jezik.";
                        break;
                }
            }
        }

        private void GetLanguage(string lang, string baseName)
        {
            var culture = new CultureInfo(lang);

            var resourceManager = new ResourceManager(baseName, typeof(InitialSettings).Assembly);

            var resourceSet = resourceManager.GetResourceSet(culture, true, true);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            try
            {
                btnFemale.Content = resourceSet.GetString("btnFemale.Content");
                btnMale.Content = resourceSet.GetString("btnMale.Content");
                btnEnglish.Content = resourceSet.GetString("btnEnglish.Content");
                btnCroatian.Content = resourceSet.GetString("btnCroatian.Content");
                lblGender.Content = resourceSet.GetString("lblGender.Content");
                lblLanguage.Content = resourceSet.GetString("lblLanguage.Content");
                lblNationalTeam.Content = resourceSet.GetString("lblNationalTeam.Content");
                btnExit.Content = resourceSet.GetString("btnExit.Content");
                btnNext.Content = resourceSet.GetString("btnNext.Content");
                btnBack.Content = resourceSet.GetString("btnBack.Content");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error status code: " + ex.Message);
            }
        }

        private async Task PopulateChampionshipComboBoxAsync(string requestUri)
        {
            JsonDeserializer jsonDeserializer = new(new HttpClient());
            Championship[] championships = await jsonDeserializer.DeserializeFromAPI<Championship>(requestUri);
            foreach (var championship in championships)
            {
                cbChampionship.Items.Add($"{championship.country} ({championship.fifa_code})");
            }
        }

        private void cbChampionship_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                this.FileWriter(cbChampionship);
            }
            catch (FileNotFoundException ex)
            {
                string culture = CultureInfo.CurrentCulture.ToString();

                switch (culture)
                {
                    case "en":
                        MessageBox.Show("File not found. Error message: " + ex.Message);
                        break;
                    case "hr-HR":
                        MessageBox.Show("Datoteka nije pronađena. Ispis greške: " + ex.Message);
                        break;
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog;
            string culture = CultureInfo.CurrentCulture.ToString();
            switch (culture)
            {
                case "en":
                    dialog = MessageBox.Show("Do you want to close the application?", "Alert!", MessageBoxButton.YesNo);
                    break;
                case "hr-HR":
                    dialog = MessageBox.Show("Želite li izaći iz aplikacije?", "Pozor!", MessageBoxButton.YesNo);
                    break;
                default:
                    dialog = MessageBoxResult.No;
                    break;
            }
            if (dialog == MessageBoxResult.Yes) Application.Current.Shutdown();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog;
            try
            {
                _genderLanguageUtils.FileReader();
                _championshipUtils.FileReader();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File not found. Error message: " + ex.Message);
            }
            string culture = CultureInfo.CurrentCulture.ToString();
            switch (culture)
            {
                case "en":
                    dialog = MessageBox.Show(_genderLanguageUtils.Language + "\n" + _genderLanguageUtils.Championship + "\n" + _championshipUtils.NationalTeam,
                "Data you selected",
                MessageBoxButton.OKCancel);
                    break;
                case "hr-HR":
                    dialog = MessageBox.Show(_genderLanguageUtils.Language + "\n" + _genderLanguageUtils.Championship + "\n" + _championshipUtils.NationalTeam,
                "Podaci koje ste odabrali",
                MessageBoxButton.OKCancel);
                    break;
                default:
                    dialog = MessageBoxResult.Cancel;
                    break;
            }
            if (dialog == MessageBoxResult.OK)
            {
                var nationalTeamsWindow = new NationalTeamsWindow(_championshipUtils);
                nationalTeamsWindow.Show();
                this.Close();
            }
        }

        private void FileWriter(ComboBox comboBox, Label label = null)
        {
            string filePath = Constants.TXT_FILE_PATH;
            using (StreamWriter sw = new(filePath, true))
            {
                string culture = CultureInfo.CurrentCulture.ToString();
                if (File.Exists(filePath))
                {
                    _genderLanguageUtils.LanguageHelper(sw,
                        culture,
                        "National team: " + comboBox.SelectedItem.ToString(),
                        "Reprezentacija: " + comboBox.SelectedItem.ToString());
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}