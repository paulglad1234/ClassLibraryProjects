using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeClassLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDayMade()
        {
            TimeClassLibrary.Day dExpected = new TimeClassLibrary.Day("9", "57");
            string h = "9";
            string m = "57";
            TimeClassLibrary.Day dActual = new TimeClassLibrary.Day(h, m);
            Assert.AreEqual(dExpected, dActual);
        }
    }
}
