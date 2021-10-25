using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRClasssLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRClasssLib.Tests
{
    [TestClass]
    public class DRClassTests
    {
        private DRClass _drClass;

        [TestInitialize]
        public void SetUp()
        {
            _drClass = new DRClass(1, "Bobob", " dadadada", 2323, 1999);
        }

        [TestMethod]
        public void TestDrClassConstructor()
        {
            DRClass drC = new DRClass(1, "Bobob", "dadadad", 2323, 1999);
            Assert.AreEqual(1, drC.Id);
            Assert.AreEqual("Bobob", drC.Artist);

        }
    }
}