using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShadrinEA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ShadrinEA.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Сколько прошло месяцев:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("год:");
            int startYear = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{ ds.FindMonthName(startYear, n)}");
            Console.ReadKey();

        }
    }
}
