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
            _drClass = new DRClass(1, "Bobob", " dadadada", 2323, 1999, userId: 1);
        }

        [TestMethod]
        public void TestDrClassConstructor()
        {
            DRClass drC = new DRClass(1, "Bobob", "dadadad", 2323, 1999, userId: 1);
            Assert.AreEqual(1, drC.Id);
            Assert.AreEqual("Bobob", drC.Title);
            Assert.AreEqual("dadadad", drC.Artist);
            Assert.AreEqual(2323, drC.Duration);
            Assert.AreEqual(1999, drC.PublicationYear);
            Assert.AreEqual(1, drC.UserId);
        }

        [TestMethod]
        public void TestDrClassTitle()
        {
            _drClass.Title = "Bobob";
            Assert.AreEqual("Bobob", _drClass.Title);
            Assert.ThrowsException<ArgumentNullException>(() => _drClass.Title = null);
            Assert.ThrowsException<ArgumentException>(() => _drClass.Title = "a");

        }

        [TestMethod]
        public void TestDrClassArtist()
        {
            _drClass.Artist = "dadadad";
            Assert.AreEqual("dadadad", _drClass.Artist);
            Assert.ThrowsException<ArgumentNullException>(() => _drClass.Artist = null);
            Assert.ThrowsException<ArgumentException>(() => _drClass.Artist = "a");

        }

        [TestMethod]
        public void TestDrClassDuration()
        {
            _drClass.Duration = 100;
            Assert.AreEqual(100, _drClass.Duration);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _drClass.Duration = 0);

        }

        [TestMethod]
        public void TestDrClassPublicationYear()
        {
            _drClass.PublicationYear = 1999;
            Assert.AreEqual(1999, _drClass.PublicationYear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _drClass.PublicationYear = 2022);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _drClass.PublicationYear = 1899);

        }

    }
}