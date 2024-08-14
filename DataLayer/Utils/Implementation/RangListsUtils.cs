using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer.Utils.Implementation
{
    public class RangListsUtils
    {
        public void ReadParsedNames() {
            string pathRead = Constants.Constants.PARSED_FAV_PLAYER_NAMES;
            object fileLock = new object();

            lock (fileLock)
            {
                if (File.Exists(pathRead))
                {
                    using (StreamReader sr = new StreamReader(pathRead))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {

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
    }
}
