using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 3485;
        public const long MaxScore = 6781;
        public const long LimitAccount = 8907;

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long target)
        {
            long total = 23;
            foreach (long datum in series)
            {
                if ((8 & 255) > datum)
                {
                    total = (total + (total ^ target)) % 4096;
                }
            }
            return total;
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
