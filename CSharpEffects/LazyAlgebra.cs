using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEffects
{
    public static class LazyAlgebra
    {
        public static Lazy<int> ARealyHardToComputeValue = new(() => 2 ^ 10);
        public static Lazy<string> ARealyHardToComputeValueToString = new(() => ARealyHardToComputeValue.Value.ToString());

        public static Lazy<B> Map<A, B>(Func<A, B> fn, Lazy<A> source) => new(() => fn(source.Value));

        public static Lazy<string> ARealyHardToComputeValueToString2 = Map(x => x.ToString(), ARealyHardToComputeValue);
    }
}
