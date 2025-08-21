using System;

namespace Methods
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I am being executed now!");
        }
        //Method with parameters:
        static void MyOtherMethod(string firstName, int age, string country = "Ghana") //default parameter "country"
        {
            Console.WriteLine(firstName + " Lee");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"I am from {country}");
        }

        //Method with return value:
        static int MySum(int x, int y)
        {
            return x + y;
        }

        //Named Arguments:
        static void MyMethod2(string child1, string child2, string child3) 
        {
        Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------Learning Methods in C#-------------");
            Console.WriteLine("Methods are blocks of code that only run when called. Methods are used for code reusability");

            //calling the method
            MyMethod();
            MyMethod();
            MyMethod();

            Console.WriteLine("-------------Methods With Parameters-------------");
            //Method Parameters:
            MyOtherMethod("Rhoda", 23); //pass the argument to the method call
            MyOtherMethod("Daniel", 12, "China");

            Console.WriteLine("-------------Return Values-------------");
            //methods cannot be void
            int z = MySum(3, 16);
            Console.WriteLine($"Sum of x and y is: {z}");

            Console.WriteLine("-------------Named Arguments-------------");
            MyMethod2(child3: "John", child1: "Liam", child2: "Liam");
        }
    }
}