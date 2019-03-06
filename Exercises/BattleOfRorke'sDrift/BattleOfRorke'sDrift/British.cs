using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfRorke_sDrift
{
     
    public class British
    {
        public void Brit()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Clicks Heels");
            Console.ResetColor();
            Console.ReadLine(); 
        }
    }

    public class Officer : British
    {
        public void Orders(string order)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(order);
            Console.ResetColor();
            Console.ReadLine();
        }    
    }

    public class Enlisted : British
    {
        public void Reports()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("They say:Yes Sir!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}