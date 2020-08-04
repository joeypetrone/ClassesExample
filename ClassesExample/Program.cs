using ClassesExample.Animals;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken();

            chicken.Name = "Liza";

            chicken.Peck("Corn");
        }
    }
}
