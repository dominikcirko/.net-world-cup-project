namespace DataLayer
{
    public class SelectGenderLanguageUtils
    {

        public Buttons SelectedButtonGender { get; set; }
        public Buttons SelectedButtonLanguage { get; set; }
        public void SelectGenderLanguage()
        {

            string relativePath = "info.txt";
            using (StreamWriter sw = new(relativePath))
            {
                if (File.Exists(relativePath))
                {

                    switch (SelectedButtonGender)
                    {
                        case Buttons.female:
                            sw.WriteLine("Gender: female");
                            break;
                        case Buttons.male:
                            sw.WriteLine("Gender: male");
                            break;

                    }
                    switch (SelectedButtonLanguage)
                    {
                        case Buttons.croatian:
                            sw.WriteLine("Language: Croatian");
                            break;
                        case Buttons.english:
                            sw.WriteLine("Language: English");
                            break;
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }

            }

        }

        public enum Buttons
        {
            female, male, croatian, english
        }

    }
}
