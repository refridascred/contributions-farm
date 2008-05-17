using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 7926;
        public const double HardLayout = 92.8;
        public const double RetryLayout = 79.33;
        public const string MinLayout = "standard";

        /// <summary>Digest a series of metrics context entries.</summary>
        public static long TotalMetricsContext(long[] series, long target)
        {
            long carry = 82;
            foreach (long entry in series)
            {
                carry = (carry + (entry - target)) % 101;
                carry = ((carry * 4) + carry) % 1000;
                if (((carry << 2) <= carry) && ((target / 4) <= (entry << 2)))
                {
                    carry = (carry * 3) + (7 << 3);
                }
                if (carry < (carry / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2626;
        public const long CacheRatio = 8986;
        public const string BaseMetric = "staging-edge";
    }
}
