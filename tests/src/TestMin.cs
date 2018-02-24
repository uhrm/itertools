using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestMin
    {
        [Test]
        public void TestMin1()
        {
            Assert.AreEqual(1, Min(new int[] {2, 10, 3, 1, 4}));
            Assert.AreEqual(1, Min(new int[] {1}));
            Assert.Throws<ArgumentException>(() => Min(new int[] {}));
        }

        [Test]
        public void TestMin2()
        {
            Assert.AreEqual(1, Min(new int[] {2, 10, 3, 1, 4}, 0));
            Assert.AreEqual(1, Min(new int[] {1}, 0));
            Assert.AreEqual(0, Min(new int[] {}, 0));
        }

        [Test]
        public void TestMinK1()
        {
            Assert.AreEqual("da", Min(new string[] {"ab", "bc", "cd", "da"}, s => s[1]));
            Assert.AreEqual("da", Min(new string[] {"da"}, s => s[1]));
            Assert.Throws<ArgumentException>(() => Min(new string[] {}, s => s[1]));
        }

        [Test]
        public void TestMinK2()
        {
            Assert.AreEqual("da", Min(new string[] {"ab", "bc", "cd", "da"}, s => s[1], "aa"));
            Assert.AreEqual("da", Min(new string[] {"da"}, s => s[1], "aa"));
            Assert.AreEqual("aa", Min(new string[] {}, s => s[1], "aa"));
        }
    }
}
