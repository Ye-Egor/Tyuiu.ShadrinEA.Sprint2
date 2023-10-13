using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShadrinEA.Sprint2.Task2.V4.Lib;

namespace Tyuiu.ShadrinEA.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{ ds.CheckDotInShadedArea(x, y)}");
            Console.ReadKey();
        }
    }
}