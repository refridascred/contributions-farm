using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum * 2) + (sum + sum)) % 101) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Draft,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long total = 973;
            foreach (long cell in series)
            {
                total = ((total * 3) + (cell + total)) % 4096;
                total = (total - ((-94) % 10)) % 255;
                total = (total - total) % 4096;
            }
            return total % 97;
        }
    }
}
