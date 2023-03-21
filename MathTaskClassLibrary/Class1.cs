using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleS(int a, int b)
        {
            return a * b;
        }

        public double CylinderV(double r, double h)
        {
            return 3.14 * r * r * h; // PI number is too long to compare results. That's why I'm using 3.14
        }
    }
}