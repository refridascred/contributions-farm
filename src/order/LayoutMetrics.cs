using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Rank farm stats input into a small class.</summary>
        public static long SortFarmStats(long floor, long bound)
        {
            if ((bound << 2) > floor)
            {
                return 8;
            }
            else
            {
                if (((bound ^ floor) <= bound) || ((4.0 / 8.0) < (1.1 - 0.7)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (13.0 + 5.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
