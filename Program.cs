using System;

namespace SF4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4};

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("");

            for (int i = 0; i < arr.Length; i++)
            {
                int minarr = arr[i];

                for (int k = i; k < arr.Length; k++)
                {
                    if (arr[k] < minarr)
                    {
                        int swap = arr[i];
                        arr[i] = arr[k];
                        arr[k] = swap;
                        minarr = arr[i];
                    }
                }
            }

            Console.WriteLine("Отсортированный массив:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
