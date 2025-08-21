using System;

namespace CSharpClasses
{
    class Program
    {
        class Car
        {
            public string color = "red";
            public string model = "Mustang";
            public int speed = 200;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Classes in C#----------------");

            //Create object or instance of the class
            Car myObj1 = new Car();
            Console.WriteLine(myObj1.color);

            //another instance
            Car myObj2 = new Car();
            Console.WriteLine(myObj2.speed);

            Console.WriteLine("----------------External Class Files----------------");
            //create another class file, define a class and create an instance here
            //Instantiate Human class
            Human girl = new Human();
            Console.WriteLine(girl.name);

            Console.WriteLine("----------------Blank Fields in Class Definitions----------------");
            //instantiate BlankFields class

            BlankFields myObj3 = new BlankFields();
            myObj3.name = "Daniel";
            myObj3.age = 12;
            Console.WriteLine(myObj3.name);
            Console.WriteLine(myObj3.age);

            BlankFields myObj4 = new BlankFields();
            myObj4.name = "Lucy";
            myObj4.age = 18;
            Console.WriteLine(myObj4.name);
            Console.WriteLine(myObj4.age);

            Console.WriteLine("----------------Object Methods----------------");
            Human myObj5 = new Human();
            myObj5.Eat(); // call the method

















        }
    }
}