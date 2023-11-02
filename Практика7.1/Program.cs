using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строчку с символами: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите этот символ для разделения: ");
            char b = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string[] c = a.Split(b);

            Console.WriteLine("Результат разделения:");
            foreach (string n in c)
            {
                Console.WriteLine(n);
            }
        }
    }
}
