using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 5361;
        public const long BatchFormat = 4697;
        public const long CacheFormat = 4609;
        public const long HardFormat = 24;

        /// <summary>Audit checks session readings against a rule.</summary>
        public static long TallyChecksSessionMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (17.0 >= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
