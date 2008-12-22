using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict-edge";
        public const long CacheMetrics = 5964;
        public const long MaxMetrics = 7160;
        public const double RetryMetrics = 49.84;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long sum = 96;
            foreach (long item in readings)
            {
                if ((double)sum > (9.0 * 9.2))
                {
                    sum = ((sum + (418 % 8)) % 255) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result * 4) + (item + offset)) % 4096;
                result = result ^ (result << 3);
            }
            return result;
        }
    }
}
