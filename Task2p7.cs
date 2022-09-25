using System;
namespace Task2p7
{
    class Task2p7
    {
        public static void Main()
        {
            int size;
            Console.Write("Enter size of matrix (>=3): ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size < 3)
            {
                Console.WriteLine("Invalid size, less than 3");
                return;
            }
            int[,] arr = new int[size, size];

            for (int i = 0; i < size; i++) 
                for (int j = i; j < size; j++)
                    arr[i, j] = 1;
            for (int i = 0; i < size - 1; i++)
                arr[i+1, i] = 1;

            Console.WriteLine("Shifted identity matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(arr[i, j] + $" ");
                Console.WriteLine();
            }
        }
    }
}
