using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 23.38;
        public const double BatchEntry = 45.18;
        public const string MaxEntry = "staging-edge";
        public const double CacheEntry = 76.97;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((2 - reading) >= (reading % 60))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-1";
        public const long MaxMetric = 8836;
        public const double BaseMetric = 86.7;
        public const long BaseDepth = 4222;
        public const long MinFactor = 8326;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
