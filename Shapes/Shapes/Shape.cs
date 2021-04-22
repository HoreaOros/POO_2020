namespace Shapes
{


    internal abstract class Shape: IDraw
    {
        protected Point point;

        protected Shape(Point point)
        {
            this.point = point;
        }

        public abstract void Draw();
        public abstract double Area();
        public abstract double Perimeter();

    }
}