using DataLayer;
using System.Globalization;
using System.Resources;

namespace WFapp
{
    public partial class InitialForm : Form
    {
        private readonly SelectGenderLanguageUtils _genderLanguageUtils;
        private readonly ChampionshipUtils _campionshipUtils;

        public InitialForm(SelectGenderLanguageUtils genderLanguageUtils, ChampionshipUtils campionshipUtils)
        {
            InitializeComponent();
            _genderLanguageUtils = genderLanguageUtils;
            _campionshipUtils = campionshipUtils;
        }

        private async void btnFemale_Click(object sender, EventArgs e)
        {
             await PopulateChampionshipComboBoxAsync("https://worldcup-vua.nullbit.hr/women/teams/results");
            _genderLanguageUtils.SelectedButtonGender = SelectGenderLanguageUtils.Buttons.female;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }
        private async void btnMale_Click(object sender, EventArgs e)
        {
            await PopulateChampionshipComboBoxAsync("https://worldcup-vua.nullbit.hr/men/teams/results");
            _genderLanguageUtils.SelectedButtonGender = SelectGenderLanguageUtils.Buttons.male;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            GetLanguage("en");
            _genderLanguageUtils.SelectedButtonLanguage = SelectGenderLanguageUtils.Buttons.english;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void btnCroatian_Click(object sender, EventArgs e)
        {
            GetLanguage("hr-HR");
            _genderLanguageUtils.SelectedButtonLanguage = SelectGenderLanguageUtils.Buttons.croatian;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }
        private void GenderLanguageErrHandler(SelectGenderLanguageUtils sju)
        {
            try
            {
                sju.SelectGenderLanguage();
            }
            catch (FileNotFoundException)
            {
                string culture = CultureInfo.CurrentCulture.ToString();
                switch (culture)
                {
                    case "en":
                        labelErrMsg.Text = "File doesn't exist. Enter championship and language again.";
                        break;
                    case "hr-HR":
                        labelErrMsg.Text = "Datoteka ne postoji. Ponovno unesite prvenstvo i jezik.";
                        break;
                    default:
                        break;
                }
                labelErrMsg.ForeColor = Color.Red;
            }
        }

        public void GetLanguage(string lang)
        {
            var culture = new CultureInfo(lang);

            var resourceManager = new ResourceManager("WFapp.InitialForm", typeof(InitialForm).Assembly);

            var resourceSet = resourceManager.GetResourceSet(culture, true, true);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            try
            {
                btnFemale.Text = resourceSet.GetString("btnFemale.Text");
                btnMale.Text = resourceSet.GetString("btnMale.Text");
                btnEnglish.Text = resourceSet.GetString("btnEnglish.Text");
                btnCroatian.Text = resourceSet.GetString("btnCroatian.Text");
                lblGender.Text = resourceSet.GetString("lblGender.Text");
                lblLanguage.Text = resourceSet.GetString("lblLanguage.Text");
                lblNationalTeam.Text = resourceSet.GetString("lblNationalTeam.Text");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private async Task PopulateChampionshipComboBoxAsync(string requestUri)
        {
            var championships = await _campionshipUtils.Deserialize(requestUri);
            foreach (var championship in championships)
            {
                cbChampionship.Items.Add(championship.country + " (" + championship.fifa_code +")");
            }
        }
        private void cbChampionship_SelectedIndexChanged(object sender, EventArgs e)
        {
            _campionshipUtils.SaveChampionshipToTxt(cbChampionship);
        }
    }
}
