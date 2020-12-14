namespace Lab6
{
    class Task1
    {
        public static void task1()
        {
            Console.WriteLine("Task 1\n");
            int[] myArray = new int[5] { 2, 3, 4, 5, 6 };
            Console.WriteLine("Initial array: ");
            for (int i = 0; i < myArray.Length; i++);
            {
                Console.WriteLine($"Index [{i}] = " + myArray[i]);

            }
            Console.WriteLine("Changed array: ");
            for (int i = 0; i < myArray.Length; i++);
            {
                Console.WriteLine($"Index [{i}] = " + Math.Pow(myArray[i], 3));
            }
            Console.WriteLine("\n");
        }
    }
}