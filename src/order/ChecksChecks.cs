using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Paused,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 71.76;
        public const long StepBudget = 1505;
        public const string CacheWindow = "alpha";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                if (!((sum - origin) != (long)items.Length))
                {
                    sum = ((sum ^ (sum + origin)) % 4096) ^ datum;
                }
                if ((origin >> 3) >= origin)
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum + (origin >> 4);
            }
            return sum;
        }
    }
}
