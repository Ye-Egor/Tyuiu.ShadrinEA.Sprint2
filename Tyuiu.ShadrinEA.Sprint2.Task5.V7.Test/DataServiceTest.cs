using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ShadrinEA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValiCondition1()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 0;
            string wait = "Январь";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition2()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 1;
            string wait = "Февраль";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition3()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 2;
            string wait = "Март";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition4()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 3;
            string wait = "Апрель";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition5()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 4;
            string wait = "Май";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition6()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 5;
            string wait = "Июнь";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition7()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 6;
            string wait = "Июль";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition8()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 7;
            string wait = "Август";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition9()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 8;
            string wait = "Сентябрь";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition10()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 9;
            string wait = "Октябрь";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition11()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 10;
            string wait = "Ноябрь";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
        [TestMethod]
        public void ValiCondition12()
        {
            DataService ds = new DataService();
            int startYear = 1990;
            int n = 11;
            string wait = "Декабрь";
            Assert.AreEqual(wait, (object)ds.FindMonthName(startYear, n));
        }
    }
}
