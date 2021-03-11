using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab3
{
    public class Point
    {
        private double x, y;
        private double initialX, initialY;

        #region History
        
        List<Point> history = new List<Point>();
        int currentHistoryIndex = 0;

        public void returnToInitialValues()
        {
            this.x = initialX;
            this.y = initialY;
        }

        public void StepBack(int steps) // how many steps back do we take?
        {
            if (currentHistoryIndex < steps)
            {
                currentHistoryIndex = 0;
                return;
            }
            else
            {
                currentHistoryIndex = currentHistoryIndex - steps;

                this.x = history[currentHistoryIndex].x;
                this.y = history[currentHistoryIndex].y;
            }
        }

        public void StepAhead(int steps) // redo
        {
            if (currentHistoryIndex + steps >= history.Count)
            {
                currentHistoryIndex = history.Count - 1;

                this.x = history[currentHistoryIndex - 1].x;
                this.y = history[currentHistoryIndex - 1].y;
            }
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

            initialX = x;
            initialY = y;
        }

        /// <summary>
        /// initializeaza un Point pe baza unui string de forma "(3.0;4.0)"
        /// </summary>
        /// <param name="str"></param>
        public Point(string p)
        {
            // we get rid of the usless elements ( '(' , ')', spaces) and split the string in two => left part of ',' and right part of ','
            p = Regex.Replace(p, @"\s+", "");
            p = Regex.Replace(p, @"\(", "");
            p = Regex.Replace(p, @"\)", "");

            try
            {
                string[] coordinates = p.Split(',');
                this.x = double.Parse(coordinates[0]);
                this.y = double.Parse(coordinates[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("EXCEPTION: Bad input format :(");
            }
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

            
            // add to the history the new point and jumps to the end of the list
            history.Add(new Point(x, y));
            currentHistoryIndex = history.Count - 1;
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