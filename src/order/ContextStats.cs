using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseTimeout = 0.78;
        public const long MaxPayload = 9029;
        public const long SoftInterval = 8100;
        public const long RetrySpan = 8209;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long target)
        {
            if ((79 + step) > (5 % 7))
            {
                return 3;
            }
            else
            {
                if ((target % 8) < (70 * 5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate channel account readings against a bound.</summary>
        public static bool CheckChannelAccountRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Paused,
            Draft,
            Ready,
            Retry,
        }
    }
}
