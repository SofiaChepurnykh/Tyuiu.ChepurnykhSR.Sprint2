using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint2.Task5.V14.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Вторник", ds.FindDayName(9));
            Assert.AreEqual("Среда", ds.FindDayName(10));
        }
    }
}
