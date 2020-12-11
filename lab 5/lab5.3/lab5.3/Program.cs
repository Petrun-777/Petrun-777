using System;

namespace Petrun
{
    class Program
    {
        public enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of month");
            int x = Convert.ToInt32(Console.ReadLine());
            string y = Enum.GetName(typeof(Month), x - 1);
            Console.WriteLine("The {1} is {0} month", x, y);
        }
    }
}
