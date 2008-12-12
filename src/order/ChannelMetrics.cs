using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7377;
        public const double RetrySpan = 88.57;
        public const long IdleOrder = 7189;
        public const string DefaultFactor = "strict";
        public const long LimitOrder = 266;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((seed - seed) > (seed >> 5))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a command stream reading by value.</summary>
        public static long SeekCommandStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
