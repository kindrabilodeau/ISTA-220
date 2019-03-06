using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Chicken
    {
        public string name;

        public Chicken()
        {
            //default constructor
        }

        public Chicken(string n)
        {
            name = n;
        }

        public string Speak()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            return "Cluck Cluck, I'm a Chicken";
        }

        public string Eat()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            return "I eat veggies";
        }
    }
}
