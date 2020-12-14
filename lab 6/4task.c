namespace Lab6
{
    class Task4
    {
        public static void task4()
        {
            Console.WriteLine("Task 4\n");
            int n, m;
            int a = 0;
            Console.WriteLine("Enter size of array: ");
            Console.Write("M = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            int[,] myArray = new int[m, n];
            Random random = new Random();
            Console.WriteLine("\nCreated array: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArray[i, j] = random.Next(10, 99);
                    Console.Write(myArray[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nThe biggest value of each line: ");
            for (int i = 0; i < m; i++)
            {
                int max = myArray[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (myArray[i, j] > max)
                    {
                        max = myArray[i, j];
                    }
                }
                a++;
                Console.WriteLine($"{a} line: " + max);
            }
            Console.WriteLine("\n");
        }
    }
}