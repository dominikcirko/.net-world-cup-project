using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utils.Interface
{
    public interface IFileHandler
    {
        public string FileReader();
        public void FileWriter(ComboBox comboBox = null, Label label = null);
    }
}
