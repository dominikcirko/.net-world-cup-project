using DataLayer;
using DataLayer.Constants;
using DataLayer.Utils.Implementation;
using System.Globalization;
using System.Resources;
using System.Text.RegularExpressions;
using WFapp.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WFapp
{
    public partial class InitialForm : Form
    {
        private readonly SelectGenderLanguageUtils _genderLanguageUtils;
        private readonly ChampionshipUtils _championshipUtils;
        public InitialForm(SelectGenderLanguageUtils genderLanguageUtils, ChampionshipUtils campionshipUtils)
        {
            InitializeComponent();
            _genderLanguageUtils = genderLanguageUtils;
            _championshipUtils = campionshipUtils;
            cbChampionship.MaxDropDownItems = 2;
            btnBack.Enabled = false;
        }
        public Panel GetPnlInitialSettings() { return pnlInitialSettings; }
        public ComboBox GetCbChampionship() { return cbChampionship; }
        private async void btnFemale_Click(object sender, EventArgs e)
        {
            await PopulateChampionshipComboBoxAsync(Constants.WORLD_CUP_WOMEN);
            _genderLanguageUtils.SelectedGenderItem = SelectGenderLanguageUtils.ComboBoxItems.female;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }
        private async void btnMale_Click(object sender, EventArgs e)
        {
            await PopulateChampionshipComboBoxAsync(Constants.WORLD_CUP_MEN);
            _genderLanguageUtils.SelectedGenderItem = SelectGenderLanguageUtils.ComboBoxItems.male;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            GetLanguage("en", "WFapp.InitialForm");
            _genderLanguageUtils.SelectedLanguageItem = SelectGenderLanguageUtils.ComboBoxItems.english;
            GenderLanguageErrHandler(_genderLanguageUtils);
        }

        private void btnCroatian_Click(object sender, EventArgs e)
        {
            GetLanguage("hr-HR", "WFapp.InitialForm");
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
                        lblErrMsg.Text = "File doesn't exist. Enter championship and language again.";
                        break;
                    case "hr-HR":
                        lblErrMsg.Text = "Datoteka ne postoji. Ponovno unesite prvenstvo i jezik.";
                        break;
                }
                lblErrMsg.ForeColor = Color.Red;
            }
        }

        private void GetLanguage(string lang, string baseName)
        {
            var culture = new CultureInfo(lang);

            var resourceManager = new ResourceManager(baseName, typeof(InitialForm).Assembly);

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
                btnExit.Text = resourceSet.GetString("btnExit.Text");
                btnNext.Text = resourceSet.GetString("btnNext.Text");
                btnBack.Text = resourceSet.GetString("btnBack.Text");
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
                cbChampionship.Items.Add(championship.country + " (" + championship.fifa_code + ")");
            }
        }
        private void cbChampionship_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _championshipUtils.FileWriter(cbChampionship);
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
                        MessageBox.Show("Datoteka nije pronaðena. Ispis greške: " + ex.Message);
                        break;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new();
            string culture = CultureInfo.CurrentCulture.ToString();
            switch (culture)
            {
                case "en":
                    dialog = MessageBox.Show("Do you want to close the application?", "Alert!", MessageBoxButtons.YesNo);
                    break;
                case "hr-HR":
                    dialog = MessageBox.Show("Želite li izaæi iz aplikacije?", "Pozor!", MessageBoxButtons.YesNo);
                    break;
            }
            if (dialog == DialogResult.Yes) Environment.Exit(1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new();
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
                MessageBoxButtons.OKCancel);
                    break;
                case "hr-HR":
                    dialog = MessageBox.Show(_genderLanguageUtils.Language + "\n" + _genderLanguageUtils.Championship + "\n" + _championshipUtils.NationalTeam,
                "Podaci koje ste odabrali",
                MessageBoxButtons.OKCancel);
                    break;
            }

            switch (dialog)
            {
                case DialogResult.OK:
                    NationalTeamControl nationalTeamControl = new(this);
                    this.Controls.Add(nationalTeamControl);
                    nationalTeamControl.Dock = DockStyle.Fill;
                    nationalTeamControl.GetPnlFavoritePlayers().Visible = true;
                    pnlInitialSettings.Visible = false;
                    break;

            }
        }



        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlInitialSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
