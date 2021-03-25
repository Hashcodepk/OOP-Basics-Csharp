using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.MethodOverloading
{
    class Overload
    {
        public void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public void Add (string x, string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }

        public void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
