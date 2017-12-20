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
    }
}
