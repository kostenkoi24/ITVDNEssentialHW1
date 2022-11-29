using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_3
{
    class Content
    {

        string content;

        
        public string ContentText
        {
            get { return content; }
            set { content = value; }
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Зміст: {content}");
            Console.ResetColor();
        }

    }
}
