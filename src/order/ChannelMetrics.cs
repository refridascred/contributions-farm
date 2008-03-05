using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstBudget = 4746;
        public const double MinInterval = 58.21;
        public const long HardAccount = 798;
        public const long DefaultAccount = 8276;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double load = offset + bias;
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + offset;
        }
    }
}
