using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeCollectorV2;

namespace PokeCollectorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello PokeCollector V2", MainWindow.message());
        }
    }
}
