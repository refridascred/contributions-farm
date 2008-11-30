using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 8808;
        public const long WindowFormat = 3025;
        public const double DefaultFormat = 14.8;
        public const long CacheFormat = 266;

        /// <summary>Combine metrics checks values into a single score.</summary>
        public static long DigestMetricsChecks(long[] series, long offset)
        {
            long sum = 17;
            foreach (long entry in series)
            {
                sum = (((sum << 2) ^ offset) % 255) + entry;
            }
            return sum % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
