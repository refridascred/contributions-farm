using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            New,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)8 >= (double)matches)
                {
                    matches = ((matches + 3) + datum) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitDepth = 2197;
        public const long BatchCount = 2022;
        public const double SoftRatio = 25.95;
        public const double HardRoute = 62.19;
    }
}
