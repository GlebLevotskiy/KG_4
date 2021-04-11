using System;
using System.Collections.Generic;
using System.Drawing;

namespace KG_4.Algorithms
{
    class CDA : IAlgorithm
    {
        public List<Point> Invoke(int x1, int y1, int x2, int y2)
        {
            List<Point> points = new List<Point>();

            int L = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            double dX = (x2 - x1) * 1.0 / L;
            double dY = (y2 - y1) * 1.0 / L;
            points.Add(new Point(x1, y1));
            double prevX = x1;
            double prevY = y1;
            int i = 1;

            while (i < L)
            {
                prevX = prevX + dX;
                prevY = prevY + dY;
                points.Add(new Point((int)Math.Round(prevX), (int)Math.Round(prevY)));
                i++;
            }

            return points;
        }
    }
}
