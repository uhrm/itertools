using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestFilter
    {
        [Test]
        public void TestFilter1()
        {
            var m1 = Filter(k => k%2==1, new int[] {2, 10, 3, 1, 4}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Filter(k => k%2==1, new int[] {2, 10}).GetEnumerator();
            Assert.False(m2.MoveNext());

            var m3 = Filter(k => k%2==1, new int[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }
    }
}
