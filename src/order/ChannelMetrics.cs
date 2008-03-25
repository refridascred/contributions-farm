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

        /// <summary>Blend two window record measurements.</summary>
        public static double ProjectWindowRecord(double gain, double span)
        {
            double gain2 = 7.1;
            if (gain2 < (double)0)
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - span) - (double)(long)i;
            }
            return gain2 - (double)24;
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
