using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.Polymorphism
{
    class Car : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Car!");
        }
    }
}
