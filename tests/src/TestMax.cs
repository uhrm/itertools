using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestMax
    {
        [Test]
        public void TestMax1()
        {
            Assert.AreEqual(10, Max(new int[] {2, 10, 3, 1, 4}));
            Assert.AreEqual(10, Max(new int[] {10}));
            Assert.Throws<ArgumentException>(() => Max(new int[] {}));
        }

        [Test]
        public void TestMax2()
        {
            Assert.AreEqual(10, Max(new int[] {2, 10, 3, 1, 4}, 0));
            Assert.AreEqual(10, Max(new int[] {10}, 0));
            Assert.AreEqual(0, Max(new int[] {}, 0));
        }

        [Test]
        public void TestMaxK1()
        {
            Assert.AreEqual("cd", Max(new string[] {"ab", "bc", "cd", "da"}, s => s[1]));
            Assert.AreEqual("cd", Max(new string[] {"cd"}, s => s[1]));
            Assert.Throws<ArgumentException>(() => Max(new string[] {}, s => s[1]));
        }

        [Test]
        public void TestMaxK2()
        {
            Assert.AreEqual("cd", Max(new string[] {"ab", "bc", "cd", "da"}, s => s[1], "aa"));
            Assert.AreEqual("cd", Max(new string[] {"cd"}, s => s[1], "aa"));
            Assert.AreEqual("aa", Max(new string[] {}, s => s[1], "aa"));
        }
    }
}
