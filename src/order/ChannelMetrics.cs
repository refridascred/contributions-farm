using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 1240;
        public const string RetryNotes = "open";
        public const long SoftSpan = 1850;

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long ClassifyTokenMetric(long floor, long offset)
        {
            if (!((double)offset <= 1.5))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
