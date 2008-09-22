using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long target2)
        {
            long lane = target ^ target2;
            if (lane < target)
            {
                return 5;
            }
            else
            {
                if (lane <= target2)
                {
                    return 7;
                }
                else
                {
                    if (!((double)target2 < (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate farm filter samples.</summary>
        public static long CombineFarmFilter(long[] items, long step)
        {
            long total = -7;
            foreach (long datum in items)
            {
                if ((datum & 255) < (datum << 3))
                {
                    total = (total + (total + step)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a cache githubfarm reading by value.</summary>
        public static long FindCacheGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
