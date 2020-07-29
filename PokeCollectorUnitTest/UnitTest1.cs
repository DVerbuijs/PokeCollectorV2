using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeCollectorV2;
using PokeCollectorData;
using PokeCollectorLogic;
namespace PokeCollectorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPCV2()
        {
            Assert.AreEqual("Hello PokeCollector V2", MainWindow.message());
        }

        [TestMethod]
        public void TestDataPackage()
        {
            PCDTestClass class1 = new PCDTestClass();
            Assert.AreEqual("Pikachu", class1.Name);
        }
        [TestMethod]
        public void TestLogicPackage()
        {
            PCDTestClass class1 = new PCDTestClass();
            LogicPackageTestClass logicPackageTestClass = new LogicPackageTestClass();
            logicPackageTestClass.ChangeName("Ditto", class1);
            Assert.AreEqual("Ditto", class1.Name);
        }
    }
}
