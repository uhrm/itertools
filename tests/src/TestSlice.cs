using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestSlice
    {
        [Test]
        public void TestSlice1()
        {
            var m1 = Slice(new int[] {2, 10, 3, 1, 4}, 3).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Slice(new int[] {2, 10}, 3).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(10, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Slice(new int[] {2, 10}, 0).GetEnumerator();
            Assert.False(m3.MoveNext());

            Assert.Throws<ArgumentOutOfRangeException>(() => Slice(new int[] {2, 10}, -1).GetEnumerator().MoveNext());
        }

        [Test]
        public void TestSlice2()
        {
            var m1 = Slice(new int[] {2, 10, 3, 1, 4}, 1, 3).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Slice(new int[] {2, 10}, 1, 3).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(10, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Slice(new int[] {2, 10, 3, 1, 4}, 1, null).GetEnumerator();
            Assert.True(m3.MoveNext());
            Assert.AreEqual(10, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(3, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(1, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(4, m3.Current);
            Assert.False(m3.MoveNext());

            var m4 = Slice(new int[] {2, 10}, 1, null).GetEnumerator();
            Assert.True(m4.MoveNext());
            Assert.AreEqual(10, m4.Current);
            Assert.False(m4.MoveNext());

            var m5 = Slice(new int[] {2, 10}, 3, null).GetEnumerator();
            Assert.False(m5.MoveNext());

            Assert.Throws<ArgumentOutOfRangeException>(() => Slice(new int[] {2, 10}, -1, null).GetEnumerator().MoveNext());
            Assert.Throws<ArgumentOutOfRangeException>(() => Slice(new int[] {2, 10}, 1, 0).GetEnumerator().MoveNext());
        }

        [Test]
        public void TestSlice3()
        {
            var m1 = Slice(new int[] {2, 10, 3, 1, 4}, 1, 5, 2).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Slice(new int[] {2, 10}, 3, 5, 2).GetEnumerator();
            Assert.False(m2.MoveNext());

            Assert.Throws<ArgumentOutOfRangeException>(() => Slice(new int[] {2, 10}, 1, 2, 0).GetEnumerator().MoveNext());
            Assert.Throws<ArgumentOutOfRangeException>(() => Slice(new int[] {2, 10}, 1, 2, -1).GetEnumerator().MoveNext());
        }
    }
}
