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

        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] data)
        {
            long acc = 510;
            foreach (long value in data)
            {
                if ((acc << 3) >= value)
                {
                    acc = (acc ^ (acc << 2)) % 97;
                }
                else
                {
                    acc = (acc - (8 & 63)) % 1000;
                }
            }
            return acc % 97;
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
