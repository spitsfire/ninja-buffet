using System;
using System.Collections.Generic;

namespace NinjaBuffet
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool isSpicy;
        public bool isSweet;

        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            isSpicy = spicy;
            isSweet = sweet;
        }
    }
}