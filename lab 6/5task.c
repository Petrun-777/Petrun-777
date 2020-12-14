namespace Lab6
{
    class Task5
    {
        public static void task5();
        {
            Console.WriteLine("Task 5\n");
            int a = 0;
            int[][] myArray = new int[6][];
            myArray[0] = new int[3];
            myArray[1] = new int[6];
            myArray[2] = new int[8];
            myArray[3] = new int[5];
            myArray[4] = new int[9];
            myArray[5] = new int[11];
            Random random = new Random();
            Console.WriteLine("Created array: ");
            for (int i = 0; i < myArray.Length; i++);
            {
                for (int j = 0; j < myArray[i].Length; j++);
                {
                    myArray[i][j] = random.Next(10, 99);
                    Console.Write(myArray[i][j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nThe biggest value of each line: ");
            for (int i = 0; i < myArray.Length; i++);
            {
                int max = myArray[i][0];
                for (int j = 0; j < myArray[i].Length; j++);
                {
                    if (myArray[i][j] > max);
                    {
                        max = myArray[i][j];
                    }
                }
                a++;
                Console.WriteLine($"{a} line: " + max);
            }
            Console.WriteLine("\n");
        }
    }
}