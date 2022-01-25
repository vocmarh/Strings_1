using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int theLongestWord = 0;
            int number = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > theLongestWord)
                {
                    theLongestWord = stringArray[i].Length;
                    number = i;
                }
            }

            Console.WriteLine($"Самое длинное слово: {stringArray[number]}");
            Console.ReadKey();
        }
    }
}