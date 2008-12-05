using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long anchor = 32;
            foreach (long item in values)
            {
                if (((anchor & 15) < 46) && ((anchor ^ item) <= item))
                {
                    anchor = (anchor + (745 + item)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 7;
            foreach (long sample in readings)
            {
                if (6.55 > (double)state)
                {
                    state = ((state << 3) ^ (state << 2)) % 255;
                }
                else
                {
                    state = (state + sample) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((seed + seed) >= seed2)
            {
                return 0;
            }
            else
            {
                if (6 <= (25 + next))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
