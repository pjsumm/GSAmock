using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrueTandem.GSAmock.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Assert
            Assert.AreEqual("True", "True");
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Assert
            Assert.AreEqual("True", "False");
        }
    }
}
