using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheWidth = "legacy-edge";
        public const long MaxProfile = 5493;
        public const string StepProfile = "standard";
        public const long RetryRatio = 6649;

        /// <summary>Count the stream profile entries that pass the check.</summary>
        public static long MeasureStreamProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >> 3) > (cell - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long TallyToolsNotesOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item == (2.01 * 8.9))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
