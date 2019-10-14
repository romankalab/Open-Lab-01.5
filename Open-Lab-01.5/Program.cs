using System;

namespace Open_Lab_01._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BoolReverse(true));
        }
        private static bool BoolReverse(bool boolean)
        {
            return !boolean;
        }
    }
}
