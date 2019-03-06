using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();  //orgin is an object or an instance 
            Point origin1 = new Point(2, 3); //orgin1 is an object or an instance 
            Point bottomRight = new Point(1366, 768);
            Point first = new Point(0, 0);
            Point second = new Point(4, 3);

            double distance = first.DistanceTo(second);
            Console.WriteLine($"Distance 2 is {distance}");
            double distance2 = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance2}");
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
