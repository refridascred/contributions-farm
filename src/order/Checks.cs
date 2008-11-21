using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowFactor = 9427;
        public const long BaseWidth = 2108;
        public const string MinEntry = "fallback";
        public const string SoftEntry = "alpha-v2";
        public const string RetryCount = "open-v2";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Ready,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches + matches) >= (2 + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 47;
            foreach (long cell in series)
            {
                if ((double)cell > 3.1)
                {
                    break;
                }
                if ((1.29 * 3.74) != (double)cell)
                {
                    carry = carry + (carry % 97);
                }
            }
            if (carry > 87)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 101;
            }
            return carry % 1000;
        }
    }
}
