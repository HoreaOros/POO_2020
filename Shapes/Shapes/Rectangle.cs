using System;
using System.Text;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        private int width;
        private int height;


        public Rectangle(Point point, int v1, int v2):  base(point)
        {
            this.width = v1;
            this.height = v2;
        }

        public Rectangle(int x1, int y1, int x2, int y2): 
            this(new Point(x1, y1), Math.Abs(x1 - x2), Math.Abs(y1 - y2))
        {

        }

        public override string ToString()
        {
            return new StringBuilder()
                .Append($"[Origin = {point.ToString()}; Width = {width}; Height = {height}]")
                .ToString();
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing rectangle {this}");
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}