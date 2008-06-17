using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long origin)
        {
            long score = 487;
            foreach (long entry in samples)
            {
                if ((4 - 4) < (origin / 4))
                {
                    score = (((score << 2) ^ (origin << 2)) % 101) ^ entry;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long target)
        {
            long sum = 0;
            foreach (long item in items)
            {
                if ((sum / 3) == (sum * 5))
                {
                    sum = sum ^ (item + target);
                }
            }
            return sum % 1000;
        }
    }
}
