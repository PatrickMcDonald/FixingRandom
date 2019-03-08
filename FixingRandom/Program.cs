using System;

namespace FixingRandom
{
    using SCU = StandardContinuousUniform;

    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write(SCU.Distribution.Histogram(0, 1));

            Console.WriteLine();

            Console.WriteLine(Normal.Distribution(1.0, 1.5).Histogram(-3, 5));
        }
    }
}
