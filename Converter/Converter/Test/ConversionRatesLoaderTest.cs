using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Test
{
    [TestFixture]
    public class ConversionRatesLoaderTest
    {
        [Test]
        public void TestFileNotFound()
        {
            ConversionRatesLoader loader = new ConversionRatesLoader();
            Assert.Throws<System.IO.FileNotFoundException>(() => loader.load("test_rates.csv"));
        }

    }
}
