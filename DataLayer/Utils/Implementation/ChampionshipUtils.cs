using DataLayer.Utils.Interface;
using System.Globalization;

namespace DataLayer.Utils.Implementation
{
    public class ChampionshipUtils : IFileHandler
    {
        private readonly SelectGenderLanguageUtils _genderLanguageUtils;

        public string? NationalTeam { get; set; }

        public ChampionshipUtils(SelectGenderLanguageUtils genderLanguageUtils)
        {
            _genderLanguageUtils = genderLanguageUtils;
        }

        public void FileWriter(ComboBox comboBox, Label label = null)
        {
            string filePath = Constants.Constants.TXT_FILE_PATH;
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
        public string FileReader()
        {
            string contains = "";
            bool nationalTeamExists = FileReaderChecker("National", "Reprezentacija: ", ref contains);
            try
            {
                if (nationalTeamExists)
                {
                    NationalTeam = contains;
                    return NationalTeam;
                }
                else
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File doesn't have sufficient information.");
            }

            return "";

        }
        private static bool FileReaderChecker(string txtFileLine1, string txtFileLine2, ref string contains)
        {
            object fileLock = new();
            string filePath = Constants.Constants.TXT_FILE_PATH;
            lock (fileLock)
            {
                using (StreamReader sw = new(filePath))
                {
                    if (File.Exists(filePath))
                    {
                        var linesRead = File.ReadLines(filePath);

                        foreach (var line in linesRead)
                        {
                            if (line.Contains(txtFileLine1) || line.Contains(txtFileLine2))
                            {
                                contains = line;
                                return true;
                            }

                        }

                    }

                }

            }

            return false;
        }
    }
}
