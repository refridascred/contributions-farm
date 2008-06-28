using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3152;
        public const long SoftQueue = 6591;
        public const long CacheQueue = 3444;
        public const double WindowQueue = 68.78;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheBudget = 8369;
        public const long StepTools = 9774;
        public const long SoftCount = 2312;
        public const double CacheSpan = 31.02;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (6.52 < (double)origin)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5222;
        public const long LimitSize = 269;
        public const string HardScore = "standard-edge";
        public const double MaxBatch = 46.8;
    }
}
