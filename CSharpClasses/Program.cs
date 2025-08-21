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
        
        // Create a Car class
        class Car2
        {
            public string model;  // Create a field

            // Create a class constructor for the Car class
            public Car2()
            {
                model = "Mustang"; // Set the initial value for model
            }
                
        
        }

        // Outputs "Mustang"
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

            Console.WriteLine("----------------Constructors----------------");
            /*A constructor is a special method that is used to initialize objects. 
            The advantage of a constructor, is that it is called when an object of a class is created. 
            It can be used to set initial values for fields:
            
            Example:
            Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
            Also note that the constructor is called when the object is created.
            All classes have constructors by default: if you do not create a class constructor yourself, 
            C# creates one for you. However, then you are not able to set initial values for fields.
            Constructors save time! Take a look at the last example on this page to really understand why.
            */
            Car2 Ford = new Car2();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model

            Console.WriteLine("----------------Properties----------------");

            Console.WriteLine("Person 1:");
            Person person1 = new Person();
            person1.Name = "Julia";
            Console.WriteLine(person1.Name);

            Console.WriteLine("Person 2:");
            Person person2 = new Person();
            person2.Country = "Ghana";
            Console.WriteLine(person2.Country);





















        }
    }
}