using System;

namespace ComplexNumbers
{
    public class Complex
    {
        private double re;
        private double im;

        public Complex(double re) : this(re, 0)
        {

        }


        // TODO: parsing pe string pentru a scoate partea reala si partea imaginara (kinda done)
        // probabil ca s-ar putea face cu expresii regulare. 
        public Complex(string v)
        {
            double re, im;
            int i, k = 1, nr = 0;
            double zec = 0;
            int len = v.Length;
            bool isInt = true;
            int sign = 1;
            for (i = 0; i < len; i++)
            {
                if (v[i] <= '9' && v[i] >= '0' && isInt)
                {
                    nr = nr * k + (int)char.GetNumericValue(v[i]);
                    k *= 10;
                }
                else
                if (v[i] == '.')
                {
                    isInt = false;
                    k = 10;
                }
                else
                if (v[i] <= '9' && v[i] >= '0' && !isInt)
                {
                    zec = (zec * k + (int)char.GetNumericValue(v[i])) / k;
                    k *= 10;
                }
                else
                {
                    if (v[i] == '+')
                    {
                        sign = 1;
                        break;
                    }
                    else
                        if (v[i] == '-')
                    {
                        sign = -1;
                        break;
                    }
                }
            }

            isInt = true;
            re = nr + zec;
            nr = 0; zec = 0; k = 1;

            for (int j = i; j < len; j++)
            {
                if (v[j] <= '9' && v[j] >= '0' && isInt)
                {
                    nr = nr * k + (int)char.GetNumericValue(v[j]);
                    k *= 10;
                }
                else
                if (v[j] == '.')
                {
                    isInt = false;
                    k = 10;
                }
                else
                if (v[j] <= '9' && v[j] >= '0' && !isInt)
                {
                    zec = (zec * k + (int)char.GetNumericValue(v[j])) / k;
                    k *= 10;
                }
            }

            im = sign * (nr + zec);
            this.re = re;
            this.im = im;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative.(done)
        public override string ToString()
        {
            if (re == 0)
                return "(" + im.ToString() + "i" + ")";

            if (im == 0)
                return "(" + re.ToString() + ")";

            if (im < 0)
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
            set
            {
                re = value;
            }
        }
        public double Imag
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }
        public double Modul 
        {
            get
            {
                return Math.Sqrt(re * re + im * im);
            }       
        }
        public double Argument { get; set; }

        public static Complex operator + (Complex firstNumber, Complex secondNumber)
        {
            Complex sum = new Complex(firstNumber.re + secondNumber.re, firstNumber.im + secondNumber.im);
            return sum;
        }
        public static Complex operator - (Complex firstNumber, Complex secondNumber)
        {
            Complex sub = new Complex(firstNumber.re - secondNumber.re, firstNumber.im - secondNumber.im);
            return sub;
        }
        public static Complex operator * (Complex firstNumber, Complex secondNumber)
        {
            Complex produs = new Complex(firstNumber.re * secondNumber.re - firstNumber.im * secondNumber.im,
                firstNumber.im * secondNumber.re + firstNumber.re * secondNumber.im);
            return produs;
        }
            
        // TODO
        // orice alte operatii pe care le cunoasteti cu operatii complexe. 
    }
}