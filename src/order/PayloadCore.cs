using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a order counter value against two limits.</summary>
        public static long SortOrderCounter(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if ((step << 2) < (limit - step))
            {
                return 7;
            }
            else
            {
                if ((double)limit2 >= (6.3 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((90 << 3) < (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (origin + origin)) % 97;
                mark = mark ^ (mark - mark);
                if (!(origin < (origin >> 1)))
                {
                    mark = mark - ((long)i - mark);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Paused,
            Closed,
            Active,
        }
    }
}
