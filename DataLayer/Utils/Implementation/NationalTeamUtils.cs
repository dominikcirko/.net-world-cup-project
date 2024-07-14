﻿using DataLayer.Utils.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Constants;

using static DataLayer.Utils.Implementation.SelectGenderLanguageUtils;
using Microsoft.VisualBasic;

namespace DataLayer.Utils.Implementation
{
    public class NationalTeamUtils
    {
        private readonly object fileLock = new();


        public void FileWriter(ListBox lb)
        {
            string culture = CultureInfo.CurrentCulture.ToString();

            string relativePath = Constants.Constants.TXT_FILE_PATH;
            lock (fileLock)
            {
                using (StreamWriter sw = new(relativePath, true))
                {
                    if (File.Exists(relativePath))
                    {
                        int num = 0;
                        sw.WriteLine();
                        LanguageHelper(sw, culture, "Favorite players: ", "Omiljeni igraci: ");
                        foreach (var item in lb.Items)
                        {
                            num++;
                            string itemString = item.ToString();
                            sw.WriteLine(itemString);
                            
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }

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
