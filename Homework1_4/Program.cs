using System;

namespace Homework1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            /*Координати на назва*/
            Point p1 = new Point(2, 3, "Трикутник");
            Point p2 = new Point(6, 7, p1.S);
            Point p3 = new Point(11, 2, p1.S);
                        

            Figure figure = new Figure(p1, p2, p3);

            Console.WriteLine(p1.S);
            Console.WriteLine($"Length size = {figure.LengthSide(p1, p2)}");

            Point[] points = { p1, p2, p3 };

            figure.PerimeterCalculator(points);
                        
            Console.WriteLine($"Perimeter = {figure.Perimeter}");

            Console.ReadKey();

        }
    }
}
