using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Pig
    {
        public string Name;

        public Pig()
        {
            //Default Constructor;
        }

        public Pig(string n)
        {
            Name = n;
        }

        public string Speak()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            return "Oink Oink I'm Pig!";
        }

        public string Play()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            return "I like to roll in the mud";
        }
    }
}
