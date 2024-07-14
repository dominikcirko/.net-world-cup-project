using DataLayer.Utils.Interface;
using System.Globalization;

namespace DataLayer.Utils.Implementation
{
    public class SelectGenderLanguageUtils : IFileHandler
    {

        public ComboBoxItems SelectedGenderItem { get; set; }
        public ComboBoxItems SelectedLanguageItem { get; set; }

        private readonly object fileLock = new();

        public string? Championship { get; set; }
        public string? Language { get; set; }

        public string FileReader()
        {
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
                            if (line.StartsWith("Championship:") || line.StartsWith("Prvenstvo: "))
                                Championship = line;
                            else if (line.StartsWith("Language:") || line.StartsWith("Jezik: "))
                                Language = line;
                        }
                    }
                }
            }
            return "";
        }
        public void FileWriter(ComboBox comboBox = null, Label label = null)
        {
            string culture = CultureInfo.CurrentCulture.ToString();

            string relativePath = "info.txt";
            lock (fileLock)
            {
                using (StreamWriter sw = new(relativePath))
                {
                    if (File.Exists(relativePath))
                    {

                        switch (SelectedGenderItem)
                        {
                            case ComboBoxItems.female:
                                LanguageHelper(sw, culture, "Championship: female", "Prvenstvo: žensko");
                                break;
                            case ComboBoxItems.male:
                                LanguageHelper(sw, culture, "Championship: male", "Prvenstvo: muško");
                                break;

                        }
                        switch (SelectedLanguageItem)
                        {
                            case ComboBoxItems.croatian:
                                LanguageHelper(sw, culture, "Language: Croatian", "Jezik: Hrvatski");
                                break;
                            case ComboBoxItems.english:
                                LanguageHelper(sw, culture, "Language: English", "Jezik: Engleski");
                                break;
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }

                }
            }
        }

        public enum ComboBoxItems
        {
            female, male, croatian, english
        }

        public void LanguageHelper(StreamWriter sw, string culture, string english, string croatian)
        {
            switch (culture)
            {
                case "en":
                    sw.WriteLine(english);
                    break;
                case "hr-HR":
                    sw.WriteLine(croatian);
                    break;
            }
        }


    }
}
