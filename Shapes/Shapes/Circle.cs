using System.Text;
using System;

namespace Shapes
{
    internal class Circle : Shape
    {
        private int radius;

        public Circle(Point point, int radius): base(point)
        {
            this.radius = radius;
        }

        public Circle(int radius): this(new Point(0, 0), radius)
        {

        }

        public override string ToString()
        {
            return new StringBuilder()
                .Append($"[Center = {point.ToString()}; Radius = {radius}]")
                .ToString();
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing circle {this}");
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}