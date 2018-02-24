using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestCycle
    {
        [Test]
        public void TestCycle1()
        {
            var m1 = Cycle(new int[] {2, 10, 3}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            // let's stop somewhere...

            var m2 = Cycle(new int[] {2}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            // let's stop somewhere...

            Assert.Throws<ArgumentException>(() => Cycle(new int[] {}).GetEnumerator().MoveNext());
        }
    }
}
