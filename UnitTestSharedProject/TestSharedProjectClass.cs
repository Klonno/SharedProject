using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedProject;

namespace UnitTestSharedProject
{
    [TestClass]
    public class TestSharedProjectClass
    {
        [TestMethod]
        public void TestFoo()
        {
            var bar = new SharedProjectClass();
            Assert.AreEqual(bar.Foo(), 10);
        }
    }
}
