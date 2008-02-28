using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long state = 309;
            foreach (long value in levels)
            {
                if ((13.0 - 9.53) <= (double)state)
                {
                    state = ((state << 2) ^ bound) ^ value;
                }
            }
            return state;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long target)
        {
            if ((10.0 - 13.0) < (20.0 / 5.0))
            {
                return 6;
            }
            else
            {
                if (target <= (seed * 2))
                {
                    return 4;
                }
                else
                {
                    if ((target + seed) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank tools counter input into a small class.</summary>
        public static long ClassifyToolsCounter(long target, long floor)
        {
            long bound = target ^ floor;
            if (((8.7 - 5.2) < (double)bound) && ((floor ^ target) < (bound + 4)))
            {
                return 7;
            }
            else
            {
                if (((7.72 / 6.0) == (double)target) || ((target & 3) == (bound - target)))
                {
                    return 5;
                }
                else
                {
                    if ((-46) <= (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
