using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Chicken
    {
        //property
        public string Name { get; set; }


        //default constructor
        //public Chicken() { }

        //constructor
        public Chicken()
        {
            Console.WriteLine("Chicken got instantiated...");
        }

        //method (signature = accessibility modifier -> return type -> Name -> Parameters
        public void Peck(string typeOfFood)
        {
            Console.WriteLine($"{Name} pecks hungrily at the {typeOfFood}.");
        }
    }
}
