
using System;

namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double CalculateParallelogramArea(double side, double height)
        {
            return side * height;
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Трикутник з такими сторонами не існує!");
            }

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double CalculatePyramidLateralArea(double perimeter, double apothem)
        {
            return 0.5 * perimeter * apothem;
        }

        public static double CalculatePyramidVolume(double baseArea, double height)
        {
            return (baseArea * height) / 3;
        }

        public static double CalculateSphereVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
