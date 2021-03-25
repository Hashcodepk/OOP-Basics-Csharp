using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.Immutable
{
    class MyClass
    {
        private readonly string Name;

        public MyClass(string name)
        {
            Name = name;
        }

        public string getName
        {
            get { return Name; }
        }
    }
}



