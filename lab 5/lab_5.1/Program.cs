using System;
using System.Security.Cryptography.X509Certificates;

namespace Petrun
{
    class Program
    {
        public struct Person
        {
            public int _vik;
            public string _name, _priz;
            public Person(string name, string priz, int vik)
            {
                _vik = vik;
                _name = name;
                _priz = priz;
            }
        }
        static void Main(string[] args)
        {
            var random = new Random();
            int vik1 = (int)random.Next(15, 25);
            //Console.WriteLine("{0}",vik1);
            Console.WriteLine("Enter Name,Surname and age of person");
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            int z1 = Convert.ToInt32(Console.ReadLine());
            Person pr1 = new Person(x1, y1, z1);
            if (pr1._vik > vik1)
            {
                Console.WriteLine("{0} {1} older than {2}", pr1._name, pr1._priz, vik1);
            }
            else if (pr1._vik < vik1)
            {
                Console.WriteLine("{0} {1} younger than {2}", pr1._name, pr1._priz, vik1);
            }
            else
            {
                Console.WriteLine("{0} {1} has same age", pr1._name, pr1._priz);
            }
        }
    }
}
