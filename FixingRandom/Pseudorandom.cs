using System;
using System.Threading;

namespace FixingRandom
{
    public static class Pseudorandom
    {
        private readonly static ThreadLocal<Random> prng = new ThreadLocal<Random>(() => new Random(BetterRandom.NextInt()));

        public static int NextInt() => prng.Value.Next();

        public static double NextDouble() => prng.Value.NextDouble();
    }
}
