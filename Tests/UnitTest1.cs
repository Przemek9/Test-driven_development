using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int expected = 3;
            int actual = Class1.Choose_max(3, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}
