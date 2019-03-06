using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfRorke_sDrift
{
    public class Zulus
    {
        public void Yell()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("yells:ZULU!!!" );
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Chief : Zulus
    {
        public void Point(string direction)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(direction);
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Warrior : Zulus
    {
        public void Attack()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The warriors are attacking");
            Console.ResetColor();
            Console.ReadLine();
        }

        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The warriors are running toward you");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
