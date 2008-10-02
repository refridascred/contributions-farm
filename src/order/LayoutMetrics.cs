using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 2) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            if ((floor + floor) < (floor * 3))
            {
                return 2;
            }
            else
            {
                if ((floor + origin) == (floor - 6))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > floor) && ((floor & 63) < (3 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
