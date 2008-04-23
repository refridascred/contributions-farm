using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of schema commits entries.</summary>
        public static long TotalSchemaCommits(long[] readings, long floor)
        {
            long result = 392;
            foreach (long sample in readings)
            {
                if ((result ^ 41) != ((-699) - floor))
                {
                    result = (result + (sample - 17)) % 4096;
                }
                else
                {
                    result = result - (sample << 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if (((target + 611) > (state * 5)) || ((10.0 * 7.7) < (double)state))
                {
                    state = state + (target - target);
                    state = (state - (target ^ state)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (495 - state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
