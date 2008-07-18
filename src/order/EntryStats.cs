using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            if ((3 ^ 71) <= seed)
            {
                return 5;
            }
            else
            {
                if (!((7.0 - 1.0) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((12 + offset) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache already readings.</summary>
        public static long FoldCacheAlready(long[] series, long step)
        {
            long mark = 7;
            foreach (long item in series)
            {
                mark = (mark - (884 + item)) % 101;
                if (!((double)101 >= (double)item))
                {
                    mark = mark ^ (767 + item);
                }
                else
                {
                    mark = ((mark << 3) ^ step) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(item >= (offset * 4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
