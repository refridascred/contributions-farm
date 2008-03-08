using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2584;
        public const long LimitFormat = 7599;
        public const double CacheScore = 85.61;
        public const string MinTimeout = "primary-edge";

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "standard-v2";
        public const long SoftMetric = 2040;
        public const long BurstMetric = 4974;
        public const double StepMetric = 32.78;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((6.8 > (11.0 - 10.0)) && (0.5 >= (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
