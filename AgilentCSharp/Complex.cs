using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentCSharp
{
    class Complex
    {
        private float _real, _imaginary;
        private float _modulus;

        static public Complex operator +(Complex a,Complex b){
            return new Complex(a._real + b._real, a._imaginary + b._imaginary);
        }

        static public Complex operator -(Complex a, Complex b)
        {
            return new Complex(a._real - b._real, a._imaginary - b._imaginary);
        }

        static public Complex operator /(Complex a, Complex b)
        {
            return new Complex((float)(1.0 / (b._real * b._real + b._imaginary * b._imaginary) * (a._real * b._real + a._imaginary * b._imaginary)), (float)(1.0 / (b._real * b._real + b._imaginary * b._imaginary) * (b._real * a._imaginary - b._imaginary * a._real)));
        }

        public Complex(float real, float imaginary = 0)
        {
            _real = real;
            _imaginary = imaginary;
            _modulus = (float)Math.Sqrt((double)(_real*_real + _imaginary*_imaginary));
        }

        public float Real
        {
            get { return _real; }
            set { _real = value; }
        }

        public float Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        public float Modulus
        {
            get{ return _modulus; }
        }

    }
}
