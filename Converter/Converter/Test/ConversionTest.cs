using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Test {
    [TestFixture]
    public class ConversionTest {

        [Test]
        public void TestConversionFrom() {
            float amount = 12.5f;
            ConvClass c = new ConvClass();
            c.setRate(2.3f);
            float result = c.convertFrom(amount);
            if (result != 28.75f) {
                Assert.Fail("Wrong conversion result");
            }
            Assert.Pass("Correct conversion");
        }

        [Test]
        public void TestConversionTo() {
            float amount = 28.75f;
            ConvClass c = new ConvClass();
            c.setRate(2.3f);
            float result = c.convertTo(amount);
            if (result != 12.5f) {
                Assert.Fail("Wrong conversion result");
            }
            Assert.Pass("Correct conversion");
        }
    }
}
