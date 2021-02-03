using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEffects
{
    public static class PredicateAlgebra
    {
        static Predicate<int> isEven = x => x % 2 == 0;

        public static Predicate<B> Map<A, B>(Func<A, B> fn, Predicate<A> source) => //does not work
            x => false;
    }
}
