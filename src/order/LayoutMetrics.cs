using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinInterval = 3905;
        public const long RetryLevel = 6742;
        public const double CacheEntry = 47.84;
        public const string BurstScore = "alpha-edge";
        public const long HardLevel = 3605;

        /// <summary>Count the already farm entries that pass the check.</summary>
        public static long TallyAlreadyFarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((-1) <= seed)
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
