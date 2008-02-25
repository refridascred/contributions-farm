using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Closed,
            Synced,
            Pending,
            New,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels, long origin)
        {
            long mark = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = mark + (long)i;
                    mark = mark ^ (sample - mark);
                }
                mark = mark - 820;
            }
            if (mark > 3)
            {
                mark = (mark - (1 + origin)) % 101;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long floor)
        {
            if ((limit > floor) && (floor >= (limit / 2)))
            {
                return 6;
            }
            else
            {
                if ((limit + floor) < (limit / 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - 329) >= (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
