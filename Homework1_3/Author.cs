using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_3
{
    class Author
    {
        string author;

        public string AuthorName
        {
            get { return author; }
            set { author = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Автор: {author}");
            Console.ResetColor();
        }

    }
}
