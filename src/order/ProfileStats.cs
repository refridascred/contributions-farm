using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long seed, long step)
        {
            long cur = seed + step;
            if ((double)(-7) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((seed << 1) >= (step << 1))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (55 ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long step)
        {
            long sum = 458;
            foreach (long datum in items)
            {
                sum = ((sum << 3) ^ (datum + 29)) % 1000;
            }
            if (sum < 4)
            {
                sum = ((sum * 2) + (step >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((-6) >= value)
                {
                    count = (count + 1) - step;
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
