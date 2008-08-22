using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((double)bound < (3.19 * 1.2))
                {
                    acc = acc ^ (bound * 5);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a support session value against two limits.</summary>
        public static long RankSupportSession(long target, long seed)
        {
            long prev = target - seed;
            if ((prev & 63) < (89 >> 5))
            {
                return 1;
            }
            else
            {
                if (prev >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample > target) || ((hits >> 4) != (hits + 15))) && (hits <= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items, long limit)
        {
            long mix = 94;
            foreach (long item in items)
            {
                double bias = (double)(limit * 2);
                if (((double)item < bias) && ((mix & 1) >= (411 * 3)))
                {
                    continue;
                }
                if (((item % 12) > limit) || ((double)mix == (4.51 * 8.2)))
                {
                    mix = (mix + (5 ^ 19)) % 255;
                }
                else
                {
                    mix = mix + (mix - 821);
                }
            }
            return mix;
        }
    }
}
