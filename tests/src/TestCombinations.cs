using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestCombinations
    {
        [Test]
        public void TestCombinationsI2()
        {
            var m1 = Combinations2(new int[] {2, 10, 3, 1}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(1, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(1, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(1, m1.Current.Item2);
            Assert.False(m1.MoveNext());

            var m2 = Combinations2(new int[] {2}).GetEnumerator();
            Assert.False(m2.MoveNext());

            var m3 = Combinations2(new int[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }

        [Test]
        public void TestCombinationsI3()
        {
            var m1 = Combinations3(new int[] {2, 10, 3, 1}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.False(m1.MoveNext());

            var m2 = Combinations3(new int[] {2, 10}).GetEnumerator();
            Assert.False(m2.MoveNext());

            var m3 = Combinations3(new int[] {2}).GetEnumerator();
            Assert.False(m3.MoveNext());

            var m4 = Combinations3(new int[] {}).GetEnumerator();
            Assert.False(m4.MoveNext());
        }

        [Test]
        public void TestCombinationsI4()
        {
            var m1 = Combinations4(new int[] {2, 9, 3, 1, 7}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(1, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.False(m1.MoveNext());

            var m2 = Combinations4(new int[] {2, 9, 3}).GetEnumerator();
            Assert.False(m2.MoveNext());

            var m3 = Combinations4(new int[] {2, 9}).GetEnumerator();
            Assert.False(m3.MoveNext());

            var m4 = Combinations4(new int[] {2}).GetEnumerator();
            Assert.False(m4.MoveNext());

            var m5 = Combinations4(new int[] {}).GetEnumerator();
            Assert.False(m5.MoveNext());
        }
    }
}
