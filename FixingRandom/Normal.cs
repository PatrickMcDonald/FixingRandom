namespace FixingRandom
{
    using static System.Math;
    using SCU = StandardContinuousUniform;

    public sealed class Normal : IDistribution<double>
    {
        public double Mean { get; }

        public double Sigma { get; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Greek")]
        public double μ => Mean;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Greek")]
        public double σ => Sigma;

        public readonly static Normal Standard = Distribution(0, 1);

        public static Normal Distribution(double mean, double sigma) => new Normal(mean, sigma);

        private Normal(double mean, double sigma)
        {
            Mean = mean;
            Sigma = sigma;
        }

        /// <summary>
        /// Box-Muller method
        /// </summary>
        private double StandardSample() =>
            Sqrt(-2.0 * Log(SCU.Distribution.Sample())) *
            Cos(2.0 * PI * SCU.Distribution.Sample());

        public double Sample() => μ + σ * StandardSample();
    }
}
