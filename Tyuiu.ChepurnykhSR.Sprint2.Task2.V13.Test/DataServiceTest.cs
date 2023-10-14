using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint2.Task2.V13.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
