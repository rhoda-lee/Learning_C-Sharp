using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlTypes;
using System.Reflection;
using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using System.Threading;

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

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt2.ToLower());   // Outputs "hello world"

            // You can also use the string.Concat() method to concatenate two strings:

            // Example
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);

            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            Console.WriteLine(myString[0]);  // Outputs "H"

            // Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/ index, and returns a new string.This method is often used together with IndexOf() to get the specific character position:

            // Example
            // Full name
            //string personName = "John Doe";

            // Location of the letter D
            //int charPos = personName.IndexOf('D');

            // Get last name
            //string personLastName = name.Substring(charPos);

            // Print the result
            //Console.WriteLine(personLastName);

            // Escape Characters
            string text = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(text);

            /*Short Hand If...Else(Ternary Operator)
            There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. 
            It can be used to replace multiple lines of code with a single line. 
            It is often used to replace simple if else statements:

                Syntax
            variable = (condition) ? expressionTrue : expressionFalse;*/
           // Instead of writing:

           //  Example
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // You can simply write:

            // Example
            int theTime = 20;
            string result = (theTime < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)

        }
    }
}