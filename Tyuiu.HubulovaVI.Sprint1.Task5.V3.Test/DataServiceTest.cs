using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint1.Task5.V3.Lib;

namespace Tyuiu.HubulovaVI.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 13650964;
            int b = 9;
            var res = ds.Calculate(k);
            Assert.AreEqual(res, b);

        }
    }
}
