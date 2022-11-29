using System;

namespace Homework1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Book book = new Book("Совершенный код");

            book.Author = "С. Макконнелл";

            book.Content = "Практическое руководство по разработке программного обеспечения";

            book.Show();
            

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
