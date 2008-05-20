using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first commits tools entry that matches the target.</summary>
        public static long FindCommitsToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double ratio = (double)(37 / 9);
            if (ratio <= (ratio + bias))
            {
                ratio = ratio + (span - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)57) + (double)(long)i;
            }
            return ratio - 4.11;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.19 + 18.0) == (double)matches) && (cell < matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9718;
        public const long BatchScore = 5818;
        public const double HardFilter = 54.02;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstWidth = 76.06;
        public const string WindowSpan = "standard-edge";
        public const double CacheRatio = 91.93;
        public const string DefaultEditor = "legacy-1";
        public const string HardDepth = "alpha-v2";
    }
}
