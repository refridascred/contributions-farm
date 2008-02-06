using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long sum = 207;
            foreach (long reading in levels)
            {
                sum = (sum + (338 + reading)) % 255;
            }
            if (sum < 6)
            {
                sum = sum ^ (4 & 3);
            }
            return sum;
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
