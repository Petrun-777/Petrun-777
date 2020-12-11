using System;
using System.Collections.Generic;

namespace Petrun
{
    class Program
    {
        public static List<string> strings;
        static void Main(string[] args)
        {
            strings = new List<string>(100);
            Random random = new Random();
            string trm;

            for (int i = 0; i < 100; i++)
            {
                trm = "";
                for (int j = 0; j < 4; j++)
                {
                    trm += (char)((random.Next() % 26) + 65);
                }

                strings.Add(trm);
            }

            Console.WriteLine("Symbols before transform: {0}", strings.Count);

            while (strings.FindIndex(l => l[0] == 'Z') != -1)
            {
                strings.RemoveAt(strings.FindIndex(l => l[0] == 'Z'));
            }

            Console.WriteLine("Symbols after transform: {0}", strings.Count);

            strings.Sort();
            for (int i = 0; i < strings.Count / 2; i++)
            {
                trm = strings[i];
                strings[i] = strings[strings.Count - 1 - i];
                strings[strings.Count - 1 - i] = trm;
            }

            while (true)
            {
                Console.WriteLine("\nEnter page number: ");
                if (!int.TryParse(Console.ReadLine(), out int Numers))
                    break;
                Numers--;
                Page(Numers);
            }
        Висновок:
            return;
        }
        public static void Page(int Num)
        {
            if (Num * 5 > strings.Count
                || Num < 0)
            {
                Console.Write("Error");
                return;
            }
            for (int i = Num * 5; !(i >= (Num * 5) + 5 || i >= strings.Count); i++)
            {
                Console.Write(strings[i] + "  ");
            }
            return;
        }
    }
}

