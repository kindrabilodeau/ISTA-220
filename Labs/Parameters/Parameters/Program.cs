#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is section I");
            int i = 0;
            Console.WriteLine(i);  //outputs 0
            Pass.Value(i);  //pass class value method 
            Console.WriteLine(i); //this returns 0 because value method does not return anything 
            i = Pass.ValueA(i);  //this returns 42 because it's what the method returnss
            Console.WriteLine(i);
            Console.WriteLine();

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number); 
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.WriteLine($"Number2 is {wi.Number2}");
            Console.WriteLine($"Number3 is {wi.Number3}");

            Console.WriteLine();

            Console.WriteLine("This is section j");
            int j = 13;
            Console.WriteLine(j);
            Pass.ValueB(ref j);
            Console.WriteLine(j);
            
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
