using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Duck
    {
        public string name;

        public Duck()
        {
            //default constructor
        }

        public Duck(string n)
        {
            name = n;
        }

        public string Speak()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            return "Quack Quack";
        }

        public string Splash()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            return "I like to play in the water ";
        }
    }
}
