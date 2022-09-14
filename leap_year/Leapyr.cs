using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Leapyr
    {
        static void Main(string[] args)
        {
            int year = 2022;
            if ((year % 4== 0) && ((year % 100!=0) || (year%400==0)))
            {
                Console.WriteLine($"{year}is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is a not leap year");
            }

        }
    }
}
