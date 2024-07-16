using DataLayer.Utils.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Constants;

using static DataLayer.Utils.Implementation.SelectGenderLanguageUtils;
using Microsoft.VisualBasic;
using System.Collections.Specialized;
using System.Reflection;

namespace DataLayer.Utils.Implementation
{
    public class NationalTeamUtils
    {
        private readonly object fileLock = new();


        public void FavoritePlayersFileWriter(ListBox lb)
        {
            string culture = CultureInfo.CurrentCulture.ToString();

            string path = Constants.Constants.FAV_PLAYER_NAMES;
            lock (fileLock)
            {
                using (StreamWriter sw = new(path, true))
                {
                    if (File.Exists(path))
                    {
                        sw.WriteLine();
                        LanguageHelper(sw, culture, "Favorite players: ", "Omiljeni igraci: ");
                        foreach (var item in lb.Items)
                        {
                            string itemString = item.ToString();
                            sw.WriteLine(itemString);                            
                        }
                    }
                    else
                        throw new FileNotFoundException();
                }
            }
        }

        public void ParsePlayerNamesFromFile()
        {
            string pathRead = Constants.Constants.FAV_PLAYER_NAMES;
            string pathWrite = Constants.Constants.PARSED_FAV_PLAYER_NAMES;
            object fileLock = new object();

            lock (fileLock)
            {
                if (File.Exists(pathRead))
                {
                    using (StreamReader sr = new StreamReader(pathRead))
                    {
                        using (StreamWriter sw = new StreamWriter(pathWrite))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                int index = line.IndexOf('|');
                                if (index != -1)
                                {
                                    string name = line.Substring(0, index);
                                    sw.WriteLine(name); //write parsed names to pathWrite
                                }
                            }
                        }
                    }
                    File.WriteAllText(pathRead, string.Empty);
                }
                else
                {
                    throw new FileNotFoundException($"File not found: {pathRead}");
                }
            }
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
