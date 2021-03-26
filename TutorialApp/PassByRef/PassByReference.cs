using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.PassByRef
{
    class PassByReference
    {
        public void passByValue(int myValue)
        {
            myValue += 5;
            Console.WriteLine("myValue : {0}", myValue);
        }

        public void passByReference(ref int myValue)
        {
            myValue += 5;
            Console.WriteLine("myValue : {0}", myValue);
        }
    }
}
