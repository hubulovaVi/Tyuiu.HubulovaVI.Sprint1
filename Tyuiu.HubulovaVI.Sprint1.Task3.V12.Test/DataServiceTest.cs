using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint1.Task3.V12.Lib;

namespace Tyuiu.HubulovaVI.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int katet1 = 2, katet2 = 3, result = 3;
            DataService ds = new DataService();
            Assert.AreEqual(result, ds.TriangleArea(katet1, katet2));
        }
    }
}
