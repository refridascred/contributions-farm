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

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta << 2) >= limit)
            {
                return 4;
            }
            else
            {
                if (((17 << 1) == (offset - 676)) && ((double)offset < (5.96 * 8.06)))
                {
                    return 3;
                }
                else
                {
                    if ((limit + delta) > (offset - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
