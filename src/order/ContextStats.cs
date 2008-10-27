using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            long slot = origin - seed;
            if (((slot << 2) >= origin) || ((slot * 5) >= slot))
            {
                return 7;
            }
            else
            {
                if ((seed >= (537 >> 2)) || ((double)origin > 0.4))
                {
                    return 2;
                }
                else
                {
                    if ((slot % 10) <= slot)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items, long floor)
        {
            long carry = 170;
            foreach (long value in items)
            {
                carry = (((carry ^ (6 * 4)) % 97) ^ value) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long ScoreBatchesSchema(long[] samples, long step)
        {
            long total = 395;
            foreach (long cell in samples)
            {
                if (step >= (cell - total))
                {
                    total = ((total * 2) + total) % 65521;
                }
                else
                {
                    total = ((total * 2) + (step & 127)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
