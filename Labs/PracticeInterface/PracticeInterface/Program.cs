using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rifle r = new Rifle();
            r.Operate("Bang");
            Shotgun s = new Shotgun();
            s.Operate("Boom");
            Pistol p = new Pistol();
            p.Operate("Pew Pew");

            IFirearm f = new Rifle();
            f.Operate("I don't know");
        }
    }
}
