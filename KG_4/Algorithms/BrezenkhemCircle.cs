using System.Collections.Generic;
using System.Drawing;

namespace KG_4.Algorithms
{
    class BrezenkhemCircle : IAlgorithm
    {
        public List<Point> Invoke(int x1, int y1, int x2, int y2)
        {
            List<Point> points = new List<Point>();

            int x = 0;
            int y = y2;
            int e = 3 - 2 * y2;
            points.Add(new Point(x + x1, y + y1));
            points.Add(new Point(x + x1, -y + y1));
            points.Add(new Point(-x + x1, y + y1));
            points.Add(new Point(-x + x1, -y + y1));

            points.Add(new Point(y + x1, x + y1));
            points.Add(new Point(-y + x1, x + y1));
            points.Add(new Point(y + x1, -x + y1));
            points.Add(new Point(-y + x1, -x + y1));
            while (x < y)
            {
                if (e >= 0)
                {
                    e = e + 4 * (x - y) + 10;
                    x = x + 1;
                    y = y - 1;
                }
                else
                {
                    e = e + 4 * x + 6;
                    x = x + 1;
                }

                points.Add(new Point(x + x1, y + y1));
                points.Add(new Point(x + x1, -y + y1));
                points.Add(new Point(-x + x1, y + y1));
                points.Add(new Point(-x + x1, -y + y1));

                points.Add(new Point(y + x1, x + y1));
                points.Add(new Point(-y + x1, x + y1));
                points.Add(new Point(y + x1, -x + y1));
                points.Add(new Point(-y + x1, -x + y1));


            }

            return points;
        }
    }
}
