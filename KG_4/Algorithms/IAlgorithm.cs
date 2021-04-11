using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG_4.Algorithms
{
    interface IAlgorithm
    {
        List<Point> Invoke(int x1, int y1, int x2, int y2);
    }
}
