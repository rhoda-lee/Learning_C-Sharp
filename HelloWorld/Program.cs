using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("This is exciting");
            Console.WriteLine(3 + 3);

            // This is a comment
            //Console.Write("Hello");
            //Console.Write("I am writing on the same line");

            /* This is a multiline comment
             I can write on as many lines as I can */
            string name = "Dede";
            Console.WriteLine("Hello "+ name);
            int number = 22;
            double floatNumber = 22.5D;
            Console.WriteLine(number + floatNumber);

            int myNum = 15;
            myNum = 20; // myNum is now 20
            Console.WriteLine(myNum);

            int myNum2 = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            string firstname = "Rhoda ";
            string lastname = "Lee";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            int x = 3, y = 7, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);

            Console.WriteLine(Math.Max(5, 10));
        }
    }
}