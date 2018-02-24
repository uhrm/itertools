using System;
using NUnit.Framework;

using static Itertools.Functions;

namespace Itertools.Tests
{
    [TestFixture]
    public class TestMap
    {
        [Test]
        public void TestMap1()
        {
            var m1 = Map(k => k+1, new int[] {2, 10, 3, 1, 4}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(11, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(4, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(5, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Map(k => k+1, new int[] {10}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(11, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Map(k => k+1, new int[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }

        [Test]
        public void TestMap2()
        {
            var m1 = Map((i,j) => i+j, new (int,int)[] {(2,1), (10,1), (3,1), (1,1), (4,1)}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(11, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(4, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(2, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(5, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Map((i,j) => i+j, new (int,int)[] {(10,1)}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(11, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Map((i,j) => i+j, new (int,int)[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }

        [Test]
        public void TestMap3()
        {
            var m1 = Map((i,j,k) => i+j+k, new (int,int,int)[] {(2,1,1), (10,1,1), (3,1,1), (1,1,1), (4,1,1)}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(4, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(12, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(5, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(3, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(6, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Map((i,j,k) => i+j+k, new (int,int,int)[] {(10,1,1)}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(12, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Map((i,j,k) => i+j+k, new (int,int,int)[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }

        [Test]
        public void TestMap4()
        {
            var m1 = Map((i,j,k,l) => i+j+k+l, new (int,int,int,int)[] {(2,1,1,1), (10,1,1,1), (3,1,1,1), (1,1,1,1), (4,1,1,1)}).GetEnumerator();
            Assert.True(m1.MoveNext());
            Assert.AreEqual(5, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(13, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(6, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(4, m1.Current);
            Assert.True(m1.MoveNext());
            Assert.AreEqual(7, m1.Current);
            Assert.False(m1.MoveNext());

            var m2 = Map((i,j,k,l) => i+j+k+l, new (int,int,int,int)[] {(10,1,1,1)}).GetEnumerator();
            Assert.True(m2.MoveNext());
            Assert.AreEqual(13, m2.Current);
            Assert.False(m2.MoveNext());

            var m3 = Map((i,j,k,l) => i+j+k+l, new (int,int,int,int)[] {}).GetEnumerator();
            Assert.False(m3.MoveNext());
        }
    }
}
