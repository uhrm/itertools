using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestCount
    {
        [Test]
        public void TestCount1()
        {
            var m1 = Count(1, 2).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(5, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(7, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(11, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(13, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(15, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(17, m1.Current);
            Assert.True(m1.MoveNext());
            // let's stop somewhere...

            var m2 = Count(1, 0).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(1, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(1, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(1, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(1, m2.Current);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(1, m2.Current);
            Assert.True(m2.MoveNext());
            // let's stop somewhere...

            var m3 = Count(1, -1).GetEnumerator();
            Assert.True(m3.MoveNext());
            Assert.AreEqual(1, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(0, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(-1, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(-2, m3.Current);
            Assert.True(m3.MoveNext());
            Assert.AreEqual(-3, m3.Current);
            Assert.True(m2.MoveNext());
            // let's stop somewhere...
        }
    }
}
