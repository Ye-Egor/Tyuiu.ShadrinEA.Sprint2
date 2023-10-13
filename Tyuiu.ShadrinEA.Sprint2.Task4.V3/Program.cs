using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.ShadrinEA.Sprint2.Task4.V3
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c ипоьзовнием  *");
            Console.WriteLine("* тернарного оператора,где пол. водит знач. х и у.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{ ds.Calculate(x,y)}");
            Console.ReadKey();
        }
    }
}
