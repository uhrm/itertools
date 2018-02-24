using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestChain
    {
        [Test]
        public void TestChain1()
        {
            var m1 = Chain(new int[] {2, 10, 3}, new int[] {1, 12, 7}, new int[] {9, 5, 8}, new int[] {11, 4, 6}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(12, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(7, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(5, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(8, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(11, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(4, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(6, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Chain(new int[] {2, 10, 3}, new int[] {}, new int[] {}, new int[] {11, 4, 6}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(10, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(3, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(11, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(4, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(6, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Chain(new int[] {}, new int[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }
    }
}
