﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        private const int MaxValue = 11;

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(new Point(2, 3), 10, 20);
            //Rectangle r2 = new Rectangle(1, 3, 5, 7);

            //r1.Draw();


            Circle c1 = new Circle(new Point(4, 5), 10);

            //c1.Draw();



            List<Shape> shapes = new List<Shape>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(2))
                {
                    case 0:
                        // create rectangle
                        shapes.Add(new Rectangle(new Point(rnd.Next(1, MaxValue), 
                            rnd.Next(1, MaxValue)), 
                            rnd.Next(1, MaxValue), 
                            rnd.Next(1, MaxValue)));
                        break;
                    case 1:
                        // create circle
                        shapes.Add(new Circle(new Point(rnd.Next(1, MaxValue), rnd.Next(1, MaxValue)), rnd.Next(1, MaxValue)));
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in shapes)
            {
                item.Draw();
                Console.WriteLine($"Area = {item.Area()}");
            }




            DrawObject(new Rectangle(new Point(2, 3), 10, 20));



            DrawObject(new Person());

            Console.ReadKey();

        }
        static void DrawObject(IDraw d)
        {
            Console.WriteLine("Inside DrawObject()...");
            d.Draw();
        }
    }
}
