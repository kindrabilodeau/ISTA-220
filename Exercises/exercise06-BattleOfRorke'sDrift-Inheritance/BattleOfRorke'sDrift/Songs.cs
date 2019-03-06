using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfRorke_sDrift
{
    public class Songs
    {
        public virtual void Disclaimer()
        {
            Console.WriteLine("Disclaimer:");
            Console.ReadLine();
        }
        public virtual void Sing()
        {
            Console.WriteLine("The Men start singing: ");
            Console.ReadLine();
        }
    }

    public class BritSong : Songs 
    {
        public override void Sing()
        {
            Console.WriteLine("In response the Brits start singing: ");
            Console.ReadLine();
        }
        public void Bsong()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Men of Harlech stop your dreaming " +
                "Can't you see their spear points gleaming " +
                "See their warrior's pennants streaming To this battle field");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class ZuluSong : Songs
    {
        public override void Disclaimer()
        {
            Console.WriteLine("Disclaimer: The lyrics for the Zulu Song of the Warrior were found translated online " +
                "and may not be accurate");
            Console.ReadLine();
        }
        public void Zsong()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Song of the Warrior: See him there, the Zulu warrior " +
                "see him there, the Zulu chief chief chief chief");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
