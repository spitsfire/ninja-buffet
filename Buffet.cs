using System;
using System.Collections.Generic;

namespace NinjaBuffet
{
class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 800, false, false),
                new Food("Asparagus", 80, false, false),
                new Food("Burrito", 600, true, false),
                new Food("Crab Legs", 100, false, false),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }

    }
}
