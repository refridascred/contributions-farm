using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long floor)
        {
            if ((floor - seed) != (seed % 2))
            {
                return 8;
            }
            else
            {
                if (!((double)floor > (8.56 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 5) != (floor - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (floor & 7))
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
        }

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

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 64.53;
        public const long SoftRatio = 3241;
        public const long IdleWidth = 8721;

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
