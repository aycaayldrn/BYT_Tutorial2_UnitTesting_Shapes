﻿namespace Tut2_s26735
{
    public class Cube(double side) : IShape 
    {
        private readonly double side = side;

        public double CalculateArea()
        {
            return 6*Math.Pow(side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(side, 3);
        }
    }
}