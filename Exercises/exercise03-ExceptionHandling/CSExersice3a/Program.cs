using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExersice3a
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 0;
            double side1 = 0;
            double side2 = 0;
            double side3 = 0;

            findArea(value);
            volumeHemisphere(value);
            areaOfATriangle(side1, side2, side3);
            quadraticEquation(side1, side2, side3);
        }
        private static void quadraticEquation(double side1, double side2, double side3)
        {
            Console.WriteLine("\nPart 4:solving a quadratic equation.");
            Console.WriteLine("Enter a Number");
            double sideA = findNumber(side1);
            Console.WriteLine("Enter a number.");
            double sideB = findNumber(side2);
            Console.WriteLine("Enter a number.");
            double sideC = findNumber(side3);
            
            double dis = (sideB * sideB) - 4 * sideA * sideC;
            if (dis > 0)
            {
                double pos = (-sideB + Math.Sqrt(dis)) / (2 * sideA);
                double neg = (-sideB - Math.Sqrt(dis)) / (2 * sideA);
                Console.WriteLine($"The positive solution is {pos}");
                Console.WriteLine($"The negative solution is {neg}");
                Console.ReadLine();
            }
            else if (dis == 0)
            {
                double zero = -sideB / (2 * sideA);
                Console.WriteLine($"The only solution is {zero}");
                Console.ReadLine();
            }
            else if (dis < 0)
            {
                Console.WriteLine("The Answer is not a real number");
                Console.ReadLine();
            }
        }
        private static void areaOfATriangle(double side1, double side2, double side3)
        {
            Console.WriteLine("\nPart 3: Area of a Triangle (Heron's Formula)");
            Console.WriteLine("First you have to find the Perimeter");
            Console.WriteLine("Enter a number.");
            double sideA = findNumber(side1);
            Console.WriteLine("Enter a number.");
            double sideB = findNumber(side2);
            Console.WriteLine("Enter a number.");
            double sideC = findNumber(side3);

            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"The Area of a Triangle is {area}");
            Console.ReadLine();
        }
        private static void volumeHemisphere(double input) 
        {
            Console.WriteLine("\nPart 2: Volume of a Hemishpere.");
            Console.WriteLine("Please enter a number for the radius: ");
            double value2 = findNumber(input);
            double volume = (1.33333 * Math.PI * value2 * value2 * value2) / 2 ;
            Console.WriteLine($"The Volume of A Hemisphere Is {volume}");
            Console.ReadLine();
        }
        private static void findArea(double input)
        {
            Console.WriteLine("\nPart 1:Circumference and Area of a cirle.");
            Console.WriteLine("Please enter a number for the radius: ");
            double value = findNumber(input);
            double circum = 2 * Math.PI * value;
            Console.WriteLine($"The Circumference is {circum}");
            double area = Math.PI * value * value;
            Console.WriteLine($" The Area is {area}");
            Console.ReadLine();
        }
        private static double findNumber(double value)
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("You Must Enter A Postive Number");  //this works
                    return findNumber(value);
                }
                else
                    return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("You Must Enter A Number");  //this worked: It lets you try again until you 
                return findNumber(value);                      //get it right                                      
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number out of range");     //not sure how to test this 
                return findNumber(value);
            }
            finally
            {
                Console.Write("Okay, ");
            }
        }
    }
}
