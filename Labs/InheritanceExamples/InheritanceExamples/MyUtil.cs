using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public static class MyUtil    //this is an example of the extension
    {
        public static Horse Gallop(this Horse h)
        {
            Console.WriteLine("This horse gallops");
            return h; 
        }

        public static Whale Blow(this Whale w)
        {
            Console.WriteLine("This whale blows");
                return w;
        }
    }
}
