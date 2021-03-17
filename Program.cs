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

            Console.WriteLine("Состав Слова:");

            foreach (char s in word)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine("\n");
            Console.WriteLine("В Слове обнаружено {0} букв!", LenghtOfWord);

        }
    }
}
