using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.ChepurnykhSR.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x == 3) && (y >= 6) && (y <= 11) && (y != 7) && (y != 8) && (y != 9) && (y != 10)) || ((x == 4) && (y >= 2) && (y <=11) && (y != 9) && (y != 10)) || ((x == 5) && (y >= 6) && (y <= 11) && (y != 7) && (y != 8) && (y != 9) && (y != 10)) || ((x == 6) && (y >= 6) && (y <= 11) && (y != 7) && (y != 8) && (y != 9)) || ((x == 7) && (y >= 6) && (y <= 21) && (y != 7) && (y != 8) && (y != 9)) || ((x == 8) && (y >= 5) && (y <= 12)) || ((x == 9) && (y >= 3) && (y <= 12)) || ((x == 10) && (y >= 3) && (y <= 10)) || ((x == 11) && (y >= 3) && (y <= 10)) || ((x == 12) && (y >= 3) && (y <= 10)) || ((x == 13) && (y >= 6) && (y <= 8)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
