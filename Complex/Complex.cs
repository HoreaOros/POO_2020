using System;

namespace ComplexNumbers
{
    internal class Complex
    {
        private double re;
        private double im;

        public Complex(double re): this(re, 0)
        {

        }


        // TODO: parsing pe string pentru a scoate partea reala si partea imaginara
        // probabil ca s-ar putea face cu expresii regulare. 
        public Complex(string v)
        {
            
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative.
        public override string ToString()
        {
            return "(" + re.ToString() + "+" + im.ToString() + "i" + ")";
        }

        public Complex Add(Complex c2)
        {
            Complex suma = new Complex(re + c2.re, im + c2.im);
            return suma;
        }


        // TODO
        internal Complex Multiply(Complex c2)
        {
            throw new NotImplementedException();
        }


        // TODO
        internal Complex Subtract(Complex c2)
        {
            throw new NotImplementedException();
        }


        // TODO
        public int Real { get; set; }
        public int Imag { get; set; }
        public int Modul { get; set; }
        public int Argument { get; set; }


        // TODO
        // orice alte operatii pe care le cunoasteti cu operatii complexe. 
    }
}