using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_martie
{
    class Program
    {
        static void Main(string[] args)
        {
            ContBancar c1 = new ContBancar("Alice");
            

            Console.WriteLine(c1);


            try
            {
                c1.Depune(1000m);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                c1.Depune(-2000m);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine($"{e.Message}, Valoarea invalida este: {e.Valoare}");
            }


            try
            {
                c1.Retrage(1000m);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c1.Retrage(1000m);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }


            foreach (var item in Logger.Data)
            {
                Console.WriteLine(item);
            }


            
        }
    }
}
