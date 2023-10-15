using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PostikaAO.Sprint2.Task4.V24.Lib
{
    public class DataService : ISprint2Task4V24
    {
        public double Calculate(double x, double y)
        {
            double z = x + 2 > y + 24 ? (Math.Pow(y, 2) + Math.Pow(Math.Cos(x), 2) + 9) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12) : x * Math.Pow((y + 1) / (x + 2), x); //

            return Math.Round(z, 3);
        }
    }
}
