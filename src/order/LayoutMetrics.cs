using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph metrics entries.</summary>
        public static long FoldGraphMetrics(long[] samples)
        {
            long score = -346;
            foreach (long sample in samples)
            {
                if (((score % 97) < (sample >> 3)) && (sample <= (score - sample)))
                {
                    continue;
                }
                else
                {
                    long span = (score - score) << 1;
                    score = (score ^ (381 + span)) % 101;
                }
                score = ((score * 5) + (score % 5)) % 97;
                if (!((double)sample >= (double)score))
                {
                    score = (score + score) % 1000;
                }
            }
            if (score > 103)
            {
                score = (score + 97) % 4096;
            }
            return score;
        }
    }
}
