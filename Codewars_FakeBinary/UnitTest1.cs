using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_FakeBinary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Shoudl_Be_StringEmpty()
        {
            //arrange
            var input = string.Empty;
            var kata = new Kata();
            //acctual
            var fakeResult = kata.FakeBin(input);
            //assert
            Assert.AreEqual(string.Empty,fakeResult);
        }
    }
}
