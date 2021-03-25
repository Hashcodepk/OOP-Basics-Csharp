using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.PurePolymorphism
{
    interface ITransformer
    {
        void Run();
    }

    interface IExample
    {
        void Run();
    }

    class Car : ITransformer
    {
        public void Run()
        {
            Console.WriteLine("Run Car!");
        }
    }

    class Boat : ITransformer, IExample
    {
        void ITransformer.Run()
        {
            throw new NotImplementedException();
        }

        void IExample.Run()
        {
            throw new NotImplementedException();
        }
    }
}
