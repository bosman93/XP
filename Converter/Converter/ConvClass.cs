using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter {
    class ConvClass {
        private float rate = 0;
        public void setRate(float r) {
            if (r > 0) {
                rate = r;
            }
        }

        public float convertFrom(float a) {
            return a * rate;
        }

        public float convertTo(float a) {
            return a / rate;
        }       
    }
}
