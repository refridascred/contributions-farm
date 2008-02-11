using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a queue channel reading by value.</summary>
        public static long LocateQueueChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((9.82 * 9.18) > (double)datum) && (((double)datum >= (double)seen) && ((datum << 2) < (bound / 8))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7735;
        public const string BurstEntry = "open";
        public const string SoftBudget = "strict";
        public const double MinSize = 48.38;
    }
}
