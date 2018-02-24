using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestZipLongest
    {
        [Test]
        public void TestZipLongest2()
        {
            var m1 = ZipLongest(new int[] {2, 10, 3, 1, 12, 7}, new int[] {9, 5, 8, 11}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(11, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(12, m1.Current.Item1);
            Assert.AreEqual(0, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(7, m1.Current.Item1);
            Assert.AreEqual(0, m1.Current.Item2);
            Assert.False(m1.MoveNext());

            var m2 = ZipLongest(new int[] {2, 10, 3}, new int[] {}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current.Item1);
            Assert.AreEqual(0, m2.Current.Item2);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(10, m2.Current.Item1);
            Assert.AreEqual(0, m2.Current.Item2);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(3, m2.Current.Item1);
            Assert.AreEqual(0, m2.Current.Item2);
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestZipLongest3()
        {
            var m1 = ZipLongest(new int[] {2, 10, 3, 1, 12, 7}, new int[] {9, 5, 8, 11}, new int[] {1, 2, 3, 4, 5}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(11, m1.Current.Item2);
            Assert.AreEqual(4, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(12, m1.Current.Item1);
            Assert.AreEqual(0, m1.Current.Item2);
            Assert.AreEqual(5, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(7, m1.Current.Item1);
            Assert.AreEqual(0, m1.Current.Item2);
            Assert.AreEqual(0, m1.Current.Item3);
            Assert.False(m1.MoveNext());

            var m2 = ZipLongest(new int[] {2, 10, 3}, new int[] {9, 5, 8, 11}, new int[] {}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current.Item1);
            Assert.AreEqual(9, m2.Current.Item2);
            Assert.AreEqual(0, m2.Current.Item3);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(10, m2.Current.Item1);
            Assert.AreEqual(5, m2.Current.Item2);
            Assert.AreEqual(0, m2.Current.Item3);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(3, m2.Current.Item1);
            Assert.AreEqual(8, m2.Current.Item2);
            Assert.AreEqual(0, m2.Current.Item3);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(0, m2.Current.Item1);
            Assert.AreEqual(11, m2.Current.Item2);
            Assert.AreEqual(0, m2.Current.Item3);
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestZipLongest4()
        {
            var m1 = ZipLongest(new int[] {2, 10, 3, 1, 12, 7}, new int[] {9, 5, 8, 11}, new int[] {1, 2, 3, 4, 5}, new int[] {9, 8, 7, 6, 5}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(8, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(11, m1.Current.Item2);
            Assert.AreEqual(4, m1.Current.Item3);
            Assert.AreEqual(6, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(12, m1.Current.Item1);
            Assert.AreEqual(0, m1.Current.Item2);
            Assert.AreEqual(5, m1.Current.Item3);
            Assert.AreEqual(5, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(7, m1.Current.Item1);
            Assert.AreEqual(0, m1.Current.Item2);
            Assert.AreEqual(0, m1.Current.Item3);
            Assert.AreEqual(0, m1.Current.Item4);
            Assert.False(m1.MoveNext());

            var m2 = ZipLongest(new int[] {2, 10, 3}, new int[] {9, 5, 8, 11}, new int[] {1, 2, 3, 4, 5}, new int[] {}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(2, m2.Current.Item1);
            Assert.AreEqual(9, m2.Current.Item2);
            Assert.AreEqual(1, m2.Current.Item3);
            Assert.AreEqual(0, m2.Current.Item4);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(10, m2.Current.Item1);
            Assert.AreEqual(5, m2.Current.Item2);
            Assert.AreEqual(2, m2.Current.Item3);
            Assert.AreEqual(0, m2.Current.Item4);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(3, m2.Current.Item1);
            Assert.AreEqual(8, m2.Current.Item2);
            Assert.AreEqual(3, m2.Current.Item3);
            Assert.AreEqual(0, m2.Current.Item4);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(0, m2.Current.Item1);
            Assert.AreEqual(11, m2.Current.Item2);
            Assert.AreEqual(4, m2.Current.Item3);
            Assert.AreEqual(0, m2.Current.Item4);
            Assert.True(m2.MoveNext());
            Assert.AreEqual(0, m2.Current.Item1);
            Assert.AreEqual(0, m2.Current.Item2);
            Assert.AreEqual(5, m2.Current.Item3);
            Assert.AreEqual(0, m2.Current.Item4);
            Assert.False(m2.MoveNext());
        }
    }
}
