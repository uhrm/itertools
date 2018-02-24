using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestRange
    {
        [Test]
        public void TestRange1()
        {
            var m1 = Range(4).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(0, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Range(0).GetEnumerator();
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestRange2()
        {
            var m1 = Range(1, 4).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Range(4, 1).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(4, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(3, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Range(1, 1).GetEnumerator();
            Assert.False(m3.MoveNext());
        }

        [Test]
        public void TestRange3()
        {
            var m1 = Range(1, 4, 2).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Range(4, 1, -2).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(4, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Range(1, 1, 0).GetEnumerator();
            Assert.False(m3.MoveNext());

            Assert.Throws<ArgumentOutOfRangeException>(() => Range(1, 4, -1).GetEnumerator().MoveNext());
            Assert.Throws<ArgumentOutOfRangeException>(() => Range(1, 4, 0).GetEnumerator().MoveNext());
            Assert.Throws<ArgumentOutOfRangeException>(() => Range(4, 1, 1).GetEnumerator().MoveNext());
            Assert.Throws<ArgumentOutOfRangeException>(() => Range(4, 1, 0).GetEnumerator().MoveNext());
        }
    }
}
