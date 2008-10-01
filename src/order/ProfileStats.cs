using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 626;
        public const double IdleProfile = 82.44;
        public const string BatchProfile = "staging";
        public const long BurstProfile = 9249;
        public const string CacheRatio = "stable";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + 925) > (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9754;
        public const long MaxTools = 565;
        public const long CacheTools = 7644;
        public const double MinFactor = 89.27;
        public const long BatchInterval = 6385;
    }
}
