namespace Lab6
{
    class Task2
    {
        public static void task2()
        {
            Console.WriteLine("Task 2\n");
            Random random = new Random();
            int[] myArray = new int[15];
            int prime = 0;
            int NotPrime = 0;

            Console.WriteLine("It' array filled with random numbers: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(60);
                Console.Write(" | " + myArray[i]);
            }
            Console.WriteLine("\n\nPrime numbers marked as '----' ");
            Console.WriteLine("\n\n");
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] % 2 == 0)
                {
                    Console.WriteLine($"Number {myArray[i]} not a prime number");
                    NotPrime += 1;
                }
                else
                {
                    Console.WriteLine($"Number {myArray[i]} is a prime number ----");
                    prime += 1;
                }
            }
            Console.WriteLine($"\nAmount of prime numbers is : {prime}");
            Console.WriteLine($"Amount of  not prime numbers is : {NotPrime}");
            Console.WriteLine("\n");
        }
    }
}