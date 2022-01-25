using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            bool b = true;
            str = str.ToLower();
            str = str.Replace(" ", string.Empty);
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    b = false;
            }

            Console.WriteLine(b ? "является паллиндромом" : "не является паллиндромом");
            Console.ReadKey();
        }
    }
}