using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_2
{
    class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;

            this.side2 = side2;

            area = AreaCalculator();

            perimeter = PerimeterCalculator();
        }

        private double  AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        
        public double Area
        {
            get
            {
                return area;
            }
        }

        
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
    }
}
