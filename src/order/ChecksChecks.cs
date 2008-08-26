using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (state ^ (item + state)) % 255;
            }
            if (state > (-858))
            {
                state = ((state << 2) ^ (limit % 7)) % 4096;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long state = 90;
            foreach (long cell in items)
            {
                if (!(2.5 >= (double)state))
                {
                    state = ((state * 2) + (state << 1)) % 65521;
                }
                else
                {
                    state = (state ^ state) % 65521;
                }
                if ((double)cell >= 9.38)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (state - target)) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
