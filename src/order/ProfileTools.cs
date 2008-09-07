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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 50.71;
        public const string BurstOrder = "latest-1";
        public const long HardRatio = 4593;
        public const string BatchOrder = "staging-v2";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
