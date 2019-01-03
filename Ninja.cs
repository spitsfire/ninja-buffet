using System;
using System.Collections.Generic;

namespace NinjaBuffet
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> foodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            foodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get{ return calorieIntake >= 1200; }
        }
        public void Eat(Food item)
        {
            if(!IsFull)
            {
                Console.WriteLine($"Ninja digs in to some delicious {item.Name}.");
                calorieIntake += item.Calories;
                foodHistory.Add(item);
            }
            else
            {
                Console.WriteLine("Ninja is too full to eat anymore!");
            }
        }

    }
}