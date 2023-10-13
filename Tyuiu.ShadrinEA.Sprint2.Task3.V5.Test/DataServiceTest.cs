using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint2.Task3.V5.Lib;

namespace Tyuiu.ShadrinEA.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValiCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValiCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.083;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValiCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValiCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = -1100.01;
            Assert.AreEqual(wait, res);
        }
    }
}
