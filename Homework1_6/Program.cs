using System;

namespace Homework1_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Adress adress = new Adress();

            adress.Country = "Ukraine";
            adress.Index = "03999";
            adress.City = "Kyiv";
            adress.Street = "Хрещатик";
            adress.House = "22";
            adress.Apartment = 1;


            Console.WriteLine($"Country = {adress.Country}");
            Console.WriteLine($"Index = {adress.Index}");
            Console.WriteLine($"City = {adress.City}");
            Console.WriteLine($"Street = {adress.Street}");
            Console.WriteLine($"House = {adress.House}");
            Console.WriteLine($"Apartment = {adress.Apartment}");


            Console.ReadKey();
            

        }
    }
}
