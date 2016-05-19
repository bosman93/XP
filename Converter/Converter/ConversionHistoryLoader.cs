using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Converter
{
    class ConversionHistoryLoader {

        public ConversionHistory parseFile(string path) {
            ConversionHistory history = new ConversionHistory();

            using (var textReader = new StreamReader(path)) {
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1) {
                    line = textReader.ReadLine();

                    skipCount++;
                }

                while (line != null) {
                    string[] columns = line.Split(',');
                    Conversion conversion = new Conversion();
                    try {
                        conversion.currencyFrom = columns[0];
                        conversion.amountFrom = columns[1];
                        conversion.currencyTo = columns[2];
                        conversion.amountTo = columns[3];
                        conversion.exchangeRate = columns[4];
                        conversion.conversionDate = columns[5];
                    }
                    catch (Exception e) {
                        throw new FormatException();
                    }
                    history.addConversion(conversion);
                    line = textReader.ReadLine();
                }
            }
            return history;
        }
    }
}
