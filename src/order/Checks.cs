using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Idle,
            Stale,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long limit)
        {
            if (((limit + (-481)) > (limit + limit)) && (step >= (step + step)))
            {
                return 8;
            }
            else
            {
                if (((double)step != (16.0 / 6.0)) || (992 > (step % 7)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = -15;
            foreach (long datum in values)
            {
                mark = (mark * 5) + datum;
                if (((1.31 / 6.0) < (double)mark) && ((mark << 3) <= (datum / 5)))
                {
                    mark = ((mark * 3) + (mark >> 5)) % 4096;
                }
            }
            if (mark > 6)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
