using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PostikaAO.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            double xMin = -(2 * Math.Sqrt(5) / 5);
            double yMax = Math.Sqrt(5) / 5;


            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 && (x >= xMin) && (x <= 1) && (y >= -1) && (y <= yMax))
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
