using System;
using System.Reflection;

using NUnit.Common;
using NUnitLite;

namespace Itertools.Tests
{
    public class Runner
    {
        public static int Main(string[] args)
        {
            return new AutoRun(typeof(Runner).GetTypeInfo().Assembly)
                .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
        }
    }
}