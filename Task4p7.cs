using System;

namespace Task4p7
{
    class Task4p7
    {

        public static void printArray(int[,] arr)
        {
            int sizeX = arr.GetLength(0);
            int sizeY = arr.GetLength(1);
            Console.WriteLine("\"Spiral\" matrix: ");
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                    Console.Write("{0, -5}", arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int [,] fillArray (int[,] arr)
        {
            int value = 1;
            int i = 0;
            int sizeX = arr.GetLength(0);
            int sizeY = arr.GetLength(1);
            while (sizeX * sizeY > value)
            {
                for (int j = i; j < sizeY - i; j++)
                {
                    arr[i, j] = value;
                    if (sizeX * sizeY <= value) return arr;
                    value++;
                }
                for (int j = i + 1; j < sizeX - i; j++)
                {
                    arr[j, sizeY - i - 1] = value;
                    if (sizeX * sizeY <= value) return arr;
                    value++;

                }
                for (int j = sizeY - i - 2; j > i; j--)
                {
                    arr[sizeX - i - 1, j] = value;
                    if (sizeX * sizeY <= value) return arr;
                    value++;

                }

                for (int j = sizeX - 1 - i; j > i; j--)
                {
                    arr[j, i] = value;
                    if (sizeX * sizeY <= value) return arr;
                    value++;
                }
                i++;
            }
            if (sizeX == sizeY) arr[sizeX/2, sizeY/2] = sizeX*sizeY;
            return arr;
        }

        public static void Main()
        { 
            int sizeX, sizeY;
            Console.WriteLine("Enter length of an \"spiral\" array");
            sizeX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of an \"spiral\" array");
            sizeY = Convert.ToInt32(Console.ReadLine());
            if (sizeX <= 0 || sizeY <= 0)
            {
                Console.WriteLine("Invalid size input, exit");
                return;
            }
            int[,] arr = new int[sizeY, sizeX];
            arr = fillArray(arr);
            printArray(arr);

        }
    }
}