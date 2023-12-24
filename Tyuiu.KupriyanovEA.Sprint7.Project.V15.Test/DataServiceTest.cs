using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint7.Project.V15.Lib;

namespace Tyuiu.KupriyanovEA.Sprint7.Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void SummDohod()
        {
            int[] array = { 1, 2, 3 };
            int res = ds.SummDohod(array);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void MinDohod()
        {
            int[] array = { 12, 2, 3, 1 };
            int res = ds.MinDohod(array);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void MaxDohod()
        {
            int[] array = { 12, 2, 3, 1 };
            int res = ds.MaxDohod(array);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
