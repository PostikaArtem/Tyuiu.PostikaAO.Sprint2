using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PostikaAO.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res = "";

            switch (value2)
            {
                case 6:
                    res += "Шестёрка";
                    break;
                case 7:
                    res += "Семёрка";
                    break;
                case 8:
                    res += "Восьмёрка";
                    break;
                case 9:
                    res += "Девятка";
                    break;
                case 10:
                    res += "Десятка";
                    break;
                case 11:
                    res += "Валет";
                    break;
                case 12:
                    res += "Дама";
                    break;
                case 13:
                    res += "Король";
                    break;
                case 14:
                    res += "Туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение {value2}");
            }

            switch (value1)
            {
                case 1:
                    res += " пик";
                    break;
                case 2:
                    res += " треф";
                    break;
                case 3:
                    res += " бубен";
                    break;
                case 4:
                    res += " черв";
                    break;
                default:
                    throw new ArgumentException($"Масть карты должна быть от 1 до 4. Значение {value1}");
            }

            return res;
        }
    }
}
