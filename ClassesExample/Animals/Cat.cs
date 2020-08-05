using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Cat
    {
        public CatColor Color {get;set;}

        public bool IsFeral {get;set;}

        public Chicken BestFriend {get;set;}

        public void Dye(CatColor color)
        {
            Color = color;
        }

        public void HaveASnack()
        {
            Console.WriteLine($"The {Color} cat took a bite of {BestFriend.Name}. Ooops!");
            BestFriend.Peck($"The {Color} cat.");
        }


    }

    enum CatColor
    {
        NotSetColor,
        Orange,
        Grey,
        Black,
        Calico,
        Tabby,
        White
    }
}
