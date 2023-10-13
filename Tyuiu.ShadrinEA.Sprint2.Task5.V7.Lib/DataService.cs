using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShadrinEA.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int z = n + 1;
            int m = 0;
            if (z > 12)
            {
                m = z % 12;
            }
            else m = z;

            string res;

            switch(m)
            {
                case 1:
                    res = "Январь";
                    break;
                case 2:
                    res = "Февраль";
                    break;
                case 3:
                    res = "Март";
                    break;
                case 4:
                    res = "Апрель";
                    break;
                case 5:
                    res = "Май";
                    break;
                case 6:
                    res = "Июнь";
                    break;
                case 7:
                    res = "Июль";
                    break;
                case 8:
                    res = "Август";
                    break;
                case 9:
                    res = "Сентябрь";
                    break;
                case 10:
                    res = "Октябрь";
                    break;
                case 11:
                    res = "Ноябрь";
                    break;
                case 12:
                    res = "Декабрь";
                    break;
                default:
                    throw new ArgumentException("Eror");


            }
            return res;
        }

       
    }
}
