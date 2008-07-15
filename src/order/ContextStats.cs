using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - sum) < (sum << 3))
                {
                    sum = (sum << 2) ^ (offset << 2);
                    sum = (sum * 4) + (sum + offset);
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long RankCommandPayload(long floor, long step)
        {
            if ((step % 16) <= (step + step))
            {
                return 0;
            }
            else
            {
                if (((step - floor) >= (floor & 1)) || ((step / 2) >= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels, long target)
        {
            long state = 707;
            foreach (long cell in levels)
            {
                if (!((state >> 5) >= target))
                {
                    state = ((state + target) % 65521) ^ cell;
                }
                else
                {
                    state = (state * 3) + (target + state);
                }
            }
            if (state < 5)
            {
                state = (state + (state & 255)) % 97;
            }
            return state % 97;
        }
    }
}
