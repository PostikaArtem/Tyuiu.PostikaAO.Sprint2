using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PostikaAO.Sprint2.Task1.V7.Lib;

namespace Tyuiu.PostikaAO.Sprint2.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Постика А. О. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 7                                                               *");
            Console.WriteLine("* Выполнил: Постика Артём Олегович | ИИПб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность  можно чередовать, но использовать один раз в        *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность*");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,     *");
            Console.WriteLine("* False, False, True, False), при a = 195, b = 16, c = 14, d = 45         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine(" A = " + a);
            Console.WriteLine(" B = " + b);
            Console.WriteLine(" C = " + c);
            Console.WriteLine(" D = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
