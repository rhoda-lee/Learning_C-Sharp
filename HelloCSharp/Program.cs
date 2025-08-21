using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 3);
            //I am a single line comment
            /* I am a multiline comment
            The Compiler will ignore us both
            */

            /*
            
            There are Various Data Types in C#
            Value Types and Reference Types
            Value Type:
            int, bool, double, char, struct
            Reference Type:
            string, array, class, interface
            
            To create a variable, specify data type, variable name and assign a value:
            type variableName = value
            */
            int myNumber = 4;
            Console.WriteLine(myNumber);
            bool isDay = true;
            Console.WriteLine(isDay);
            double weight = 75.6D;
            Console.WriteLine(weight);
            string name = "Rhodalee";
            Console.WriteLine(name);
            char grade = 'A';
            Console.WriteLine(grade);
            // others are: class, array, struct, interface

            //constants: use 'const' keyword:
            const double PI = 3.14159D;
            Console.WriteLine("The value of pi is: " + PI);

            string firstName = "Rhoda";
            string lastName = "Lee";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x * y);

            /*
            Multiple Variable Decalration
            To declare more than one variable of the same type, 
            use a comma-separated list:
            */
            int a = 3, b = 60, c = 5;
            Console.WriteLine(a * b + c);

            int e, f, g;
            e = f = g = 10;
            Console.WriteLine(e + f + g);

            //Getting User Input
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            //Convert to Int32
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age is: " + age);

            //C# Math class
            int min = Math.Min(10, 5);
            Console.WriteLine(min);

            int max = Math.Max(4, 22);
            Console.WriteLine(max);

            double sqRoot = Math.Sqrt(64);
            Console.WriteLine(sqRoot);

            int absolute = Math.Abs(-47);
            Console.WriteLine(absolute);

            double rounded = Math.Round(4.65);
            Console.WriteLine(rounded);


            //Strings
            //Length of a string
            string txt = "DFGNLKFHGHDFGVKURGSKJHFHS";
            Console.WriteLine("The length of the text is: " + txt.Length);

            string bio = "Nothing to See Here!";
            Console.WriteLine("Bio to uppercase is: " + bio.ToUpper());
            Console.WriteLine("Bio to lowercase is: " + bio.ToLower());

            /*
            Sting Concatenation
            You can use '+' sign to concatenate two or more strings or you can use the string.Concat() method
            string.Concat() method:*/
            string school = "University of Ghana, ";
            string location = "Legon, Accra";
            string universityLocation = string.Concat(school, location);
            Console.WriteLine("School location is: " + universityLocation);

            //String Interpolation $"{}"
            string myFirstName = "Rhoda";
            string myLastname = "Oduro-Nyarko";
            string myFullName = $"My fullname is : {myFirstName} {myLastname}";
            Console.WriteLine(myFullName);

            /*String Accessing
            Use index accessing, IndexOf() and Substring()*/
            Console.WriteLine(myFirstName[2]);

            int charPos = myLastname.IndexOf("u");
            Console.WriteLine(charPos);

            string subString = myLastname.Substring(charPos);
            Console.WriteLine(subString);

            // Special Characters
            //Escape character
            string randomText = "He said, \"You are very smart\".";

            //New Line character
            string text = "She said:\nYou are very pretty.";

            //Tab character
            string text2 = "They asked:\n\t\"What in the world is this?\"";

            Console.WriteLine(randomText);
            Console.WriteLine(text);
            Console.WriteLine(text2);

            //Boolean
            bool isNight = true;
            Console.WriteLine(isNight);

            Console.WriteLine(e == f);
            Console.WriteLine(x > y);

            //If statements and If...else statements
            if (20 > 18)
            {
                Console.WriteLine("20 is indeed greater than 18.");
            }
            else { Console.WriteLine("20 is not greater than 18!"); }

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning!");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }

            //Ternary Operator: variable = (condition) ? expressionTrue : expressionFalse;
            int theTime = 20;
            string resultTime = (time > 18) ? "Good evening!" : "Good day!";
            Console.WriteLine(resultTime);

            //Switch case
            /*Syntax:
            switch (expression){
                case x:
                    block of code
                    break;
                case y:
                    block of code
                    break;
                case z:
                    block of code
                    break;
                default:
                    block of code
                    break;
            }
            */
            int day = 4;
            switch (4)
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
                default:
                    Console.WriteLine("Enter number 1 to 7, as there are seven days in a week.");
                    break;
            }

            //Loops

            //While Loops
            /*Syntax:
            while(condition)
            {
                // do block of code;
                increment++
            }
            */
            int num = 0;
            while (num < 5)
            {
                Console.WriteLine(num);
                num++;
            }

            //Do while loop
            /*Syntax:
            do 
            {
                // block of code;
            }
            while (condition);
            */
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number < 5);

            //For Loop
            /*Syntax:
            for (statement1; statement2; statement3)
            {
                // do block of code
            }
            */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //Nested loops:
            for (int j = 1; j <= 2; ++j)
            {
                Console.WriteLine("Outer: " + j);
                for (int k = 1; k <= 3; ++k)
                {
                    Console.WriteLine("Inner: " + k);
                }
            }

            //For each loop: used to loop through an array or other data sets
            /*Syntax:
            foreach (type variableName in arrayName)
            {
                // some block of code
            }
            */
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

        




        }
    }
}