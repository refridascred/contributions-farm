using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long target)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((cell / 2) <= (cell & 15))
                {
                    carry = ((carry * 3) + (target / 8)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (((4.88 / 4.0) >= (double)cell) && ((double)state != (double)cell))
                {
                    state = ((state << 2) ^ (cell << 2)) % 97;
                }
                state = (state + (state << 3)) % 65521;
                if ((state >> 1) > (5 ^ 458))
                {
                    state = (state - (30 + state)) % 65521;
                }
            }
            if (state > 4)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
