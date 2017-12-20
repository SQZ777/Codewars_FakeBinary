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

        
        public void Input_5_Should_Be_1()
        {
            Assert.AreEqual("1",new Kata().FakeBin("5"));
        }

        [TestMethod]
        public void Input_01_Should_Be_00()
        {
            Assert.AreEqual("00",new Kata().FakeBin("01"));
        }


    }
}
