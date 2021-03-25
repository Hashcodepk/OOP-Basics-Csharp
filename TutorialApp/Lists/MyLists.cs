using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.Lists
{
    class MyLists
    {
        int[] ints = new int[] { 24, 26, 28 };


        ArrayList StudentAge = new ArrayList();

       
        public MyLists()
        {
            List<int> StudentAges = new List<int>();
            StudentAges.Add(22);
            StudentAges.Add(25);
            StudentAges.Add(27);

            foreach(int age in StudentAges)
            {
                Console.WriteLine(age);
            }

        }
        
    }
}
