using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 1) <= (count << 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell <= (hits + cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits < 4)
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
        }
    }
}
