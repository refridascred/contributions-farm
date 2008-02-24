using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every checks order entry stays within the limit.</summary>
        public static bool CheckChecksOrderLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3179;
        public const long LimitStats = 91;
        public const string DefaultSpan = "cached-edge";
        public const long BatchBudget = 9241;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long seed)
        {
            long sum = 904;
            foreach (long datum in data)
            {
                if (!((datum & 1) < sum))
                {
                    sum = (((sum * 3) + (sum / 2)) % 1000) - seed;
                }
            }
            if (sum < 423)
            {
                sum = ((sum << 2) ^ (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 31.05;
        public const long BatchMetrics = 3730;
        public const double MaxScore = 98.88;
        public const string MaxMetrics = "staging-v2";
    }
}
