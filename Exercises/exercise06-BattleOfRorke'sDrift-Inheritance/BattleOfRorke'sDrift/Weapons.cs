using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfRorke_sDrift
{
    public class Weapons 
    {
        public virtual void Defense()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This weapon is used for defense");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Sword : Weapons
    {
        public override void Defense()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is not really used for defense.." );
            Console.ResetColor();
            Console.ReadLine();
        }
        public void Looks()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Swords are mostly carried around for looks..");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Rifle : Weapons
    {
        public void Shoots()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is a Martini-Henry Rifle. Rifles are for shooting long range");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Pistol : Weapons
    {
        public void handgun()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pistols are useless at distance but looks cool to shoot one..");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Spear : Weapons
    {
        public void Stab()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Spears are for stabbing");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
    
    public class Shield : Weapons
    {
        public override void Defense()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Shields arn't really a weapon");
            Console.ResetColor();
            Console.ReadLine();
        }
        public void Sheild()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sheilds are used for blocking, they are made of cowhide");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
