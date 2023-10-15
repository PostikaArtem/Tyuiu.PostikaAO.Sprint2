using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PostikaAO.Sprint2.Task5.V6.Lib;

namespace Tyuiu.PostikaAO.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCard()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестёрка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Шестёрка треф", ds.FindCardNameAndValue(2, 6));
            Assert.AreEqual("Шестёрка бубен", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("Шестёрка черв", ds.FindCardNameAndValue(4, 6));

            Assert.AreEqual("Семёрка пик", ds.FindCardNameAndValue(1, 7));
            Assert.AreEqual("Семёрка треф", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("Семёрка бубен", ds.FindCardNameAndValue(3, 7));
            Assert.AreEqual("Семёрка черв", ds.FindCardNameAndValue(4, 7));

            Assert.AreEqual("Восьмёрка пик", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("Восьмёрка треф", ds.FindCardNameAndValue(2, 8));
            Assert.AreEqual("Восьмёрка бубен", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("Восьмёрка черв", ds.FindCardNameAndValue(4, 8));

            Assert.AreEqual("Девятка пик", ds.FindCardNameAndValue(1, 9));
            Assert.AreEqual("Девятка треф", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("Девятка бубен", ds.FindCardNameAndValue(3, 9));
            Assert.AreEqual("Девятка черв", ds.FindCardNameAndValue(4, 9));

            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("Десятка треф", ds.FindCardNameAndValue(2, 10));
            Assert.AreEqual("Десятка бубен", ds.FindCardNameAndValue(3, 10));
            Assert.AreEqual("Десятка черв", ds.FindCardNameAndValue(4, 10));

            Assert.AreEqual("Валет пик", ds.FindCardNameAndValue(1, 11));
            Assert.AreEqual("Валет треф", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("Валет бубен", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("Валет черв", ds.FindCardNameAndValue(4, 11));

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("Дама треф", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("Дама бубен", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("Дама черв", ds.FindCardNameAndValue(4, 12));

            Assert.AreEqual("Король пик", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("Король треф", ds.FindCardNameAndValue(2, 13));
            Assert.AreEqual("Король бубен", ds.FindCardNameAndValue(3, 13));
            Assert.AreEqual("Король черв", ds.FindCardNameAndValue(4, 13));

            Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(1, 14));
            Assert.AreEqual("Туз треф", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("Туз бубен", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("Туз черв", ds.FindCardNameAndValue(4, 14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(-1, 3);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(3, 99);
            });
        }
    }
}
