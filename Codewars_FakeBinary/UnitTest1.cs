using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_FakeBinary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Shoudl_Be_StringEmpty()
        {
            Assert.AreEqual(string.Empty,new Kata().FakeBin(string.Empty));
        }

        [TestMethod]
        public void Input_0_Should_Be_0()
        {
            Assert.AreEqual("0",new Kata().FakeBin("0"));
        }

        [TestMethod]
        public void Input_5_Should_Be_1()
        {
            Assert.AreEqual("1",new Kata().FakeBin("5"));
        }

        [TestMethod]
        public void Input_01_Should_Be_00()
        {
            Assert.AreEqual("00",new Kata().FakeBin("01"));
        }

        [TestMethod]
        public void Input_05_Should_Be_01()
        {
            Assert.AreEqual("01",new Kata().FakeBin("05"));
        }

        [TestMethod]
        public void Input_12345678910_Should_Be_00001111100()
        {
            Assert.AreEqual("00001111100", new Kata().FakeBin("12345678910"));
        }

        [TestMethod]
        public void Input_321987_Should_Be_000111()
        {
            Assert.AreEqual("000111", new Kata().FakeBin("321987"));
        }

    }
}
