using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint2.Task6.V8.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("4.10.2023", ds.FindDateOfPreviousDay(2023, 10, 5));
        }
    }
}
