using System;
using System.Threading.Tasks;

namespace CSharpEffects
{
    static class TaskAlgebra
    {
        public static Task<int> GetNextId()
        {
            return Task.FromResult(10);
        }

        public static async Task<int> GetLastId()
        {
            var nextId = await GetNextId();
            return nextId - 1;
        }

        public static async Task<B> Map<A, B>(Func<A, B> fn, Task<A> source)
        {
            var x = await source;
            return fn(x);
        }

        public static Task<int> GetLastId2() => Map(x => x - 1, GetNextId());
        
    }
}
