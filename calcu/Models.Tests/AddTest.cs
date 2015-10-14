using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var caculator = new Calculator();
            var result = caculator.Add(2, 4);
            Assert.AreEqual(6, result);
        }
    }
}
