using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Test
{
    [TestFixture]
    public class TestClass2
    {
        [Test]
        public void TestMethod()
        {
            new DataManager().saveData();
            if (File.Exists("C:/Users/Lukasz/XP/Converter/doc/plik.csv"))
                Assert.Pass("Your first passing test");
            else
                Assert.Fail("Your second failed test");
        }
    }
}
