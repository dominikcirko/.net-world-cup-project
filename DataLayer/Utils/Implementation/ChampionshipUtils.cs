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

        public void FileWriter(ComboBox comboBox)
        {
            string relativePath = "info.txt";
            using (StreamWriter sw = new(relativePath, true))
            {
                string culture = CultureInfo.CurrentCulture.ToString();
                if (File.Exists(relativePath))
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
        public static bool FileReaderChecker(string txtFileLine1, string txtFileLine2, ref string contains)
        {
            object fileLock = new();
            string relativePath = "info.txt";
            lock (fileLock)
            {
                using (StreamReader sw = new(relativePath))
                {
                    if (File.Exists(relativePath))
                    {
                        var linesRead = File.ReadLines(relativePath);

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
