using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface //Created by clicking new item - interface
{
    interface IFirearm //interfaces named with a capitol I 
    {
        void Operate(string s); 
    }

    class Shotgun : IFirearm
    {
        public void Operate(string s)
        {
            Console.WriteLine($"I am a shotgun and i go {s}");
        }
    }

    class Rifle : IFirearm
    {
        public void Operate(string s)
        {
            // Console.WriteLine($"I am a rifle and i go {s}");
            Console.Write("B");
            Console.Write("A");
            Console.Write("N");
            Console.Write("G");
            Console.Write("\n");
        }
    }

    class Pistol : IFirearm
    {
        public void Operate(string s)
        {
            Console.WriteLine($"I am a pistol and i go {s}");
        }
    }
}
