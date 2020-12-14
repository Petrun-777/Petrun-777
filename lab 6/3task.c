namespace Lab6
{
    class Task3
    {
        public static void task3()
        {
            Console.WriteLine("Task 3\n");
            Console.WriteLine("Enter numbers in array to check symmetry of the array: ");
            int[] myArray = new int[5];
            bool isMirror = false;
            int arrLength = myArray.Length;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < (myArray.Length) / 2; i++)
            {
                if (myArray[i] == myArray[--arrLength])
                {
                    isMirror = true;
                }
                else
                {
                    isMirror = false;
                    break;
                }
            }
            if (isMirror)
            {
                Console.WriteLine("Array is symetrical");
            }
            else
            {
                Console.WriteLine("Array isn't symetrical");
            }
            Console.WriteLine("\n");
        }
    }
}