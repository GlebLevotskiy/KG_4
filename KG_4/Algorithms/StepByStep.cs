using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG_4.Algorithms
{
    class StepByStep : IAlgorithm
    {
        public List<Point> Invoke(int x1, int y1, int x2, int y2)
        {
            List<Point> points = new List<Point>();
            double k = ((double)y2 - (double)y1) / ((double)x2 - (double)x1);
            double b = y2 - k * x2;
            double dx = (double)Math.Abs(x2 - x1) / ((double)Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1)) * 2);
            dx = (x2 > x1 ? dx : -dx);

            for (double x = x1; (int)x != x2; x += dx)
            {
                int y = (int)(k * x + b);
                points.Add(new Point((int)x, y));
            }

            points.Add(new Point(x2, y2));

            return points;
        }
    }
}
