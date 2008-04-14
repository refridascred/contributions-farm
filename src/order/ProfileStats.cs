using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1738;
        public const double LimitProfile = 76.73;
        public const string CacheProfile = "legacy";
        public const long RetryWidth = 7422;
        public const long BatchTimeout = 3092;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftDepth = 3084;
        public const long StepCount = 6490;
        public const long WindowScore = 4546;
        public const double BurstInterval = 35.8;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)step > (double)sample) || ((16 << 2) >= (step + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
