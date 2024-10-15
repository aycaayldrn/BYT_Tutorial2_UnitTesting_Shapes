using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2_s26735
{
    public class Sphere(double radius) : IShape
    {
        private readonly double radius = radius;

        public double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

}
