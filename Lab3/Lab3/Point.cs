using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab3
{
    public class Point
    {
        private double x, y;

        #region Undo_functionality
        //TODO
        // tinem un istoric al valorilor pe care le-a avut punctul
        Stack<Point> history = new Stack<Point>();

        public void StepBack()
        {

        }
        #endregion
        #region c-tors
        public Point(): this(0.0, 0.0)
        {

        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// initializeaza un Point pe baza unui string de forma "(3.0;4.0)"
        /// Functioneaza pentru valori precum:
        /// (1.0, 2.0)
        /// (1.0, 2)
        /// (1.0,2)
        /// (1.0, 2.321)
        /// (1.0,2.321)
        /// (1.0,2.0)
        /// (1,2.0)
        /// (  133.0,2.0)
        /// </summary>
        /// <param name="str"></param>
        public Point(string str)
        {
            Regex rgx = new Regex(@"\s*\(\s*(\d+(?:\.\d+)?)\s*,\s*(\d+(?:\.\d+)?)\s*\)\s*");
            var match = rgx.Match(str);

            if (match.Success)
            {
                x = double.Parse(match.Groups[1].ToString());
                y = double.Parse(match.Groups[2].ToString());
            }

            else throw new ArgumentException("Input string was in wrong format.");
        }

        


        #endregion
        public override string ToString()
        {
            return $"({x}; {y})";
        }

        public void MoveBy(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }

        public double DistanceToOrigin()
        {
            return DistanceTo(new Point());
        }
        public double DistanceTo(Point p2)
        {
            double x1, y1, x2, y2;

            x1 = this.x;
            y1 = this.y;

            x2 = p2.x;
            y2 = p2.y;


            return Math.Sqrt(Math.Pow(x1 - x2, 2.0) +  Math.Pow(y1 - y2, 2.0));
        }
    }
}