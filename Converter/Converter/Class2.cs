using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Class2
    {
        //before your loop
        StringBuilder csv = new StringBuilder();

        //in your loop
        String first = "a";
        String second = "b";
        //Suggestion made by KyleMit
        public void cos()
        {
            String newLine = string.Format("{0},{1}", first, second);
            csv.AppendLine(newLine);

            //after your loop
            File.WriteAllText("C:/Users/Lukasz/XP/Converter/doc/plik.csv", csv.ToString());
        }
    }
}
