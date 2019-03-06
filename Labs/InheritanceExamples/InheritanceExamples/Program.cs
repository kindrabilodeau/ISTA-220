using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();  //needs parenthsis because its a constructor 
            m.Breathe();

            Horse h = new Horse();
            h.Breathe();
            h.Trot();
            h.Gallop(); 

            Whale w = new Whale();
            w.Breathe();
            w.Swim();
            w.Blow();


            m = h;
            m.Breathe();
            // m.Trot(); this does not work because not all mammals trot 
            //w = h; whales are not horses 
            //w = m; Can't swim upstream with inheritance 
            //m = w; would cause 31 to print out whale 

            Console.WriteLine( m.GetType()); //This prints horse because of line 24 (m =h)
            Console.WriteLine( h.GetType());
            Console.WriteLine( w.GetType()); 
        }
    }
}
