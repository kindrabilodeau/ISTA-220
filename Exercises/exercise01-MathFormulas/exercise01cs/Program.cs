﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01cs
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("\nPart 1:Circumference and Area of a cirle.");
             Console.WriteLine("Please enter a number for the radius: ");
             string strradius = Console.ReadLine();  //getnumber???

            int intradius = int.Parse(strradius);
             double circumference = 2 * Math.PI * intradius;
             Console.WriteLine($"The circumference is{circumference}");
             double area = Math.PI * intradius * intradius; 
             Console.WriteLine($"The area is {area}");
             Console.WriteLine("Please press enter to continue to Part 2.");
             Console.ReadLine();

             Console.WriteLine("\nPart 2: Volume of a Hemishpere.");
             Console.WriteLine("Please enter a number for the radius: ");
             string hemiRadius = Console.ReadLine();
             double shpereRadius = double.Parse(hemiRadius);
             double volume = ((1.33333333 * Math.PI * shpereRadius * shpereRadius * shpereRadius )* .5);
             //This pops out the correct answer,still need to figure out how to write fractions.  
             Console.WriteLine($"The_volume_is_{volume}");
             Console.WriteLine("Please press enter to continue to Part 3.");
             Console.ReadLine();

             Console.WriteLine("\nPart 3: Area of a Triangle (Heron's Formula)");
             Console.WriteLine("First you have to find the Perimeter");
             Console.WriteLine("Enter a number for side 1.");
             string input1 = Console.ReadLine();
             double triSide1 = double.Parse(input1);
             Console.WriteLine("Enter a number for side 2.");
             string input2 = Console.ReadLine();
             double triSide2 = double.Parse(input2);
             Console.WriteLine("Enter a number for side 3.");
             string input3 = Console.ReadLine();
             double triSide3 = double.Parse(input3);

             double perimeter = (triSide1 + triSide2 + triSide3) / 2;
             Console.WriteLine($"The Perimeter of the triangle is {perimeter}");
             Console.WriteLine("Press enter to continue");
             Console.ReadLine();
             double triArea = Math.Sqrt(perimeter * (perimeter - triSide1)*(perimeter - triSide2) * (perimeter - triSide3));
             Console.WriteLine($"The area is {triArea}");
             Console.WriteLine("Press enter to continue to Part 4.");
             Console.ReadLine();

            Console.WriteLine("\nPart 4:solving a quadratic equation.");
            Console.WriteLine("Enter a value for 'a'");
            string valueA = Console.ReadLine();
            double quadA = double.Parse(valueA);
            Console.WriteLine("Enter a value for 'b'");
            string valueB = Console.ReadLine();
            double quadB = double.Parse(valueB);
            Console.WriteLine("Enter a value for 'c'");
            string valueC = Console.ReadLine();
            double quadC = double.Parse(valueC);
            double dis = (quadB * quadB) - 4 * quadA * quadC;
            if (dis > 0)
            {
                double pos = (-quadB + Math.Sqrt(dis))  / (2 * quadA);
                double neg = (-quadB - Math.Sqrt(dis)) / (2 * quadA);
                Console.WriteLine($"The positive solution is {pos}");
                Console.WriteLine($"The negative solution is {neg}");
                Console.ReadLine();
            }
            else if (dis == 0)
            {
                double zero = -quadB / (2 * quadA);
                Console.WriteLine($"The only solution is {zero}");
                Console.ReadLine();
            }
            else if (dis < 0)
            {
                Console.WriteLine("Answer is not a real number");
                Console.WriteLine("Press Enter to Exit.");
                Console.ReadLine();
            }
        }       
    }
}
