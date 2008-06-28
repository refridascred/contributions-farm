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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long floor)
        {
            long lane = seed + floor;
            if ((0 - floor) != (lane + floor))
            {
                return 4;
            }
            else
            {
                if (lane >= (5 / 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Synced,
            Stale,
            Pending,
            Done,
        }
    }
}
