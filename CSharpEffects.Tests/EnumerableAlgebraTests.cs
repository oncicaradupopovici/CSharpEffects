using System;
using System.Linq;
using Xunit;

namespace CSharpEffects.Tests
{
    public class EnumerableAlgebraTests
    {
        [Fact]
        public void Test1()
        {
            var first3Evens = EnumerableAlgebra.Evens().Take(3).ToList();
            Assert.All(first3Evens, x => Assert.Equal(0, x % 2));

        }
    }
}
