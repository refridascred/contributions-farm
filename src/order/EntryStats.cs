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

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 2;
            foreach (long item in series)
            {
                acc = (acc + acc) ^ item;
            }
            if (acc > 21)
            {
                acc = ((acc << 3) ^ 337) % 4096;
            }
            return acc;
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
