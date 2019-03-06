using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Horse
    {
        public string name;

        public Horse(string n)
        {
            name = n;
        }

        public string Speak()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            return "Neigh";
        }


    }
}
