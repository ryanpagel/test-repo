using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new Class1();
            var response = obj.Test();

            Assert.AreEqual("this is a test", response);
        }
    }
}