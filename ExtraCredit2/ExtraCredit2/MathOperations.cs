using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit2
{
    public class MathOperations
    {
        public MathOperations()
        {
        }

        public double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }

        public double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public double SurfaceAreaOfCylinder(double radius, double height)
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * (radius * radius);
        }
    }
}
