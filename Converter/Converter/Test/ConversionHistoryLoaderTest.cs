using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Converter.Test
{
    [TestFixture]
    public class ConversionHistoryLoaderTest
    {
        ConversionHistoryLoader loader;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            loader = new ConversionHistoryLoader();           
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // TODO: Add code here that is run after
            //  all tests in the assembly have been run
        }

        [Test]
        public void TestLoadFileNotFound()
        {
            Assert.Throws<FileNotFoundException>(() => loader.parseFile("file_not_exist"));
        }

        [Test]
        public void TestFileDataFormat()
        {
            Assert.Throws<FormatException>(() => loader.parseFile("file2"));
        }

        [Test]
        public void TestDataValidation()
        {
            ConversionHistory history = loader.parseFile("file2");
            Assert.AreEqual(history.count(), 10);
            Conversion conversion = history.objectAtIndex(1);
            Assert.AreEqual(conversion.currencyFrom, "EUR");

        }

    }
}
