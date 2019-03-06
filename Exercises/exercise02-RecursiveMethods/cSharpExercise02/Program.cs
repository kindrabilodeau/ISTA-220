using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpExercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Part 1:Enter Score for Letter Grade:");
            string input = Console.ReadLine();
            int output = int.Parse(input);
            char grade = getGrade(output);
            Console.WriteLine($"The letter grade is {grade}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();


            Console.WriteLine("\nPart2: Enter Ten Scores for Average and Letter Grade:");
            double start = 1;
            double end = 10;
            double sum = 0;
            double add = findAverage(start, end, sum);
            Console.WriteLine($"The Average is {add}");
            Console.WriteLine($"The Letter Grade is {getGrade(add)}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("\nPart3: Average a Specfic Number of Scores");
            int tests = 0;
            int howMany = noOfTests(tests);
            double value = findAverage(start, howMany, sum);
            Console.WriteLine($"The Average of the {howMany} Tests is {value}");
            char letter = getGrade(value);
            Console.WriteLine($"The Letter Grade {letter}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("\nPart 4: Average a Non-Specfic Number of Scores");
            double scores = 0;
            int stop = -1;
            double findNumber =  nonSpecfic(scores, stop, sum);
           //double avgScores = findAverage(start, findNumber, findNumber);
            Console.WriteLine($"The Average is {findNumber}");      
            char letterGrade = getGrade(findNumber);
            Console.WriteLine($"The Letter Grade is {letterGrade}");
            Console.WriteLine("Press Enter To Exit:");
            Console.ReadLine();

      



        }

        private static double nonSpecfic(double start, int stop, double total)
        {
            Console.Write("Enter Test Score, Type -1 to Stop:");
            int input = int.Parse(Console.ReadLine());
            int end = -1;
            if (input != end)
            {
                double value = input;
                return nonSpecfic(start + 1, stop,  value + total);
            }
            else
                return total / start;

        }

        private static int noOfTests(int tests)
        {
            Console.Write("Enter Number of Tests:");
            int number = int.Parse(Console.ReadLine());
            int value = number;
            return value;

            
        }

        private static double findAverage(double start, double end, double sum)
        {
            if (start <= end)
            {
                Console.Write("Enter Test Score:");
                double score = double.Parse(Console.ReadLine());
                double value2 = score;
                return findAverage(start + 1, end, value2 + sum);
            }
            else
                return sum / end; 

        


        }

        private static char getGrade(double output)
        {


            if (output >= 90 && output <= 100)                
            {
                return 'A';
            }
            else if (output < 90 && output >= 80)
            {
                return 'B';
            }
            else if (output < 80 && output >= 70)
            {
                return 'C';
            }
            else if (output < 70 && output >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}
