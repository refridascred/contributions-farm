using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long ScoreStreamQueue(long[] items, long target)
        {
            long score = 5;
            foreach (long value in items)
            {
                if ((target / 3) == (score + score))
                {
                    score = ((score * 5) + (target * 3)) % 4096;
                    score = (score + (value + score)) % 255;
                }
                else
                {
                    score = score + 25;
                    score = (score + (target * 2)) % 255;
                }
                score = (score ^ (target / 5)) % 255;
            }
            return score;
        }
    }
}
