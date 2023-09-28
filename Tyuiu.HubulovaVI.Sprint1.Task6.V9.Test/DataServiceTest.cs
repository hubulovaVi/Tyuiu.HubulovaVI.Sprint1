using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint1.Task6.V9.Lib;

namespace Tyuiu.HubulovaVI.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "привет";
            string res = ds.MoveLetterToStart(value);
            string wait = "тприве";
            Assert.AreEqual(wait, res);
        }
    }
}
