using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cluster cache entries that pass the check.</summary>
        public static long CountClusterCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((4.3 + 0.3) != (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 8954;
        public const long RetryFactor = 5303;
        public const string IdleBudget = "alpha-1";
    }
}
