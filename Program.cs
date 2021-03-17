using System;

namespace SF4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Слово!");
            string word = Console.ReadLine();

            int LenghtOfWord = word.Length;

            string NewWord = "";

            for (int i = LenghtOfWord - 1; i >= 0; i--)
            {
                NewWord += word[i];
            }

            Console.WriteLine("Новое Слово: {0}.", NewWord);

        }
    }
}
