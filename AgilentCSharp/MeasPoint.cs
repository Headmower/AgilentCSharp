using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentCSharp
{
    class MeasPoint
    {
        private Complex _complex;
        private double _frequency, _logMag;

        public MeasPoint(double frequency, Complex complex)
        {
            this._complex = complex;
            this._frequency = frequency;
            this._logMag = 20 * Math.Log10(_complex.Modulus);
        }

        public MeasPoint(double frequency, float real, float imaginary = 0)
        {
            this._complex = new Complex(real, imaginary);
            this._frequency = frequency;
            this._logMag = 20 * Math.Log10(_complex.Modulus);
        }

        public double LogMag
        {
            get { return _logMag; }
        }

        public Complex Complex
        {
            get { return _complex; }
        }

        public double Frequency
        {
            get { return _frequency; }
        }
    }
}
