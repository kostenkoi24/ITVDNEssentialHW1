using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_3
{
    class Title
    {

        string text;
                
        public string Text
        {
            get { return text; }
            set { text = value; }
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Заголовок: {text}");
            Console.ResetColor();
        }

    }
}
