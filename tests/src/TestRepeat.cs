using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestRepeat
    {
        [Test]
        public void TestRepeat1()
        {
            var m1 = Repeat(1).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.True(m1.MoveNext());
            // let's stop somewhere...
        }

        [Test]
        public void TestRepeat2()
        {
            var m1 = Repeat("a", 9).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual("a", m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Repeat("a", 0).GetEnumerator();
            Assert.False(m1.MoveNext());

            Assert.Throws<ArgumentOutOfRangeException>(() => Repeat("a", -1).GetEnumerator().MoveNext());
        }
    }
}
