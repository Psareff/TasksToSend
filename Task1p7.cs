using System;
namespace Task1p7 
{
    class Task1p7
    {
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
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = i+1;
            Console.Write("Reversed array: ");
            foreach (int i in arr.Reverse<int>())
                Console.Write(i + $" ");
        }
     }
}
