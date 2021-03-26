using System;
using TutorialApp.Composition;
using TutorialApp.Inheritance;
using TutorialApp.MethodOverloading;
using TutorialApp.Polymorphism;
using TutorialApp.Student;
using TutorialApp.Recursion;
using TutorialApp.PassByRef;
using static TutorialApp.StaticClass.StaticClass;

namespace TutorialApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Encapsulation

            //StudentData std = new StudentData();

            //std.setAge(20);
            //std.setMarks(85);
            //std.setName("Hashir");

            //std.showDetails();


            ////Inheritence
            //Furniture fur = new Furniture();
            //fur.ProductId = 1;
            //fur.Price = 50;
            //fur.Name = "Table";
            //fur.WoodType = "Maple Wood";

            //Clothes cl = new Clothes();
            //cl.Color = "Blue";


            // Polymorphism & Abstraction
            //Transformer tran = new Car();
            //tran.Run();

            //Composiion
            //University Uni = new University();
            //Uni.InitArtDep(500,"Sir Abc","Art Department");
            //Uni.InitCompDep(300, "Sir Def", "Computer Sciece Department");


            //Method Overloading
            //Overload ov = new Overload();
            //ov.Add(2, 2);


            //Static Class
            //Console.WriteLine(calculation(12, 12));

            //Recursion
            //RecursiveMethod rec = new RecursiveMethod();
            ////rec.Counting();
            //int FactorialResult = rec.Factorial();
            //Console.WriteLine(FactorialResult);
            //Console.ReadLine();


            //Pass by value vs pass by reference 

            //PassByReference pbf = new PassByReference();
            //int value = 5;
            ////pbf.passByValue(value);
            //pbf.passByReference(ref value);
            //Console.WriteLine("value : {0}", value);
        }
    }
}
