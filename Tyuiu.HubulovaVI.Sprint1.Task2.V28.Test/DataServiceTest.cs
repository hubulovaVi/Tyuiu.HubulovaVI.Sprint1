using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint1.Task2.V28.Lib;
namespace Tyuiu.HubulovaVI.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(274, res);

        }
    }
}
