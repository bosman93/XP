using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class DataManager
    {
        StringBuilder csv = new StringBuilder();

        String first = "a";
        String second = "b";
        public void saveData()
        {
            String newLine = string.Format("{0},{1}", first, second);
            csv.AppendLine(newLine);

           
            File.WriteAllText("C:/Users/Lukasz/XP/Converter/doc/plik.csv", csv.ToString());
        }
    }
}
