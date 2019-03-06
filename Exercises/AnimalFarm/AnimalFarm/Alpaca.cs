using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Alpaca
    {
        public string name;

        public Alpaca(string n)
        {
            name = n;
        }

        public string Speak()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            return "I'm an Alpaca";
        }
    }

}
