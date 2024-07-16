using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utils.Implementation
{
    public class PlayerPicturesUtils
    {

        public void MapParsedNamesToLabels(Label favPlayer1, Label favPlayer2, Label favPlayer3)
        {
            string pathRead = Constants.Constants.PARSED_FAV_PLAYER_NAMES;
            object fileLock = new object();
            lock (fileLock)
            {
                if (File.Exists(pathRead))
                {
                    using (StreamReader sr = new StreamReader(pathRead))
                    {
                        favPlayer1.Text = sr.ReadLine();
                        favPlayer2.Text = sr.ReadLine();
                        favPlayer3.Text = sr.ReadLine();
                    }
                    File.WriteAllText(pathRead, string.Empty);
                }
                else
                {
                    throw new FileNotFoundException($"File not found: {pathRead}");
                }
            }


        }

    }
}
