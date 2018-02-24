using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestEnumerate
    {
        [Test]
        public void TestEnumerate1()
        {
            var m1 = Enumerate(new string[] {"ab", "bc", "cd", "da"}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(0, m1.Current.Item1);
            Assert.AreEqual("ab", m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual("bc", m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual("cd", m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual("da", m1.Current.Item2);
            Assert.False(m1.MoveNext());

            var m2 = Enumerate(new string[] {"ab"}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(0, m2.Current.Item1);
            Assert.AreEqual("ab", m2.Current.Item2);
            Assert.False(m2.MoveNext());

            var m3 = Enumerate(new string[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }
    }
}
