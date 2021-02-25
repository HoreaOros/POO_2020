using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, -4);
            Complex c3 = new Complex(3);
            Complex c4 = new Complex(0, -5);
            Complex c5 = new Complex("5+6i");


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);


            // TODO: supraincarcarea operatorilor aritmetici pentru tipul Complex
            // Complex suma = c1 + c2;


            Complex suma = c1.Add(c2);

            Console.WriteLine($"{c1} + {c2} = {suma}");


            Complex diff = c1.Subtract(c2);
            Console.WriteLine($"{c1} - {c2} = {diff}");

            Complex mult = c1.Multiply(c2);
            Console.WriteLine($"{c1} * {c2} = {mult}");

            

        }
    }
}
