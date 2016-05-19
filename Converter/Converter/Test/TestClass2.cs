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
            new Class2().cos();
            // TODO: Add your test code here
            if (File.Exists("C:/Users/Lukasz/XP/Converter/doc/plik.csv"))
                Assert.Pass("Your first passing test");
            else
                Assert.Fail("Your second failed test");
        }
    }
}
