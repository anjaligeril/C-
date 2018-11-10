using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Complex
    {
        private int _real;
        public int real
        {
            get
            {
                return _real;
            }
            set
            {
                _real = value;
            }
        }

        private int _imaginary;

        public int imaginary
        {
            get
            {
                return _imaginary;
            }
            set
            {
                _imaginary = value;
            }
           
        }

        public Complex()
        {
            _real = 0;
            _imaginary = 0;
        }
        public Complex(int r,int i)
        {
            _real = r;
            _imaginary = i;
        }

        //overload + operator

        public static Complex operator +(Complex c1,Complex c2)
        {
            Complex c3 = new Complex();
            c3._real = c1._real + c2._real;
            c3._imaginary = c1._imaginary + c2._imaginary;

            return c3;
        }
    }
}
