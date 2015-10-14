using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestParseDivde()
        {
            var commandParser = new CommandParser();
            string testInput = "8/2";
            var result = commandParser.Parse(testInput);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestParseMultiply()
        {
            var commandParser = new CommandParser();
            string testInput = "2*8";
            var result = commandParser.Parse(testInput);
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void TestParseAdd()
        {
            var commandParser = new CommandParser();
            string testInput = "2+6";
            var result = commandParser.Parse(testInput);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestParseSubtract()
        {
            var commandParser = new CommandParser();
            string testInput = "2-6";
            var result = commandParser.Parse(testInput);
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void TestParseMod()
        {
            var commandParser = new CommandParser();
            string testInput = "8%3";
            var result = commandParser.Parse(testInput);
            Assert.AreEqual(2, result);
        }


    }
}
