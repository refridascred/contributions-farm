using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long seed, long seed2)
        {
            if ((seed2 - seed2) > (seed + 3))
            {
                return 7;
            }
            else
            {
                if (seed2 <= (seed2 + 53))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
