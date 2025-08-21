using System;

namespace CSharpClasses
{
    class Person
    {
        private string name;

        public string Name //property
        {
            get { return name; }
            set { name = value; }
        }

        //Automatic/Short-hand Properties
        public string Country //property
        {
            get; set; 
        }
    }
}