using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 349;
        public const long WindowSession = 8157;
        public const long RetryRatio = 1280;

        /// <summary>Measure how many counter layout samples are out of range.</summary>
        public static long MeasureCounterLayoutGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)131 == (double)offset)
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
