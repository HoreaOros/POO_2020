using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_3___11_martie_2021
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 1; // variabila de tip valoare
            Console.WriteLine($"Before PassValByVal: a = {a}");
            PassValByVal(a);
            Console.WriteLine($"After PassValByVal: a = {a}");


            int b = 2;
            Console.WriteLine($"Before PassValByRef: b = {b}");
            PassValByRef(ref b);
            Console.WriteLine($"After PassValByRef: b = {b}");



            Contor c = new Contor();

            //while (true)
            //{
            //    c.Count();
            //    Console.Write(c);
            //}


            Console.WriteLine($"Before PassRefByVal: c = {c}");
            PassRefByVal(c);
            Console.WriteLine($"After PassRefByVal: c = {c}");


            Contor d = new Contor();
            Console.WriteLine($"Before PassRefByRef: d = {d}");
            PassRefByRef(ref d);
            Console.WriteLine($"After PassRefByRef: d = {d}");

        }

        private static void PassRefByRef(ref Contor x)
        {
            x.Count();

            x = new Contor();
        }

        private static void PassRefByVal(Contor x)
        {
            x.Count();

            x = new Contor();
        }

        private static void PassValByRef(ref int x)
        {
            x = 3;
        }

        private static void PassValByVal(int n)
        {
            n = 2;
        }
    }
}
