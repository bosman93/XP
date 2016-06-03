using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class ConversionRatesLoader
    {
        public List<ConversionRate> load(string path)
        {
            var conversionRates = new List<ConversionRate>();
            using (var textReader = new StreamReader(path))
            {
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1)
                {
                    line = textReader.ReadLine();

                    skipCount++;
                }

                while (line != null)
                {
                    string[] columns = line.Split(',');
                    ConversionRate conversionRate = new ConversionRate();
                    try
                    {
                        conversionRate.currency = columns[0];
                        conversionRate.buyRate = columns[1];
                        conversionRate.sellRate = columns[2];
                    }
                    catch (Exception e)
                    {
                        throw new FormatException();
                    }
                    conversionRates.Add(conversionRate);
                    line = textReader.ReadLine();
                }
            }
            return conversionRates;
        }
    }
}
