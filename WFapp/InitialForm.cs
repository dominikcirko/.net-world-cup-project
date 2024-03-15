using DataLayer;
using System.Globalization;
using System.Resources;

namespace WFapp
{
    public partial class InitialForm : Form
    {
        private readonly SelectGenderLanguageUtils _genderLanguageUtils;

        public InitialForm(SelectGenderLanguageUtils genderLanguageUtils)
        {
            InitializeComponent();
            _genderLanguageUtils = genderLanguageUtils;
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            _genderLanguageUtils.SelectedButtonGender = SelectGenderLanguageUtils.Buttons.female;
            ErrHandler(_genderLanguageUtils);
        }
        private void btnMale_Click(object sender, EventArgs e)
        {
            _genderLanguageUtils.SelectedButtonGender = SelectGenderLanguageUtils.Buttons.male;
            ErrHandler(_genderLanguageUtils);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            GetLanguage("en");
            _genderLanguageUtils.SelectedButtonLanguage = SelectGenderLanguageUtils.Buttons.english;
            ErrHandler(_genderLanguageUtils);
        }

        private void btnCroatian_Click(object sender, EventArgs e)
        {
            GetLanguage("hr-HR");
            _genderLanguageUtils.SelectedButtonLanguage = SelectGenderLanguageUtils.Buttons.croatian;
            ErrHandler(_genderLanguageUtils);
        }
        private void ErrHandler(SelectGenderLanguageUtils sju)
        {
            try
            {
                sju.SelectGenderLanguage();
            }
            catch (FileNotFoundException)
            {
                labelErrMsg.Text = "Datoteka ne postoji. Ponovno unesite prvenstvo i jezik.";
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
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
