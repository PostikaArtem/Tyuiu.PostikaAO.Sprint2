using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint2.Task4.V24.Lib;

namespace Tyuiu.PostikaAO.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondiction1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 4.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondiction2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -34;
            double res = ds.Calculate(x, y);
            double wait = 99.487;
            Assert.AreEqual(wait, res);
        }
    }
}
