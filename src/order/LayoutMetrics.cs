using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (double)target)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long origin)
        {
            if (!((9.0 * 7.4) < (double)floor))
            {
                return 0;
            }
            else
            {
                if (((origin ^ origin) != (floor / 7)) && ((4.55 - 7.87) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    if (floor >= 4)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 31) > 809)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
