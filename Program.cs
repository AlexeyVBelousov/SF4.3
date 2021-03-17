using System;

namespace SF4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine(array[0, 0]);

            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
