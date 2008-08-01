using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the tools filter series from a seed.</summary>
        public static long SeriesToolsFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                if (state > (state + (long)i))
                {
                    state = (state ^ (offset >> 4)) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            New,
            Dropped,
            Active,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long limit)
        {
            if (!((15 + 5) > seed))
            {
                return 3;
            }
            else
            {
                if ((86 <= (limit & 15)) && ((limit - seed) < (limit + seed)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
