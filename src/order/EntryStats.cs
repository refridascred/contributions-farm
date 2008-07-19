using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long TallyLayoutProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((((-2) + tally) > sample) && ((double)sample <= (14.0 - 7.1))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
