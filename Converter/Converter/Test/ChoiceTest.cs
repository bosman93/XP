using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter {//1 - z kwoty , 2 na kwote, 0 - wyjscie
    [TestFixture]
    public class TestClass1 {

        [Test]
        public void TestFailure() {
            var x = 1;
            Menu m = new Menu();
            m.choice(x);
            if (m.getCurrentState() != 1) {
                Assert.Fail("Wrong type");
            }            
            Assert.Pass("Your first passing test");
        }
    }
}
