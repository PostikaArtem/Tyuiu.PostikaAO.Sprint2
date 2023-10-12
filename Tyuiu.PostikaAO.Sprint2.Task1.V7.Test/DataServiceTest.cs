using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint2.Task1.V7.Lib;

namespace Tyuiu.PostikaAO.Sprint2.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
