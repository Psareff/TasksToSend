using System;

namespace Task3p7
{
    class Task3p7
    {
        public static void printArray(int[,] arr)
        {
            int size = arr.GetLength(0);
            Console.WriteLine("\"Spiral\" matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0, -5}", arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[,] fillArray(int[,] arr)
        {
            int prev = 1;
            int size = arr.GetLength(0);
            Console.WriteLine(size);
            for (int i = 0; i < Math.Ceiling(size / 2.0); i++)
            {
                for (int j = i; j < size - i; j++)
                {
                    arr[i, j] = prev;
                    prev++;
                }
                for (int j = i + 1; j < size - i; j++)
                {
                    arr[j, size - i - 1] = prev;
                    prev++;
                }
                for (int j = size - i - 2; j > i; j--)
                {
                    arr[size - i - 1, j] = prev;
                    prev++;
                }

                for (int j = size - 1 - i; j > i; j--)
                {
                    arr[j, i] = prev;
                    prev++;
                }
            }
            return arr;
        }
        public static void Main()
        {
            int size;
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size <= 0)
            {
                Console.WriteLine("Invalid size input, exit");
                return;
            }
            int[,] arr = new int[size, size];
            arr = fillArray(arr);
            printArray(arr);
          
        }
    }
}
