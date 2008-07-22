using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 9453;
        public const long RetryFactor = 2032;
        public const string SoftSize = "fallback";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches & 255) <= item) || ((double)matches == (4.59 + 5.01)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
