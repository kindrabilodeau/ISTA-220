using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Goat
    {
        public string name;
        
        public Goat()
        {
            //default constructor   
        }
        
        public Goat(string n)
        {
            name = n;
        }

        public string Eat()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            return "Snacks!!";
        }

        public string Speak()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            return "I am Goat. Hear me Bahh";
        }
    }
}
