using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Person : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a person...");
        }
    }
}
