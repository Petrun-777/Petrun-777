using System;

namespace Petrun
{
    class Program
    {
        public enum LongRange : long { Min = -9223372036854775808, Max = 9223372036854775807 }
        static void Main(string[] args)
        {
            Console.WriteLine("The MIN is {0} and MAX is {1}", (long)LongRange.Min, (long)LongRange.Max);
        }
    }
}
