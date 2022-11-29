using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_4
{
    class Point
    {
                
        private int a;

        public int A
        {
            get { return a; }
            //set { a = value; }
        }

        private int b;

        public int B
        {
            get { return b; }
            //set { b = value; }
        }

        private string s; 

        public string S
        {
            get { return s; }
            //set { s = value; }
        }

        public Point(int a, int b, string s)
        {
            this.a = a;
            this.b = b;
            this.s = s;
        }




    }
}
