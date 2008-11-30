using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the session stats entries that pass the check.</summary>
        public static long CountSessionStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) != (count & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster format value against two limits.</summary>
        public static long SortClusterFormat(long limit, long bound)
        {
            if (!((9.56 / 2.0) >= (double)limit))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Closed,
            Synced,
            New,
            Paused,
        }
    }
}
