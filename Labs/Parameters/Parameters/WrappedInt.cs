namespace Parameters
{
    class WrappedInt
    {
        public int Number;
        public int Number2;
        public int Number3 = 666;

        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
    }
}
