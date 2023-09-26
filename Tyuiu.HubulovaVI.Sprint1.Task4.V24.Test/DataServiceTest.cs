using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint1.Task4.V24.Lib;

namespace Tyuiu.HubulovaVI.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double otv = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(otv, res);

        }
    }
}
