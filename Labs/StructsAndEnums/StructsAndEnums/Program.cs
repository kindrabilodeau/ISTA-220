#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    public class Program
    {
        static void doWork()
        {
            Month first = Month.December; //using type enum
            Console.WriteLine(first);   //prints december
            Month second = Month.January; //using type enum
            Console.WriteLine(second);   
            first++;
            second++;
            Console.WriteLine(first);  //prints 12, there is no name for the 12th month (until we gave it a name) 
            Console.WriteLine(second); //prints Febuary
            first++;                   //Add a number to 12 
            Console.WriteLine(first);  //prints 13, there is no 13th month
            second++;                  //Adds a month to Febuary 
            Console.WriteLine(second); //prints March 

            Console.WriteLine();
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate); //prints jan 1 1990

            Date weddingAnniversary = new Date(2015, Month.November, 13);
            Console.WriteLine(weddingAnniversary);

            Date copy = weddingAnniversary;
            Console.WriteLine(copy);                        //prints 2015, 11, 13

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"1. {weddingAnniversary}"); //prints december 
            Console.WriteLine($"2. {copy}");               //prints november because its a copy
        }                                           //structs exist on the stack which makes copies
                                                    //value types holds the values
                                                    //reference types holds the memory address 

        static void Main()
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
