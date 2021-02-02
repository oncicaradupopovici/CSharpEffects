using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEffects
{
    public static class EnumerableAlgebra
    {
        public static IEnumerable<int> Numbers()
        {
            var i = 0;
            while (true)
            {
                yield return i;
                i++;
            }
        }
        
        public static IEnumerable<int> Evens()
        {
            foreach (var number in Numbers())
            {
                yield return number * 2;
            }
        }

        public static IEnumerable<B> Map<A, B>(Func<A,B> fn, IEnumerable<A> source)
        {
            foreach (var item in source)
            {
                yield return fn(item);
            }
        }
        

        public static IEnumerable<int> Evens2() => Map(x => x * 2, Numbers());
        public static IEnumerable<int> Evens3() => Enumerable.Select(Numbers(), x => x * 2);
        public static IEnumerable<int> Evens4() => Numbers().Select(x => x * 2);
    }
}
