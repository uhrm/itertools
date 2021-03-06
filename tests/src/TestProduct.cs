using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestProduct
    {
        [Test]
        public void TestProduct2I()
        {
            var m1 = Product(new int[] {2, 10, 3, 1}, new int[] {9, 5, 8}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.False(m1.MoveNext());

            var m2 = Product(new int[] {2, 10, 3, 1}, new int[] {}).GetEnumerator();
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestProduct3I()
        {
            var m1 = Product(new int[] {2, 10, 3, 1}, new int[] {9, 5, 8}, new int[] {1, 2, 3}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(8, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.False(m1.MoveNext());

            var m2 = Product(new int[] {2, 10, 3, 1}, new int[] {9, 5, 8}, new int[] {}).GetEnumerator();
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestProduct4I()
        {
            var m1 = Product(new int[] {2, 10}, new int[] {9, 5}, new int[] {1, 3}, new int[] {7, 4}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(1, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(7, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(5, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.AreEqual(4, m1.Current.Item4);
            Assert.False(m1.MoveNext());

            var m2 = Product(new int[] {2, 10}, new int[] {9, 5}, new int[] {1, 3}, new int[] {}).GetEnumerator();
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestProductI2()
        {
            var m1 = Product2(new int[] {2, 10, 3, 1}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
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
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(1, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(1, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(1, m1.Current.Item1);
            Assert.AreEqual(1, m1.Current.Item2);
            Assert.False(m1.MoveNext());

            var m2 = Product2(new int[] {}).GetEnumerator();
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestProductI3()
        {
            var m1 = Product3(new int[] {2, 10, 3}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(10, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(10, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(10, m1.Current.Item3);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current.Item1);
            Assert.AreEqual(3, m1.Current.Item2);
            Assert.AreEqual(3, m1.Current.Item3);
            Assert.False(m1.MoveNext());

            var m2 = Product3(new int[] {}).GetEnumerator();
            Assert.False(m2.MoveNext());
        }

        [Test]
        public void TestProductI4()
        {
            var m1 = Product4(new int[] {2, 9}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(2, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(2, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(2, m1.Current.Item4);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(9, m1.Current.Item1);
            Assert.AreEqual(9, m1.Current.Item2);
            Assert.AreEqual(9, m1.Current.Item3);
            Assert.AreEqual(9, m1.Current.Item4);
            Assert.False(m1.MoveNext());

            var m2 = Product4(new int[] {}).GetEnumerator();
            Assert.False(m2.MoveNext());
        }
    }
}
