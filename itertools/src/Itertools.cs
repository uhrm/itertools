
using System;
using System.Collections.Generic;
using System.Linq;

namespace Itertools
{
    public static class Functions
    {
        public static IEnumerable<T> Chain<T>(IEnumerable<T> p, IEnumerable<T> q, params IEnumerable<T>[] r)
        {
            foreach (var t in p) {
                yield return t;
            }
            foreach (var t in q) {
                yield return t;
            }
            foreach (var e in r) {
                foreach (var t in e) {
                    yield return t;
                }
            }
        }

        public static IEnumerable<int> Count(int start=0, int step=1) {
            for (var i=start; ; i+=step) {
                yield return i;
            }
        }

        public static IEnumerable<T> Cycle<T>(IEnumerable<T> iter) {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                throw new ArgumentException("Empty iterator.", "iter");
            }
            while (true) {
                do {
                    yield return e.Current;
                } while (e.MoveNext());
                e = iter.GetEnumerator();
                e.MoveNext();
            }
        }

        public static IEnumerable<(int,T)> Enumerate<T>(IEnumerable<T> iter, int start = 0)
        {
            foreach (var i in iter) {
                yield return (start++, i);
            }
        }

        /// <summary>
        /// Filter an enumerable by a predicate.
        /// <para>The resulting enumerable retains all elements from <paramref name="iter"/>
        /// for which the predicate evaluates to true.</para>
        /// </summary>
        /// <param name="pred">The filter predicate.</param>
        /// <param name="iter">The enumerable to filter.</param>
        /// <returns>A filtered enumerable.</returns>
        public static IEnumerable<T> Filter<T>(Func<T,bool> pred, IEnumerable<T> iter)
        {
            foreach (var i in iter) {
                if (pred(i)) {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Creates an enumerable of the elements resulting from applying
        /// <paramref name="func"/> to the elements of <paramref name="iter"/>.
        /// </summary>
        /// <param name="func">The mapping function.</param>
        /// <param name="iter">The enumerable.</param>
        /// <returns>An enumerable of the results of the mapping function.</returns>
        public static IEnumerable<R> Map<T,R>(Func<T,R> func, IEnumerable<T> iter)
        {
            foreach (var i in iter) {
                yield return func(i);
            }
        }

        /// <summary>
        /// Creates an enumerable of the elements resulting from applying
        /// <paramref name="func"/> to the elements of <paramref name="iter"/>.
        /// </summary>
        /// <param name="func">The mapping function.</param>
        /// <param name="iter">The enumerable.</param>
        /// <returns>An enumerable of the results of the mapping function.</returns>
        public static IEnumerable<R> Map<T1,T2,R>(Func<T1,T2,R> func, IEnumerable<(T1,T2)> iter)
        {
            foreach (var (a, b) in iter) {
                yield return func(a, b);
            }
        }

        /// <summary>
        /// Creates an enumerable of the elements resulting from applying
        /// <paramref name="func"/> to the elements of <paramref name="iter"/>.
        /// </summary>
        /// <param name="func">The mapping function.</param>
        /// <param name="iter">The enumerable.</param>
        /// <returns>An enumerable of the results of the mapping function.</returns>
        public static IEnumerable<R> Map<T1,T2,T3,R>(Func<T1,T2,T3,R> func, IEnumerable<(T1,T2,T3)> iter)
        {
            foreach (var (a, b, c) in iter) {
                yield return func(a, b, c);
            }
        }

        /// <summary>
        /// Creates an enumerable of the elements resulting from applying
        /// <paramref name="func"/> to the elements of <paramref name="iter"/>.
        /// </summary>
        /// <param name="func">The mapping function.</param>
        /// <param name="iter">The enumerable.</param>
        /// <returns>An enumerable of the results of the mapping function.</returns>
        public static IEnumerable<R> Map<T1,T2,T3,T4,R>(Func<T1,T2,T3,T4,R> func, IEnumerable<(T1,T2,T3,T4)> iter)
        {
            foreach (var (a, b, c, d) in iter) {
                yield return func(a, b, c, d);
            }
        }

        /// <summary>
        /// Computes the maximal element of an enumerable.
        /// </summary>
        /// <param name="iter">The enumerable.</param>
        /// <returns>The maximal element of the enumerable.</returns>
        /// <
        public static T Max<T>(IEnumerable<T> iter) where T : IComparable<T>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                throw new ArgumentException("Empty iterator.", "iter");
            }
            var val = e.Current;
            while (e.MoveNext()) {
                var cur = e.Current;
                if (cur.CompareTo(val) > 0) {
                    val = cur;
                }
            }
            return val;
        }

        public static T Max<T>(IEnumerable<T> iter, T empty) where T : IComparable<T>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                return empty;
            }
            var val = e.Current;
            while (e.MoveNext()) {
                var cur = e.Current;
                if (cur.CompareTo(val) > 0) {
                    val = cur;
                }
            }
            return val;
        }

        public static T Max<T,K>(IEnumerable<T> iter, Func<T,K> key) where K : IComparable<K>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                throw new ArgumentException("Empty iterator.", "iter");
            }
            var res = e.Current;
            var val = key(res);
            while (e.MoveNext()) {
                var c = e.Current;
                var k = key(c);
                if (k.CompareTo(val) > 0) {
                    res = c;
                    val = k;
                }
            }
            return res;
        }

        public static T Max<T,K>(IEnumerable<T> iter, Func<T,K> key, T empty) where K : IComparable<K>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                return empty;
            }
            var res = e.Current;
            var val = key(res);
            while (e.MoveNext()) {
                var c = e.Current;
                var k = key(c);
                if (k.CompareTo(val) > 0) {
                    res = c;
                    val = k;
                }
            }
            return res;
        }

        public static T Min<T>(IEnumerable<T> iter) where T : IComparable<T>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                throw new ArgumentException("Empty iterator.", "iter");
            }
            var val = e.Current;
            while (e.MoveNext()) {
                var cur = e.Current;
                if (cur.CompareTo(val) < 0) {
                    val = cur;
                }
            }
            return val;
        }

        public static T Min<T>(IEnumerable<T> iter, T empty) where T : IComparable<T>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                return empty;
            }
            var val = e.Current;
            while (e.MoveNext()) {
                var cur = e.Current;
                if (cur.CompareTo(val) < 0) {
                    val = cur;
                }
            }
            return val;
        }

        public static T Min<T,K>(IEnumerable<T> iter, Func<T,K> key) where K : IComparable<K>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                throw new ArgumentException("Empty iterator.", "iter");
            }
            var res = e.Current;
            var val = key(res);
            while (e.MoveNext()) {
                var c = e.Current;
                var k = key(c);
                if (k.CompareTo(val) < 0) {
                    res = c;
                    val = k;
                }
            }
            return res;
        }

        public static T Min<T,K>(IEnumerable<T> iter, Func<T,K> key, T empty) where K : IComparable<K>
        {
            var e = iter.GetEnumerator();
            if (!e.MoveNext()) {
                return empty;
            }
            var res = e.Current;
            var val = key(res);
            while (e.MoveNext()) {
                var c = e.Current;
                var k = key(c);
                if (k.CompareTo(val) < 0) {
                    res = c;
                    val = k;
                }
            }
            return res;
        }

        public static IEnumerable<int> Range(int stop)
        {
            return Range(0, stop);
        }

        public static IEnumerable<int> Range(int start, int stop)
        {
            return Range(start, stop, start <= stop ? 1 : -1);
        }

        public static IEnumerable<int> Range(int start, int stop, int step)
        {
            if (start < stop && step <= 0) {
                throw new ArgumentOutOfRangeException("step", step, $"Argument 'step' is out of range: expected step > 0, found step = {step}");
            }
            if (start > stop && step >= 0) {
                throw new ArgumentOutOfRangeException("step", step, $"Argument 'step' is out of range: expected step < 0, found step = {step}");
            }
            for (var i=start; step>=0 ? i<stop : i>stop; i+=step) {
                yield return i;
            }
        }

        public static IEnumerable<T> Repeat<T>(T item)
        {
            while (true) {
                yield return item;
            }
        }

        public static IEnumerable<T> Repeat<T>(T item, int times)
        {
            if (times < 0) {
                throw new ArgumentOutOfRangeException("times", times, $"Argument 'times' is out of range: expected times >= 0, found times = {times}");
            }
            while (--times >= 0) {
                yield return item;
            }
        }

        public static IEnumerable<T> Slice<T>(IEnumerable<T> iter, int stop)
        {
            return Slice(iter, 0, stop);
        }

        public static IEnumerable<T> Slice<T>(IEnumerable<T> iter, int start, int? stop, int step = 1)
        {
            if (start < 0) {
                throw new ArgumentOutOfRangeException("start", start, $"Argument 'start' is out of range: expected start >= 0, found start = {start}");
            }
            if (stop.HasValue && stop.Value < start) {
                throw new ArgumentOutOfRangeException("stop", stop.Value, $"Argument 'stop' is out of range: expected stop >= {start}, found stop = {stop.Value}");
            }
            if (step <= 0) {
                throw new ArgumentOutOfRangeException("step", step, $"Argument 'step' is out of range: expected step > 0, found step = {step}");
            }
            if (stop.HasValue && start == stop.Value) {
                yield break;
            }
            var e = iter.GetEnumerator();
            var i = 0;
            while (i < start && e.MoveNext()) {
                i++;
            }
            if (i < start) {
                yield break;
            }
            var s = 0;
            while ((!stop.HasValue || i < stop.Value) && e.MoveNext()) {
                if (s == 0) {
                    yield return e.Current;
                    s = step;
                }
                i++;
                s--;
            }
        }

        private static (IEnumerator<T1>,IEnumerator<T2>) GetEnumerator<T1,T2>(IEnumerable<T1> a, IEnumerable<T2> b)
        {
            return (a.GetEnumerator(), b.GetEnumerator());
        }

        private static (IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>) GetEnumerator<T1,T2,T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
        {
            return (a.GetEnumerator(), b.GetEnumerator(), c.GetEnumerator());
        }

        private static (IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>,IEnumerator<T4>) GetEnumerator<T1,T2,T3,T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
        {
            return (a.GetEnumerator(), b.GetEnumerator(), c.GetEnumerator(), d.GetEnumerator());
        }

        private static (bool,bool) MoveNext<T1,T2>((IEnumerator<T1>,IEnumerator<T2>) t)
        {
            return (t.Item1.MoveNext(), t.Item2.MoveNext());
        }

        private static (bool,bool,bool) MoveNext<T1,T2,T3>((IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>) t)
        {
            return (t.Item1.MoveNext(), t.Item2.MoveNext(), t.Item3.MoveNext());
        }

        private static (bool,bool,bool,bool) MoveNext<T1,T2,T3,T4>((IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>,IEnumerator<T4>) t)
        {
            return (t.Item1.MoveNext(), t.Item2.MoveNext(), t.Item3.MoveNext(), t.Item4.MoveNext());
        }

        private static (T1,T2) Current<T1,T2>((IEnumerator<T1>,IEnumerator<T2>) t)
        {
            return (t.Item1.Current, t.Item2.Current);
        }

        private static (T1,T2,T3) Current<T1,T2,T3>((IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>) t)
        {
            return (t.Item1.Current, t.Item2.Current, t.Item3.Current);
        }

        private static (T1,T2,T3,T4) Current<T1,T2,T3,T4>((IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>,IEnumerator<T4>) t)
        {
            return (t.Item1.Current, t.Item2.Current, t.Item3.Current, t.Item4.Current);
        }

        private static (T1,T2) Select<T1,T2>((bool,bool) f, (IEnumerator<T1>,IEnumerator<T2>) t)
        {
            return (
                f.Item1 ? t.Item1.Current : default(T1),
                f.Item2 ? t.Item2.Current : default(T2));
        }

        private static (T1,T2,T3) Select<T1,T2,T3>((bool,bool,bool) f, (IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>) t)
        {
            return (
                f.Item1 ? t.Item1.Current : default(T1),
                f.Item2 ? t.Item2.Current : default(T2),
                f.Item3 ? t.Item3.Current : default(T3));
        }

        private static (T1,T2,T3,T4) Select<T1,T2,T3,T4>((bool,bool,bool,bool) f, (IEnumerator<T1>,IEnumerator<T2>,IEnumerator<T3>,IEnumerator<T4>) t)
        {
            return (
                f.Item1 ? t.Item1.Current : default(T1),
                f.Item2 ? t.Item2.Current : default(T2),
                f.Item3 ? t.Item3.Current : default(T3),
                f.Item4 ? t.Item4.Current : default(T4));
        }

        private static bool Any((bool,bool) t)
        {
            return t.Item1 || t.Item2;
        }

        private static bool Any((bool,bool,bool) t)
        {
            return t.Item1 || t.Item2 || t.Item3;
        }

        private static bool Any((bool,bool,bool,bool) t)
        {
            return t.Item1 || t.Item2 || t.Item3 || t.Item4;
        }

        private static bool All((bool,bool) t)
        {
            return t.Item1 && t.Item2;
        }

        private static bool All((bool,bool,bool) t)
        {
            return t.Item1 && t.Item2 && t.Item3;
        }

        private static bool All((bool,bool,bool,bool) t)
        {
            return t.Item1 && t.Item2 && t.Item3 && t.Item4;
        }

        public static IEnumerable<(T1,T2)> Zip<T1,T2>(IEnumerable<T1> a, IEnumerable<T2> b)
        {
            
            for (var e = GetEnumerator(a, b); All(MoveNext(e));) {
                yield return Current(e);
            }
        }

        public static IEnumerable<(T1,T2,T3)> Zip<T1,T2,T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
        {
            for (var e = GetEnumerator(a, b, c); All(MoveNext(e));) {
                yield return Current(e);
            }
        }

        public static IEnumerable<(T1,T2,T3,T4)> Zip<T1,T2,T3,T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
        {
            for (var e = GetEnumerator(a, b, c, d); All(MoveNext(e));) {
                yield return Current(e);
            }
        }

        public static IEnumerable<(T1,T2)> ZipLongest<T1,T2>(IEnumerable<T1> a, IEnumerable<T2> b)
        {
            var e = GetEnumerator(a, b);
            for (var n = MoveNext(e); Any(n); n = MoveNext(e)) {
                yield return Select(n, e);
            }
        }

        public static IEnumerable<(T1,T2,T3)> ZipLongest<T1,T2,T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
        {
            var e = GetEnumerator(a, b, c);
            for (var n = MoveNext(e); Any(n); n = MoveNext(e)) {
                yield return Select(n, e);
            }
        }

        public static IEnumerable<(T1,T2,T3,T4)> ZipLongest<T1,T2,T3,T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
        {
            var e = GetEnumerator(a, b, c, d);
            for (var n = MoveNext(e); Any(n); n = MoveNext(e)) {
                yield return Select(n, e);
            }
        }

        //
        // combinatorial functions
        //

        public static IEnumerable<(T1,T2)> Product<T1,T2>(IEnumerable<T1> a, IEnumerable<T2> b)
        {
            foreach (T1 e1 in a) {
                foreach (T2 e2 in b) {
                    yield return (e1, e2);
                }
            }
        }

        public static IEnumerable<(T1,T2,T3)> Product<T1,T2,T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
        {
            foreach (T1 e1 in a) {
                foreach (T2 e2 in b) {
                    foreach (T3 e3 in c) {
                        yield return (e1, e2, e3);
                    }
                }
            }
        }

        public static IEnumerable<(T1,T2,T3,T4)> Product<T1,T2,T3,T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
        {
            foreach (T1 e1 in a) {
                foreach (T2 e2 in b) {
                    foreach (T3 e3 in c) {
                        foreach (T4 e4 in d) {
                            yield return (e1, e2, e3, e4);
                        }
                    }
                }
            }
        }

        public static IEnumerable<(T,T)> Product2<T>(IEnumerable<T> a)
        {
            var e = (a.GetEnumerator(), a.GetEnumerator());
            var b = All(MoveNext(e));
            while (b) {
                yield return Current(e);
                if (b = e.Item2.MoveNext()) {
                    continue;
                }
                e.Item2 = a.GetEnumerator();
                e.Item2.MoveNext();
                b = e.Item1.MoveNext();
            }
        }

        public static IEnumerable<(T,T,T)> Product3<T>(IEnumerable<T> a)
        {
            var e = (a.GetEnumerator(), a.GetEnumerator(), a.GetEnumerator());
            var b = All(MoveNext(e));
            while (b) {
                yield return Current(e);
                if (b = e.Item3.MoveNext()) {
                    continue;
                }
                e.Item3 = a.GetEnumerator();
                e.Item3.MoveNext();
                if (b = e.Item2.MoveNext()) {
                    continue;
                }
                e.Item2 = a.GetEnumerator();
                e.Item2.MoveNext();
                b = e.Item1.MoveNext();
            }
        }

        public static IEnumerable<(T,T,T,T)> Product4<T>(IEnumerable<T> a)
        {
            var e = (a.GetEnumerator(), a.GetEnumerator(), a.GetEnumerator(), a.GetEnumerator());
            var b = All(MoveNext(e));
            while (b) {
                yield return Current(e);
                if (b = e.Item4.MoveNext()) {
                    continue;
                }
                e.Item4 = a.GetEnumerator();
                e.Item4.MoveNext();
                if (b = e.Item3.MoveNext()) {
                    continue;
                }
                e.Item3 = a.GetEnumerator();
                e.Item3.MoveNext();
                if (b = e.Item2.MoveNext()) {
                    continue;
                }
                e.Item2 = a.GetEnumerator();
                e.Item2.MoveNext();
                b = e.Item1.MoveNext();
            }
        }

        public static IEnumerable<(T,T)> Combinations2<T>(IEnumerable<T> a) {
            var p = a.ToArray();
            var n = p.Length;
            var c = (0, 1);
            while (c.Item2 < n) {
                yield return (p[c.Item1], p[c.Item2]);
                if (++c.Item2 == n) {
                    c.Item1++;
                    c.Item2 = c.Item1+1;
                }
            }
        }

        public static IEnumerable<(T,T,T)> Combinations3<T>(IEnumerable<T> a) {
            var p = a.ToArray();
            var n = p.Length;
            var c = (0, 1, 2);
            while (c.Item3 < n) {
                yield return (p[c.Item1], p[c.Item2], p[c.Item3]);
                var l = n;
                if (++c.Item3 == l--) {
                    if (++c.Item2 == l) {
                        c.Item1++;
                        c.Item2 = c.Item1+1;
                    }
                    c.Item3 = c.Item2+1;
                }
            }
        }

        public static IEnumerable<(T,T,T,T)> Combinations4<T>(IEnumerable<T> a) {
            var p = a.ToArray();
            var n = p.Length;
            var c = (0, 1, 2, 3);
            while (c.Item4 < n) {
                yield return (p[c.Item1], p[c.Item2], p[c.Item3], p[c.Item4]);
                var l = n;
                if (++c.Item4 == l--) {
                    if (++c.Item3 == l--) {
                        if (++c.Item2 == l) {
                            c.Item1++;
                            c.Item2 = c.Item1+1;
                        }
                        c.Item3 = c.Item2+1;
                    }
                    c.Item4 = c.Item3+1;
                }
            }
        }

        public static IEnumerable<(T,T)> CombinationsWithReplacement2<T>(IEnumerable<T> a) {
            var p = a.ToArray();
            var n = p.Length;
            var c = (0, 1);
            while (c.Item2 < n) {
                yield return (p[c.Item1], p[c.Item2]);
                if (++c.Item2 == n) {
                    c.Item1++;
                    c.Item2 = c.Item1;
                }
            }
        }

        public static IEnumerable<(T,T,T)> CombinationsWithReplacement3<T>(IEnumerable<T> a) {
            var p = a.ToArray();
            var n = p.Length;
            var c = (0, 1, 2);
            while (c.Item3 < n) {
                yield return (p[c.Item1], p[c.Item2], p[c.Item3]);
                if (++c.Item3 == n) {
                    if (++c.Item2 == n) {
                        c.Item1++;
                        c.Item2 = c.Item1;
                    }
                    c.Item3 = c.Item2;
                }
            }
        }

        public static IEnumerable<(T,T,T,T)> CombinationsWithReplacement4<T>(IEnumerable<T> a) {
            var p = a.ToArray();
            var n = p.Length;
            var c = (0, 1, 2, 3);
            while (c.Item4 < n) {
                yield return (p[c.Item1], p[c.Item2], p[c.Item3], p[c.Item4]);
                if (++c.Item4 == n) {
                    if (++c.Item3 == n) {
                        if (++c.Item2 == n) {
                            c.Item1++;
                            c.Item2 = c.Item1;
                        }
                        c.Item3 = c.Item2;
                    }
                    c.Item4 = c.Item3;
                }
            }
        }

        // public static IEnumerable<T,T> Permutations2<T>(IEnumerable<T> a)
        // {

        // }
    }
}