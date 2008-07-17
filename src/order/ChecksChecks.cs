using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 9874;
        public const double CacheMetric = 62.07;
        public const long LimitLevel = 2077;
        public const long RetryRatio = 5290;
        public const string DefaultWidth = "fallback-v2";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools account readings against a rule.</summary>
        public static long MeasureToolsAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) >= (count + 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
