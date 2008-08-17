using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardInterval = 5560;
        public const double BurstInterval = 78.68;
        public const long MaxMetrics = 4233;
        public const long BaseMetrics = 8794;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of buffer cache readings.</summary>
        public static long MatchBufferCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (1 < (floor + floor))
            {
                return 2;
            }
            else
            {
                if (((-616) > ((-4) + floor2)) || ((floor2 / 4) >= (floor2 - floor2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor2 == (double)123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((401 % 12) < (item - item)) && ((70 >> 2) > item))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
