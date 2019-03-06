using System;

namespace Parameters
{
    class Pass
    {
        public static void Value( int param)
        {
            param = 42 + param;              //This code stays in this block of code 
            Console.WriteLine($"  In Value Method, param is {param}"); //and param is discarded
        }
        public static int ValueA(int param)
        {
            Console.WriteLine($"   In ValueA, param is {param}");
            return (42);
        }
        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
        
        public static void ValueB(ref int param)
        {
            param = 42; 
        }
    }
}
