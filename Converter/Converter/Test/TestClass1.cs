using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Test
{
    [TestFixture]
    public class FormatTest1
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Class1 klasa = new Class1();
            if(klasa.format != "csv") Assert.Fail("to sie nie zdarzy! szary kod");
            else
            Assert.Pass("Format danych do CSV!"); 
            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
