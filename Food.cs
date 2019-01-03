using System;
using System.Collections.Generic;

namespace NinjaBuffet
{
    class Food
    {
        public string Name;
        public int Calories;
        public string Taste;

        public Food(string name, int calories, string taste)
        {
            Name = name;
            Calories = calories;
            Taste = taste;
        }
    }
}