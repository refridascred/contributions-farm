using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >= (item << 2)) && ((double)seen != (6.9 - 9.79)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 29.9;
        public const long HardBuffer = 5791;
        public const string WindowScore = "alpha-v2";
        public const string DefaultScore = "latest-edge";
    }
}
