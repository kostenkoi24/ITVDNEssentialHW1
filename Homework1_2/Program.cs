using System;

namespace Homework1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            

            Console.Write("Введіть ширину прямокутника: " );
            string side1 = Console.ReadLine();
            Console.Write("Введіть довжину прямокутника: ");
            string side2 = Console.ReadLine();
            

            Rectangle rectangle = new Rectangle(double.Parse(side1), double.Parse(side2));
                                    
            Console.WriteLine("Площа = {0}",rectangle.Area);
            Console.WriteLine("Периметер = {0}", rectangle.Perimeter);

            Console.ReadKey();


        }
    }
}
