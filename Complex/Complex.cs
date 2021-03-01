using System;
using System.Text.RegularExpressions;

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
            v = Regex.Replace(v, @"\s+", "");

            Regex realPattern = new Regex(@"^(-|\+|)\d*(?!i)");
            if (realPattern.IsMatch(v))
            {
                MatchCollection realMatches = realPattern.Matches(v);

                if (realMatches[0].ToString().Length != 0)
                {
                    this.re = double.Parse(realMatches[0].ToString());
                }
            }

            Regex imagPattern = new Regex(@"(\+|-|)\d*(?=i$)");
            if (imagPattern.IsMatch(v))
            {
                MatchCollection imagMatches = imagPattern.Matches(v);
                this.im = double.Parse(imagMatches[0].ToString());
            }
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative.
        public override string ToString()
        {
            string semn2 = "";

            if (re == 0)
            {
                if (im == 0)
                    return "0";
                else
                    return im.ToString() + "i";
            }

            if (im < 0)
            {
                im = -im;
                semn2 = "-";
            }
            else if (im > 0)
                semn2 = "+";
            else
                return re.ToString();

            return "(" + (re.ToString()) + " " + semn2 + " " + im.ToString() + "i" + ")";
        }

        public Complex Add(Complex c2)
        {
            Complex suma = new Complex(re + c2.re, im + c2.im);
            return suma;
        }
        public Complex Substract(Complex c2) => new Complex(re - c2.re, im - c2.im);
        public Complex Multiply(Complex c2) => new Complex((re * c2.re) - (im * c2.im), (re * c2.im) + (c2.re * im));


        public double Re
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

        public double Modul(Complex c) => Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
        public double Argument(Complex c) => Math.Atan(im / re); 
    }
}