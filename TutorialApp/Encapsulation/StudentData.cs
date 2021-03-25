using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.Student
{
    class StudentData
    {
     
        public int age { get; private set; }
        public int marks { get; private set; }
        public string name { get; private set; }

        public void setAge(int a)
        {
            if(a > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("Please Enter Correct Age!");
            }
        }

        public void setMarks(int m)
        {
            if(m >= 0)
            {
                marks = m;
            }
            else
            {
                Console.WriteLine("marks not valid!");
            }
        }

        public void setName(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                name = n;
            }
            else
            {
                Console.WriteLine("Please Enter Name!");
            }
        }

        public void showDetails()
        {
            Console.WriteLine("Name = {0}, Age = {1}, Marks = {2}", name, age, marks);
        }
    }
}
