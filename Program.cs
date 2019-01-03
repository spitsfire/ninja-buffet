using System;
using System.Collections.Generic;
namespace NinjaBuffet
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ninja1 = new Ninja();
            ninja1.Eat(buffet.Serve());
            ninja1.Eat(buffet.Serve());
            ninja1.Eat(buffet.Serve());
            ninja1.Eat(buffet.Serve());
            ninja1.Eat(buffet.Serve());
            foreach(var item in ninja1.foodHistory)
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }
}
