using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (13.0 / 4.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2090;
        public const long BurstFormat = 9206;
        public const long LimitInterval = 6334;
        public const long IdleFormat = 1069;
        public const double MaxFormat = 86.96;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Closed,
            Dropped,
            Idle,
            Synced,
        }
    }
}
