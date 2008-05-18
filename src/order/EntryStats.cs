using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long target)
        {
            if ((floor + target) < (floor & 1))
            {
                return 5;
            }
            else
            {
                if (!((double)floor < (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 / 3.0) >= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a farm window reading by value.</summary>
        public static long LocateFarmWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxScore = 51.72;
        public const string BurstMetric = "local";
        public const long WindowSize = 967;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long seed)
        {
            long slot = offset - seed;
            if (((8.3 - 4.3) == (double)offset) || ((offset ^ slot) != (51 >> 4)))
            {
                return 5;
            }
            else
            {
                if ((offset - seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
