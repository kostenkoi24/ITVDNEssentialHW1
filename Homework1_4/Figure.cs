using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_4
{
    class Figure
    {

        public Figure(Point point, Point point1, Point point2)
        {

        }

        public Figure(Point point, Point point1, Point point2, Point point3)
        {

        }

        public Figure(Point point, Point point1, Point point2, Point point3, Point point4)
        {

        }


        public double LengthSide(Point A, Point B)
        {

            return Math.Sqrt(Math.Pow(B.A - A.A, 2) + Math.Pow(B.B - A.B, 2));

        }

        double perimeter;

        public void PerimeterCalculator(Point[] points)
        {
            for (int i = 0; i<points.Length-1; i++)
            {
                perimeter = LengthSide(points[i], points[i + 1]);
            }
        }

        public double Perimeter { get { return perimeter; } }


    }
}
