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

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool ValidateBatchFilterLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
