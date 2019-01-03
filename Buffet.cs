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
                new Food("Pizza", 800, "savory"),
                new Food("Asparagus", 80, "bitter"),
                new Food("Burrito", 600, "spicy"),
                new Food("Crab Legs", 100, "savory"),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }

    }
}
