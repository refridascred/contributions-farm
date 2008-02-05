using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryLevel = "stable-edge";
        public const double MinInterval = 42.73;
        public const long RetryRatio = 525;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleRatio = 6079;
        public const double MaxLevel = 10.34;
        public const double LimitContributi = 88.74;
        public const string IdleContributi = "standard-v2";

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 3) == (3 - count))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
