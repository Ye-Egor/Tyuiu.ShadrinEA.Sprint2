using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.ShadrinEA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValiCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x,y);
            double wait = 4.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValiCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double res = ds.Calculate(x,y);
            double wait = 4.8;
            Assert.AreEqual(wait, res);
        }
    }
}
