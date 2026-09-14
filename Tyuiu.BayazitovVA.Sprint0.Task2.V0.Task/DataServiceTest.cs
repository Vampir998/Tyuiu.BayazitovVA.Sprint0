using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BayazitovVA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BayazitovVA.Sprint0.Task2.V0.Task
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вадим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Вадим", res);
        }
    }
}
