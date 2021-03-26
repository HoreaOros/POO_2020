using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_25_feb
{
    class Program
    {
        static void Main(string[] args)
        {
            World w1 = new World(1);
            w1.SayHello();
            

            World w2 = new World(2);
            w2.SayHello();


            for (int i = 0; i < 100; i++)
            {
                new World(new Random().Next(0, 1000));
            }

            Console.WriteLine($"Am creat {World.Counter} obiecte de tip World");
        }
    }
}
