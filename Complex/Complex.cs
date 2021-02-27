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
            int counter = 0;
            int counter1 = 0, counter2 = 0;
            int numberA = 0;
            int numberB = 0;
            // parte reala != 0 si parte imaginara 0
            // parte reala 0 si parte imaginara != 0
            // parte reala > 0 si parte imaginara != 0 (parte im. poz sau neg)
            if ((int)v[0] - (int)'0' > 0 && (int)v[0] - (int)'0' < 10)
            {
                // verificare daca este un numar complex cu parte reala pozitiva si parte imaginara pozitiva
                string[] imaginaryPositive = v.Split('+');
                string[] imaginaryNegative = v.Split('-');

                if (imaginaryPositive.Length == 1 && imaginaryNegative.Length == 1)
                {
                    string[] numberi = v.Split('i');
                    if (numberi.Length == 2)
                    {
                        while (counter < imaginaryPositive[0].Length && char.IsDigit(v[counter]))
                        {
                            numberB = numberB * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberA = 0;
                    } else if (numberi.Length == 1)
                    {
                        while (counter < imaginaryPositive[0].Length && char.IsDigit(v[counter]))
                        {
                            numberA = numberA * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberB = 0;
                    }
                } else
                {
                    //daca partea imaginara este pozitiva
                    if (imaginaryPositive.Length == 2)
                    {
                        while (counter1 < imaginaryPositive[0].Length && char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter1++;
                        }
                        while (counter2 < imaginaryPositive[1].Length && counter1 < imaginaryPositive[1].Length + imaginaryPositive[0].Length)
                        {
                            if (char.IsDigit(v[counter1]))
                            {
                                numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                                counter2++;
                            }
                            counter1++;
                        }
                    }
                    else if (imaginaryNegative.Length == 2)  // daca partea imaginara este negativa
                    {
                        while (counter1 < imaginaryNegative[0].Length && char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter1++;
                        }
                        while (counter2 < imaginaryNegative[1].Length && counter1 < imaginaryNegative[1].Length + imaginaryNegative[0].Length)
                        {
                            if (char.IsDigit(v[counter1]))
                            {
                                numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                                counter2++;
                            }
                            counter1++;
                        }
                        numberB = 0 - numberB;
                    }  

                }
            }
            // parte reala negativa && parte im = 0
            // parte reala = 0 && parte im negativa
            // parte reala negativa && parte im ! = 0
            else 
            {
                string[] negative = v.Split('-');
                string[] realNegative = v.Split('-', '+');
                if (negative.Length == 2 && realNegative.Length == 2)
                {
                    string[] numberi = v.Split('i');
                    if(numberi.Length == 2)
                    {
                        while (counter < negative[0].Length && char.IsDigit(v[counter]))
                        {
                            numberB = numberB * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberA = 0;
                    } else
                    {
                        while (counter < negative[0].Length && char.IsDigit(v[counter]))
                        {
                            numberA = numberA * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberB = 0;
                    }
                }
                if (realNegative.Length == 3 && negative.Length == 2)
                {
                    while (counter <= realNegative[1].Length && counter1 <= realNegative[0].Length+realNegative[1].Length)
                    {
                        if(char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter++;
                        }
                        counter1++;
                    }
                    numberA = 0 - numberA;
                    while(counter2 <= realNegative[2].Length && counter1 < v.Length)
                    {
                        if (char.IsDigit(v[counter1]))
                        {
                            numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                            counter2++;
                        }
                        counter1++;
                    }
                }
                if(negative.Length == 3)
                {
                    while (counter <= negative[1].Length && counter1 <= negative[0].Length + negative[1].Length)
                    {
                        if (char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter++;
                        }
                        counter1++;
                    }
                    numberA = 0 - numberA;
                    while(counter2 <= negative[2].Length && counter1 < v.Length)
                    {
                        if (char.IsDigit(v[counter1]))
                        {
                            numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                            counter2++;
                        }
                        counter1++;
                    }
                    numberB = 0 - numberB;
                }
            }
            this.re = numberA;
            this.im = numberB;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative.
        public override string ToString()
        {
            if (re != 0 && im > 0)
            {
                if (im == 1)
                {
                    return re.ToString() + "+" + "i";
                } else
                return re.ToString() + "+" + im.ToString() + "i";
            }
            else if (re != 0 && im < 0)
            {
                if (im == -1)
                {
                    return re.ToString() + "-" + "i";
                }
                else
                    return re.ToString() + im.ToString() + "i";
            }
            else if (re != 0 && im == 0)
            {
                return re.ToString();

            }
            else if (re == 0 && im != 0)
            {
                if (im != 1 && im != -1)
                    return im.ToString() + "i";
                else if (im == 1)
                    return "i";
                else if (im == -1)
                    return "-i";
            }
            return "";
        }

        public Complex Add(Complex c2)
        {
            Complex suma = new Complex(re + c2.re, im + c2.im);
            return suma;
        }


        // TODO
        public Complex Multiply(Complex c2)
        {
            throw new NotImplementedException();
        }


        // TODO
        public Complex Subtract(Complex c2)
        {
            throw new NotImplementedException();
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