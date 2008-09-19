using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) != (sample ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheWidth = 11.98;
        public const long SoftBudget = 7152;
        public const long CacheNotes = 2822;
        public const long CacheScore = 9708;

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 5.51;
        public const long BatchWidth = 6724;
        public const long SoftSize = 1047;
        public const double HardMetric = 54.76;
        public const long BaseTimeout = 7815;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (offset % 12)) % 65521;
                total = (total * 2) + total;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
