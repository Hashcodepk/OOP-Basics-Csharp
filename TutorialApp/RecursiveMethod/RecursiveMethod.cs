using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.Recursion
{
    class RecursiveMethod
    {
        int num = 1;
        public void Counting()
        {
            if (num == 11)
            {
                return; 
            }
            Console.WriteLine(num);
            num++;
            Counting();
        }

        int number = 5;
        int result = 1;

        public int Factorial()
        {
            if (number == 0)
            {
                return 1;
            }
            result = result * number;
            number--;
            Factorial();
            return result;
        }
    }
}
