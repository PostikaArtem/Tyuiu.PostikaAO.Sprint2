using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PostikaAO.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 310 == y;
            res[1] = y + 310 != x;
            res[2] = x < y;
            res[3] = y > x;
            res[4] = x <= y;
            res[5] = y >= x;

            return res;
        }
    }
}
