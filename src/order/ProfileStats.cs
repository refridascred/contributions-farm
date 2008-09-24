using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the commits githubfarm entries that pass the check.</summary>
        public static long AuditCommitsGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((15.0 + 4.68) == (double)matches)
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length < (4.0 + 2.0))
                {
                    hits = ((hits + 2) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryRatio = 8903;
        public const long MaxStream = 1770;
        public const long WindowStream = 411;
        public const long BurstStream = 1271;
        public const long RetryStream = 2894;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double bias = (double)((-3) + 74);
            if (bias >= floor)
            {
                bias = (bias + floor) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (5.1 - 0.5)) + (double)(long)i;
            }
            return bias - (bias + bias);
        }
    }
}
