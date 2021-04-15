using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new LunchOrder.Builder();

            LunchOrder order =  
                builder.Bread("Wheat")
                .Dressing("Mayo")
                .Meat("Turkey")
                .GetLunchOrder();

            Console.WriteLine(order);
        }
    }
}
