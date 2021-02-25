using System;

namespace ComplexNumbers
{
    public class Complex
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

        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative.(done)
        public override string ToString()
        {
            if(re == 0)
                return "(" + im.ToString() + "i" + ")";

            if(im == 0)
                return "(" + re.ToString() + ")";

            if(im < 0)
                return "(" + re.ToString() + im.ToString() + "i" + ")";

            return "(" + re.ToString() + "+" + im.ToString() + "i" + ")";
        }

        public Complex Add(Complex c2)
        {
            Complex suma = new Complex(re + c2.re, im + c2.im);
            return suma;
        }


        // TODO (done)
        public Complex Multiply(Complex c2)
        {
            Complex produs = new Complex(re * c2.re - im * c2.im, im * c2.re + re * c2.im);
            return produs;
        }


        // TODO (done)
        public Complex Subtract(Complex c2)
        {
            Complex substract = new Complex(re - c2.re, im - c2.im);
            return substract;
        }


        // TODO
        public double Real
        {
            get
            {
                return re;
            }
        }
        public double Imag 
        { 
            get
            {
                return im;
            }
        }
        public double Modul { get; set; }
        public double Argument { get; set; }


        // TODO
        // orice alte operatii pe care le cunoasteti cu operatii complexe. 
    }
}